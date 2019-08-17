using System;
using ITE.Entidades.DaoManager.VendasDaoManager;
using ITE.Entidades.POCO.Sales;
using ITSolution.Framework.Mensagem;
using ITSolution.Framework.Util;

namespace ITE.Vendas.Forms.View
{
    public partial class XFrmUnidadeMedidaView : DevExpress.XtraEditors.XtraForm
    {
        private UnidadeMedida unidMedidaAnt;

        public XFrmUnidadeMedidaView()
        {
            InitializeComponent();
        }

        public XFrmUnidadeMedidaView(UnidadeMedida unidadeMedida)
           : this()
        {

            this.unidMedidaAnt = indexarCampos(unidadeMedida);
        }

        private UnidadeMedida indexarCampos(UnidadeMedida unidadeMedida)
        {
            txtID.Text = unidadeMedida.IdUnidadeMedida.ToString();
            txtCodUnidmedida.Text = unidadeMedida.NomeUnidadeMedida;
            txtNomeUnidMedida.Text = unidadeMedida.Descricao;

            return unidadeMedida;
        }

        private UnidadeMedida indexarDados()
        {
            var codigo = txtCodUnidmedida.Text;
            var nome = txtNomeUnidMedida.Text;

            var novo = new UnidadeMedida(codigo, nome);

            if (unidMedidaAnt != null)
                novo.IdUnidadeMedida = unidMedidaAnt.IdUnidadeMedida;
            return novo;
        }

        private void btnNovo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            indexarCampos(new UnidadeMedida());
        }

        private void btnExcluir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int id = ParseUtil.ToInt(txtID.Text);
            if (id > 0)
                new UnidadeMedidaDaoManager().Delete(id);
            else
                XMessageIts.Advertencia("Código da UN inválido");

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var novo = indexarDados();
            if (new UnidadeMedidaDaoManager().SaveUpdate(novo))
            {
                if (unidMedidaAnt != null)
                    unidMedidaAnt.Update(novo);
                //libera a memoria do objeto
                this.Dispose();

            }
        }
    }
}