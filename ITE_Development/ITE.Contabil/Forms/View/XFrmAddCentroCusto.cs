using System;
using DevExpress.XtraEditors;
using ITE.Entidades.POCO.Contabil;
using ITE.Entidades.Repositorio;
using ITE.Entidades.POCO;
using ITSolution.Framework.GuiUtil;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
using ITE.Entidades.DaoManager.ContabilDaoManager;
using ITSolution.Framework.Mensagem;

namespace ITE.Contabil.Forms.View
{
    public partial class XFrmAddCentroCusto : XtraForm
    {
        public CentroCusto CentroCusto { get; }

        public XFrmAddCentroCusto()
        {
            InitializeComponent();
            this.ActiveControl = this.lkpMatriz;
            lkpMatriz.Focus();

            FormsUtil.AddShortcutEscapeOnDispose(this);

            txtCodigoCentro.Text = new CentroCustoDaoManager().GetNextCodigo();
        }

        public XFrmAddCentroCusto(CentroCusto centroCusto)
            : this()
        {
            this.CentroCusto = centroCusto;

            indexarFormulario(centroCusto);


        }

        private CentroCusto indexarDados()
        {
            var matriz = lkpMatriz.EditValue as EmpresaMatriz;
            string codigoCentro = txtCodigoCentro.Text;
            string nomeCentroCusto = txtNomeCentroCusto.Text;

            if (matriz == null)
                matriz = new EmpresaMatriz();

            var cc = new CentroCusto(matriz, codigoCentro, nomeCentroCusto);

            if (CentroCusto != null)
                cc.IdCentroCusto = CentroCusto.IdCentroCusto;

            var pai = lkCentroPai.GetSelectedDataRow() as CentroCusto;
            //se tem pai
            if (pai != null)
                //o parent ID do centro de custo sendo criado/atualizado
                //eh o ID do centro de custo PAI
                cc.ParentId = pai.IdCentroCusto;

            return cc;
        }

        private void indexarFormulario(CentroCusto c)
        {
            if (c != null)
            {
                using (var ctx = new BalcaoContext())
                {

                    lkpMatriz.EditValue = c.Matriz;

                    lkpMatriz.ShowPopup();
                    lkpMatriz.Text = c.Matriz.ToString();
                    if (c.ParentId != null)
                    {
                        lkCentroPai.EditValue = ctx.CentroCustoDao.Find(c.ParentId);
                        lkCentroPai.Text = lkCentroPai.EditValue.ToString();
                        toggleSwitch1.EditValue = true;
                    }
                    else
                        toggleSwitch1.IsOn = false;

                    txtCodigoCentro.Text = c.CodigoCentroCusto;
                    txtNomeCentroCusto.Text = c.NomeCentroCusto;
                }
            }
        }

        private async Task<bool> carregarMatriz()
        {
            using (var ctx = new BalcaoContext())
            {

                var matrizList = await ctx.EmpresaMatrizDao.FindAllAsync();

                this.Invoke(new MethodInvoker(delegate
                {
                    lkpMatriz.EditValue = matrizList.FirstOrDefault();
                    lkpMatriz.Properties.DataSource = matrizList;
                }));
                return true;
            }
        }
        private async Task<bool> carregarCentrosPai()
        {
            using (var ctx = new BalcaoContext())
            {

                var centroList = await ctx.CentroCustoDao.WhereAsync(c => c.ParentId == null);

                this.Invoke(new MethodInvoker(delegate
                {
                    lkCentroPai.Properties.DataSource = centroList;
                }));
                return true;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var novo = indexarDados();
            if (new CentroCustoDaoManager().SaveUpdate(novo))
            {
                if (CentroCusto != null)
                {
                    this.CentroCusto.Update(novo);
                }
                //libera a memoria do objeto
                this.Dispose();

            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void rdDestinacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rdDestinacao.SelectedIndex == 0)
            {
                lblFlag.Appearance.Image = Properties.Resources.caixa_Credito;
            }
            else if (rdDestinacao.SelectedIndex == 1)
            {
                lblFlag.Appearance.Image = Properties.Resources.caixa_Debito;
            }
            else
            {
                lblFlag.Appearance.Image = null;
            }
        }

        private void lkCentroPai_EditValueChanged(object sender, EventArgs e)
        {
            var cc = lkCentroPai.GetSelectedDataRow() as CentroCusto;

            if (cc != null)
            {
                //se eu sou uma pai
                if (cc.ParentId == null)
                {

                    //logo tenho filhos ou nao
                    using (var ctx = new BalcaoContext())
                    {

                        var filhos = ctx.CentroCustoDao.Where(c => c.ParentId == cc.IdCentroCusto);
                        string countFilhos = (filhos.Count() + 1).ToString();


                        if (countFilhos.Length > 1)
                            txtCodigoCentro.Text = cc.CodigoCentroCusto + "." + countFilhos;
                        else
                            txtCodigoCentro.Text = cc.CodigoCentroCusto + "." + "0" + countFilhos;

                    }
                }
                else
                {
                    XMessageIts.Advertencia("O Centro de custo selecionado não pode possui níveis.");
                }

            }
        }

        private async void XFrmAddCentroCusto_Shown(object sender, EventArgs e)
        {
            bool result = await Task.Run(carregarMatriz);
            bool result_2 = await Task.Run(carregarCentrosPai);

            if (result && result_2)
            {
                lkpMatriz.ShowPopup();
                var m = lkpMatriz.EditValue;

                if (m != null)
                    lkpMatriz.Text = m.ToString();
                lkpMatriz.ClosePopup();

                var c = lkCentroPai.EditValue;

                if (c != null)
                    lkCentroPai.Text = c.ToString();
                lkCentroPai.ClosePopup();
            }

        }

        private void XFrmAddCentroCusto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.S)
                btnSalvar_Click(null, null);
        }

        private void toggleSwitch1_EditValueChanged(object sender, EventArgs e)
        {

            if (toggleSwitch1.IsOn)
            {
                this.lkCentroPai.Enabled = true;
                this.txtCodigoCentro.Enabled = true;

            }
            else
            {
                this.lkCentroPai.EditValue = null;
                this.lkCentroPai.Enabled = false;
                this.txtCodigoCentro.Enabled = false;
                this.txtCodigoCentro.Text = CentroCusto.CodigoCentroCusto;
            }
        }
    }
}