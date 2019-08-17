using System;
using System.Linq;
using ITSolution.Framework.Mensagem;
using ITE.Entidades.POCO;
using System.Threading.Tasks;
using ITSolution.Framework.Beans.ProgressBar;
using ITSolution.Framework.GuiUtil;
using DevExpress.XtraEditors.Controls;
using System.Windows.Forms;
using ITE.Entidades.POCO.TI;
using ITE.Entidades.Enumeradores;
using ITE.Entidades.Repositorio;
using ITE.Vendas.Forms.View;
using ITSolution.Framework.Entities;
using System.Collections.Generic;
using ITSolution.Framework.Util;
using System.Data.Entity;

namespace ITE.Informatica.Forms.Cadastro
{
    public partial class XFrmAddAtendimento : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private Atendimento atendimentoAnt;
        private Endereco endereco;

        public XFrmAddAtendimento()
        {

            InitializeComponent();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            this.ActiveControl = this.memoEditProblemas;
        }

        public XFrmAddAtendimento(Atendimento a)
            : this()
        {
            this.atendimentoAnt = indexarDados(a);

        }

        private async Task refresh()
        {
            var context = new BalcaoContext();
            context.LazyLoading(false);

            //so apontar pro nome do relacionamento
            //var clientes = await Task.Run(()=>context.CliFors.Include("Enderecos").ToList());
            //traz somentes os enderecos
            var clientes = await Task.Run(() => context.CliFors
                                    .Include(c => c.Enderecos).ToList());

            this.searchLookUpCliente.Properties.DataSource = clientes;
            this.searchLookUpCliente.Refresh();

        }

        private Atendimento indexarDados()
        {
            var c = this.searchLookUpCliente.GetSelectedDataRow() as CliFor;
            DateTime dtColeta = dtDataColeta.Value;
            var tipoColeta = (TypeAtendimento)cbTipoColeta.SelectedIndex;
            string problemas = memoEditProblemas.Text;
            var status = TypeStatusAtendimento.Comunicado;

            Atendimento at = new Atendimento(c, tipoColeta, dtColeta, status, problemas, this.endereco);
            at.Responsavel = txtResponsavel.Text;
            at.Telefone = txtTelefone.Text;
            at.Celular = txtCelular.Text;

            return at;
        }

        private Atendimento indexarDados(Atendimento at)
        {
            if (at != null)
            {


                this.endereco = at.Endereco;
                this.barBtnAddEndereco.Caption = "Alterar Endereço";
                var clientes = new List<CliFor>();

                clientes.Add(at.Cliente);

                searchLookUpCliente.Properties.DataSource = clientes;
                searchLookUpCliente.EditValue = at.Cliente;
                searchLookUpCliente.Text = at.Cliente.RazaoSocial;

                //usando selectCells EF tenho que informar selectCells nome da classe
                memoEditProblemas.Text = at.RelatorioAtendimento;
                dtDataColeta.Value = at.DataColeta;

                cbTipoColeta.SelectedIndex = (int)at.TipoColeta;
                this.endereco = at.Endereco;

                if (at.Endereco != null)
                    //endereco
                    txtEndereco.Text = at.Endereco.ToString();

                txtResponsavel.Text = at.Responsavel;
                txtTelefone.Text = at.Telefone;
                txtCelular.Text = at.Celular;
            }

            if (at.StatusAtendimento == TypeStatusAtendimento.Encerrado)
            {

                //somente leitura
                this.barBtnSalvar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                this.barBtnAddEndereco.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                this.barBtnAtualizar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;

                searchLookUpCliente.ReadOnly = true;

                memoEditProblemas.ReadOnly = true;
                dtDataColeta.Enabled = false;

                cbTipoColeta.ReadOnly = true;
                txtEndereco.ReadOnly = true;

                txtResponsavel.ReadOnly = true;
                txtTelefone.ReadOnly = true;
                txtCelular.ReadOnly = true;

                //label1.Visible = false;
                //cbFormat.Visible = false;
            }

            return at;
        }

        private void XFrmAddAtendimento_Shown(object sender, EventArgs e)
        {
            if (atendimentoAnt == null)
            {
                barBtnRefresh_ItemClick(null, null);
            }
        }

