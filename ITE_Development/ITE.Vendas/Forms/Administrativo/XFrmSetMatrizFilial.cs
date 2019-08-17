using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ITE.Entidades.DaoManager;
using ITE.Entidades.POCO;
using ITE.Entidades.Repositorio;
using ITE.Entidades.UnitControl;
using ITSolution.Framework.Arquivos;
using ITSolution.Framework.Dao.Contexto;
using ITSolution.Framework.Enumeradores;
using ITSolution.Framework.Impressora;
using ITSolution.Framework.Mensagem;
using ITSolution.Framework.Util;

namespace ITE.Vendas.Forms.Administrativo
{
    public partial class XFrmSetMatrizFilial : DevExpress.XtraEditors.XtraForm
    {

        public bool IsFilial { get { return this.lookUpMatrizFilial1.IsMatrizFilial; } }
        public EmpresaFilial Filial { get { return this.lookUpMatrizFilial1.Filial; } }

        public bool IsInvoke { get; private set; }
        public bool IsCancel { get; private set; }
        public bool IsOk { get; set; }
        private FormTypeAction _action;


        public XFrmSetMatrizFilial(EmpresaFilial f = null, FormTypeAction action = FormTypeAction.Selecionar)
        {
            InitializeComponent();
            this._action = action;

            if (f != null)
            {
                this.lookUpMatrizFilial1.Matriz = f.Matriz;
                this.lookUpMatrizFilial1.Filial = f;
            }
            this.IsInvoke = true;
        }
        //carraga as preferencias do arquivo de preferencias

        public void SetPreferences(BalcaoContext ctx=null)
        {
            if (ctx == null)
                ctx = new BalcaoContext();

            using (ctx)
            {
                try
                {
                    var dataPreferences = FileManagerIts.GetDataFile(UnitWork.PREFERENCIAS);

                    //sempre passa aqui
                    if (dataPreferences.Count >= 2)
                    {
                        this.IsInvoke = false;

                        string codMatriz = ASCIIEncodingIts.Decoded(dataPreferences[0]);
                        string codFilial = ASCIIEncodingIts.Decoded(dataPreferences[1]);

                        this.lookUpMatrizFilial1.FindSetMatriz(codMatriz);

                        this.lookUpMatrizFilial1.FindSetFilial(codFilial);

                        UnitWork.Filial = this.Filial;

                        //se salvou eh true;
                        this.chBoxMemorizarFilial.Checked = true;


                        if (!this.lookUpMatrizFilial1.IsMatrizFilial)
                        {
                            this.IsInvoke = true;
                            return;
                        }

                        //tenha certeza q os argumentos setados existem
                        if (dataPreferences.Count == 4 && UnitWork.Filial != null)
                        {
                            try
                            {
                                //se o tem o index 3 entao eh true
                                this.chBoxLoginAuto.Checked = true;
                                //nao chame essa tela
                                this.IsInvoke = false;

                                int idUser = ParseUtil.ToInt(ASCIIEncodingIts.Decoded(dataPreferences[3]));

                                UnitWork.Usuario = ctx.UsuarioDao.Find(idUser);
                            }
                            catch
                            {
                                UnitWork.Usuario = null;
                            }


                            //se estou selecionando e o flag verdade 
                            //passe direto
                            //se o flag nao for selecionar abri o form para alterar os argumentos
                            //que ja existem setados
                            if (_action == FormTypeAction.Selecionar && this.chBoxLoginAuto.Checked)
                                btnOk_ItemClick(null, null);
                        }
                    }

                }
                catch (Exception ex)
                {
                    LoggerUtilIts.ShowExceptionLogs(ex);
                    DeletePreferences();
                }
                
                var param = ParametroManager.FindParamByTypeParametro(TypeParametro.dir_digitalizacoes);
                PrinterUtilIts.DirDefault = param.ValorParametro;
            }
        }


        public void DeletePreferences()
        {
            FileManagerIts.DeleteFile(UnitWork.PREFERENCIAS);
        }

        //criptografa os dados do arquivo
        private void Criptografar(EmpresaMatriz matriz,EmpresaFilial filial, bool flag)
        {
            string codMat = ASCIIEncodingIts.Coded(matriz.CodigoMatriz);
            string codFilial = ASCIIEncodingIts.Coded(filial.CodigoFilial);
            string idUser = ASCIIEncodingIts.Coded(""+UnitWork.Usuario.IdUsuario);

            if (flag)
            {
                FileManagerIts.OverWriteOnFile(UnitWork.PREFERENCIAS,
                                new string[] {codMat,codFilial, "true", idUser,
                                });
            }
            else
            {
                FileManagerIts.OverWriteOnFile(UnitWork.PREFERENCIAS, 
                    new string[] { codMat, codFilial, });
            }

        }

        private void chBoxAuto_CheckedChanged(object sender, System.EventArgs e)
        {
            //permissao para gravar usuario e senha no arquivo de preferencia
            //marca a opção de lembra a filial tbm
            chBoxMemorizarFilial.Checked = chBoxLoginAuto.Checked;

        }

        private void btnCancelar_ItemClick(object sender, System.EventArgs e)
        {
            this.IsCancel = true;
            this.Dispose();

        }

        public void ChangeIconBtnOk(Image img)
        {
            btnOk.Image = img;
            btnOk.Text = "Conectar";
        }

        private void btnOk_ItemClick(object sender, System.EventArgs e)
        {
            if (lookUpMatrizFilial1.IsMatrizFilial)
            {
                try
                {
                    var matriz = this.lookUpMatrizFilial1.Matriz;
                    var filial = lookUpMatrizFilial1.Filial;

                    UnitWork.Filial = filial;

                    //permissao para login automatico
                    if (chBoxLoginAuto.Checked)
                        Criptografar(matriz, filial, true);

                    //automaticamente cancela o evento acima
                    else if (chBoxMemorizarFilial.Checked)
                        Criptografar(matriz, filial, false);

                    else
                        File.Delete(UnitWork.PREFERENCIAS);


                }
                catch (Exception ex)
                {
                    XMessageIts.ExceptionMessage(ex);
                }

                this.IsInvoke = false;

                this.Dispose();

            }
        }

        private void XFrmSetMatrizFilial_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.Enter)
                btnOk_ItemClick(null, null);

            else if (e.Modifiers == Keys.Control && e.KeyCode == Keys.M)
                chBoxMemorizarFilial.Checked = !chBoxMemorizarFilial.Checked;

            else if (e.Modifiers == Keys.Control && e.KeyCode == Keys.S)
                chBoxLoginAuto.Checked = !chBoxLoginAuto.Checked;
        }

        private void XFrmSetMatrizFilial_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!this.IsCancel && UnitWork.Filial == null)
            {
                MessageBoxTick.Show("Matriz e filial não foram informadas, contagem para fechamento ...", "Aviso");
                Application.Exit();
            }
        }

        private void chBoxMemorizarFilial_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxLoginAuto.Checked && !chBoxMemorizarFilial.Checked)
            {
                //se o cara desmarcar volte
                chBoxMemorizarFilial.Checked = true;
            }
        }

        private void XFrmSetMatrizFilial_Shown(object sender, EventArgs e)
        {
            this.lookUpMatrizFilial1.FocusCodigoMatriz();
        }

    }
}
