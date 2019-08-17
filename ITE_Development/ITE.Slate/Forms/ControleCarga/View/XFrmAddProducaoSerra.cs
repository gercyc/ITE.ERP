using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITE.Entidades.POCO;
using ITE.Entidades.POCO.Ardosia.ProductionSlate;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.Arquivos;
using ITSolution.Framework.Beans.Forms;
using ITSolution.Framework.GuiUtil;
using ITSolution.Framework.Mensagem;
using ITSolution.Framework.Util;

namespace ITE.Slate.Forms.ControleCarga.View
{
    public partial class XFrmAddProducaoSerra : DevExpress.XtraEditors.XtraForm
    {
        private readonly Usuario _user;
        private readonly List<ProducaoSerra> _materiaisProduzido;
        private Serra _serra;

        public XFrmAddProducaoSerra(Usuario user)
        {
            InitializeComponent();
            this._user = user;
            this._materiaisProduzido = new List<ProducaoSerra>();
            this.gridControl1.DataSource = this._materiaisProduzido;
            this.dateEditDtProducao.DateTime = DateTime.Now;

            //TAB 2 começa oculta
            this.xtraTabPage2.PageVisible = false;

            if (!this._user.IsAdmin)
            {
                this.gridView1.Columns.Remove(colValorMetroQuadrado);
                this.gridView1.Columns.Remove(colTotalProduzido);
            }
            lookUpMaterialSerra1.RedirectFocusTo(txtQuantidadePeca);

        }


        private async Task carregarSerras()
        {
            using (var ctx = new SlateContext())
            {
                var result = await ctx.SerraDao.FindAllAsync();
                cbSerras.AddList(result);
            }
        }

        //Esconde o flyout apos 1,3 segundo
        private void hideThenShow()
        {
            Thread.Sleep(1300);

            this.flyoutPanelControl1.BeginInvoke(new Action(() =>
            {
                this.flyoutPanelControl1.Visible = false;

            }));

            this.flyoutPanel1.BeginInvoke(new Action(() =>
            {
                this.flyoutPanel1.HidePopup();

            }));
        }

        private void atualizarGrid()
        {
            //this.gridControl1.DataSource = this._materiaisProduzido;
            this.gridView1.RefreshData();
        }

        private void exportar()
        {
            try
            {
                var excelFile = Path.Combine(FileManagerIts.DeskTopPath,
                    @"Import-" + DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss") + ".xlsx");

                Console.WriteLine(excelFile);

                gridControl1.ExportToXlsx(excelFile);
                FileManagerIts.OpenFromSystem(excelFile);
            }
            catch
            {
                XMessageIts.Erro("Falha ao exportar!");
            }

        }

        private async void XFrmAddProducaoSerra_Load(object sender, EventArgs e)
        {
            await this.carregarSerras();
            //XFrmWait.StartTask(this.carregarSerras());
        }

        private void XFrmProducaoArdosia_Shown(object sender, EventArgs e)
        {
            cbSerras.ShowPopup();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (cbSerras.SelectedIndex >= 0)
            {
                this.xtraTabPage2.PageVisible = true;
                btnConfirmar.Enabled = false;
                btnAlterar.Enabled = true;
                cbSerras.Enabled = false;
                dateEditDtProducao.Enabled = false;
                this.xtraTabControl1.SelectedTabPage = xtraTabPage2;
                this._serra = cbSerras.GetSelectedItem<Serra>();
                xtraTabPage2.Text = "Produção: " + _serra.NomeSerra;
            }
            else
            {
                XMessageIts.Mensagem("Informe a serra e a data da produção para iniciar os lançamentos!");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            cbSerras.ShowPopup();
            this.xtraTabPage2.PageVisible = false;
            btnConfirmar.Enabled = true;
            cbSerras.Enabled = true;
            dateEditDtProducao.Enabled = true;
        }

        private void cbSerras_SelectedIndexChanged(object sender, EventArgs e)
        {
            this._materiaisProduzido.Clear();
            this.lookUpMaterialSerra1.Clear();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (_materiaisProduzido.Count > 0)
            {
                try
                {

                    using (var ctx = new SlateContext())
                    {

                        var dataProducao = dateEditDtProducao.DateTime.ToDateZerada();
                        //essa tabela possui uma chave composta
                        //Serra
                        //Material
                        //Data

                        var itensDuplicados = new List<ProducaoSerra>();

                        foreach (ProducaoSerra s in _materiaisProduzido)
                        {

                            try
                            {

                                var r = ctx.ProducaoSerraDao
                                    .Where(p => p.IdSerra == _serra.IdSerra
                                                && p.IdMaterial == s.IdMaterial
                                                && p.DataProducao == dataProducao)
                                    .First();

                                itensDuplicados.Add(r);

                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Nada encontrado" + ex.Message);
                            }

                        }

                        if (itensDuplicados.Count > 0)
                        {

                            //se existe um material
                            XFrmOptionPane.ShowListTextArea(itensDuplicados,
                                "Materiais já produzido anteriormente: \n"
                                + _serra.NomeSerra + " em " +
                                dateEditDtProducao.DateTime.ToShortDateString());
                            //"*** Atenção - Produto já adicionado ***");

                        }
                        else
                        {
                            this._materiaisProduzido.ForEach(delegate (ProducaoSerra i)
                            {
                                //comunicao o relacionamento que nao deve criar outro material
                                i.Material = null;
                                i.Serra = null;
                                ctx.ProducaoSerraDao.Save(i);

                            });
                            XMessageIts.Mensagem("Produção da \"" +
                                                 _serra.NomeSerra + "\" salva com sucesso!");
                            this.Dispose();
                        }

                    }

                }
                catch (Exception ex)
                {
                    LoggerUtilIts.ShowExceptionLogs(ex);
                    XMessageIts.ExceptionMessageDetails(ex,
                        "Falhar ao salvar produçaõ do dia " + dateEditDtProducao.DateTime.ToShortDateString());
                    throw ex;
                }
            }
            else
            {
                XMessageIts.Mensagem("Nada produzido a ser salvo !");
            }
        }

        private void XFrmAddItemSerra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.F)
                lookUpMaterialSerra1.RequestFocus();

            else if (e.Modifiers == Keys.Control && e.KeyCode == Keys.L)
                lookUpMaterialSerra1.ShowFindMaterial();


            else if (e.Modifiers == Keys.Control && e.KeyCode == Keys.Delete)
            {
                this.lookUpMaterialSerra1.Clear();
                this._materiaisProduzido.Clear();
                this.gridView1.RefreshData();
            }

            else if (e.Modifiers == Keys.Control && e.KeyCode == Keys.S)
                btnSalvar_Click(null, null);

            else if (e.Modifiers == Keys.Control && e.KeyCode == Keys.E)
                exportar();

        }

