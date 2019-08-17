using System.Collections.Generic;
using System.Linq;
using ITSolution.Framework.GuiUtil;
using ITE.Entidades.POCO;
using ITSolution.Framework.Util;
using ITSolution.Framework.Validador;
using ITSolution.Framework.Mensagem;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.Beans.Forms;
using ITE.Entidades.POCO.Financeiro;

namespace ITE.Vendas.Forms.Administrativo
{
    public partial class XFrmCreditoCliente : DevExpress.XtraEditors.XtraForm
    {
        private CliFor cliente;
        private List<CreditoCliente> creditos;
        public XFrmCreditoCliente(CliFor cliFor)
        {
            InitializeComponent();
            this.creditos = new List<CreditoCliente>();
            this.cliente = cliFor;
            new TextEditUtil(txtCredito).CustomizeNumberField();
            this.groupControlCredito.Text = cliente.RazaoSocial;
        }

        private void barBtnLancarCredito_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var creditoCliente = indexarDados();

            if (ValidadorDTO.ValidateWarningAll(creditoCliente))
            {
                this.creditos.Add(creditoCliente);
                this.gridControl1.DataSource = this.creditos;
                this.gridControl1.RefreshDataSource();
            }
        }

        private CreditoCliente indexarDados()
        {
            var credito = ParseUtil.ToDecimal(txtCredito.Text);
            var historico = txtHistorico.Text;

            return new CreditoCliente(cliente, credito, historico);
        }

        private void barBtnRemoverCredito_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.gridViewCredito.GetSelectedRows().Length > 0)
            {
                gridViewCredito.DeleteRow();
            }
            else
                XMessageIts.Mensagem("Nenhum registro a ser removido");
        }

        private void barBtnSalvar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (creditos.Count > 0)
            {
                var ctx = new BalcaoContext();
                var validador = new ValidadorDTO();
                int i = 0;
                foreach (var credito in creditos)
                {

                    if (ValidadorDTO.ValidateWarningAll(credito))
                    {
                        bool flag = ctx.CreditoClienteDao.Save(credito);

                        if (!flag)
                            XMessageIts.Erro("Falha ao gerar credito valor: " + credito.ValorCredito);
                        else
                            i++;
                    }
                }

                if (i == creditos.Count)
                {

                    var creditoList = ctx.CreditoClienteDao.Where(cd => cd.IdCliFor == cliente.IdCliFor);

                    XFrmOptionPane.ShowListTextArea<CreditoCliente>(creditoList.ToList(), "Crédito(s) gerados com sucesso" );
                    this.Dispose();
                }

            }
            else
            {
                XMessageIts.Mensagem("Nenhum crédito lançado");
            }
        }
    }
}