        private void bntVoltar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cbTipoColeta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipoColeta.SelectedIndex == (int)TypeAtendimento.PontoAtendimento)
                ComponenteUtil.DesabilitarComponentes(barBtnAddEndereco);
            else
                ComponenteUtil.HabilitarComponentes(barBtnAddEndereco);
        }

        private void barBtnSalvar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.endereco == null)
            {
                XMessageIts.Mensagem("Informe o endereço de coleta");
            }
            else
            {
                Atendimento novo = indexarDados();


                var ctx = new BalcaoContext();

                if (this.atendimentoAnt == null)
                {
                    if (ctx.AtendimentoDao.Save(novo))
                    {
                        XMessageIts.Mensagem("Atendimento agendado com sucesso\n" +
                        "Número do atendimento: " + novo.IdAtendimento);
                        this.Dispose();
                    }
                }
                else
                {
                    var current = ctx.AtendimentoDao.Find(atendimentoAnt.IdAtendimento);

                    current.Update(novo);

                    if (ctx.AtendimentoDao.Update(current))
                    {

                        XMessageIts.Mensagem("Atendimento \"" + current.IdAtendimento + "\" atualizado com sucesso !");
                        this.atendimentoAnt.Update(current);//atualizad do grid
                        this.Dispose();
                    }
                }
            }
        }

        private void barBtnCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.memoEditProblemas.Text.Length > 0 && !barBtnAddEndereco.Caption.Equals("Alterar Endereço"))
            {
                var op = XMessageIts.Confirmacao("Deseja abandonar abertura de atendimento ?", "Atenção");
                if (op == DialogResult.Yes)
                    this.Dispose();
            }
            else
            {
                this.Dispose();
            }

        }

        private void barBtnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XFrmWait.StartTask(refresh());
        }

        private void searchLookUpEdit1_Click(object sender, EventArgs e)
        {
            int i = 2;
            this.searchLookUpCliente.Properties.PopupResizeMode = (ResizeMode)i;
        }

        private void barBtnAddEndereco_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XFrmEnderecoView frm;

            if (endereco == null)
                frm = new XFrmEnderecoView();
            else
                frm = new XFrmEnderecoView(this.endereco);

            frm.ShowDialog();

            var end = frm.EnderecoAdd;

            if (end != null)
            {
                this.endereco = new Endereco(end.NomeEndereco, end.NumeroEndereco, end.Bairro, end.Complemento, end.Cep, end.Uf, end.Cidade, end.TipoEndereco);

                txtEndereco.ReadOnly = false;
                txtEndereco.Text = end.NomeEndereco + ", " + end.NumeroEndereco + ", "
                    + end.Bairro + ", " + end.Complemento + ", " + end.Cep + ", "
                    + end.Uf + ", " + end.Cidade;
                txtEndereco.ReadOnly = true;
            }

        }

        private void chUseEnd_CheckedChanged(object sender, EventArgs e)
        {

            if (chUseEnd.Checked)
            {

                this.txtEndereco.ReadOnly = false;

                var row = searchLookUpCliente.GetSelectedDataRow() as CliFor;

                if (row != null)
                {

                    setEndereco(row);
                }
                else
                {
                    chUseEnd.Checked = false;
                    XMessageIts.Mensagem("Cliente não selecionado !", "Atenção");
                }
            }
            else
            {
                this.txtEndereco.Text = "";
                this.txtEndereco.ReadOnly = false;
            }


        }

        private void setEndereco(CliFor row)
        {

            var lista = row.Enderecos.ToList();

            if (lista.Count > 0)
            {
                var end = lista.FirstOrDefault();

                this.endereco = new Endereco(end.NomeEndereco, end.NumeroEndereco, end.Bairro,
                                        end.Complemento, end.Cep, end.Uf, end.Cidade, end.TipoEndereco);

                txtEndereco.Text = this.endereco.ToString();

                //end.NomeEndereco + ", " + end.NumeroEndereco + ", "
                //+ end.Bairro + ", " + end.Complemento + ", " + end.Cep + ", "
                //+ end.Uf + ", " + end.Cidade;

                txtEndereco.ReadOnly = true;
            }
            else
            {
                XMessageIts.Mensagem("Cliente não possui endereço(s).");
                chUseEnd.Checked = false;
            }
        }

        private void cbFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFormat.SelectedIndex == 0)
            {
                memoEditProblemas.Text = memoEditProblemas.Text.ToUpper();
            }
            else
            {
                memoEditProblemas.Text = memoEditProblemas.Text.ToLower();
                memoEditProblemas.Text = memoEditProblemas.Text.FirstCharToUpper();
            }
            memoEditProblemas.Refresh();
        }

        private void searchLookUpCliente_EditValueChanged(object sender, EventArgs e)
        {
            if (chUseEnd.Checked)
            {
                var row = searchLookUpCliente.GetSelectedDataRow() as CliFor;

                if (row != null)
                {
                    setEndereco(row);
                }
            }
        }
    }
}