        private void xtraTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            lookUpMaterialSerra1.RequestFocus();
        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                gridView1.DeleteSelectedRows();
        }

        private void gridView1_CellValueChanged(object sender,
            DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column == colQuantidadePeca)
            {
                var item = gridView1.GetFocusedRow() as ProducaoSerra;

                if (ParseUtil.ToInt(e.Value) == 0)
                {
                    XMessageIts.Advertencia("Quantidade de peças deve ser no minímo 1.", "Quantide inválida");
                    item.QuantidadePeca = 1;
                }
                else
                {
                    item.Update(item);
                }
            }
        }

        private void txtQuantidadePeca_Enter(object sender, EventArgs e)
        {
            txtQuantidadePeca.SelectAll();
        }

        private void btnRemoveMaterial_Click(object sender, EventArgs e)
        {
            gridView1.DeleteSelectedRows();
        }

        private void txtQuantidadePeca_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.btnAddProduto_Click(null, null);
            }
        }

        private async void btnAddProduto_Click(object sender, System.EventArgs e)
        {
            var material = lookUpMaterialSerra1.Produto;

            if (material == null)
            {
                XMessageIts.Mensagem("Informe o material produzido!");
            }
            else
            {
                int qtde = ParseUtil.ToInt(txtQuantidadePeca.Text);

                if (qtde <= 0)
                    XMessageIts.Advertencia("Informe a quantidade produzida!", "Atenação");
                else
                {

                    //usando initializer
                    var itemProduzido = new ProducaoSerra(_serra, material, _user, dateEditDtProducao.DateTime, qtde);

                    try
                    {

                        var result = _materiaisProduzido
                            .First(i => i.Material.NomeMaterial == itemProduzido.Material.NomeMaterial);

                        if (chAtualizar.Checked)
                        {

                            var r = this._materiaisProduzido.Find(i =>
                                    i.IdMaterial == itemProduzido.IdMaterial);
                            r.QuantidadePeca += itemProduzido.QuantidadePeca;

                            r.Update(r);
                            lblMessage.Text = "Material:" + r.Material + " foi atualizado!";

                            lookUpMaterialSerra1.RequestFocus();

                            flyoutPanelControl1.Visible = true;
                            flyoutPanel1.ShowPopup();
                            SoundUtil.Beep();
                            atualizarGrid();
                        }
                        else
                            XMessageIts.Mensagem("Material \"" + result.Material
                                                 + "\" já foi adicionado!\n\n" +
                                                 "Você pode alterar a quantidade diretamente na tabela.",
                                "Atenção - Produto já foi adicionado !!!");


                    }
                    catch (Exception)
                    {
                        this._materiaisProduzido.Add(itemProduzido);
                        lookUpMaterialSerra1.Focus();
                        lookUpMaterialSerra1.RequestFocus();
                        atualizarGrid();
                    }
                    await Task.Run(() => hideThenShow());
                }
            }
        }

    }

}