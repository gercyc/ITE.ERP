using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.Eventos.GridViewEvents;
using ITSolution.Framework.Beans.ProgressBar;
using ITE.Entidades.POCO.Fiscal.NFe;
using ITSolution.Framework.GuiUtil;
using ITSolution.Framework.Mensagem;
using ITSolution.Framework.Beans.Forms;
using ITSolution.Framework.Arquivos;
using ScintillaNET;
using ITE.Fiscal.NFe;

namespace ITE.Fiscal.CentralFiscal
{
    public partial class XFrmPainelNFe : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private readonly FocusRowChangedEvent _gridFocusUtil;

        public XFrmPainelNFe()
        {
            InitializeComponent();
            this._gridFocusUtil = new FocusRowChangedEvent(gridView1);
        }

        private void btnSalvarXML_ItemClick(object sender, ItemClickEventArgs e)
        {
            var nfe = GridViewUtil.GetFocusedRow<NFeEstadual>(gridView1);
            if (nfe != null)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "XML File | *.XML";
                save.FileName = "NFe-" + nfe.ChaveAcesso;
                var op = save.ShowDialog();                
                if(op == DialogResult.OK)
                {
                    FileManagerIts.OverWriteFile(save.FileName, nfe.XmlNfe);
                }
            }
        }

        private void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            XFrmWait.StartTask(carregarNotas(), "Carregando NFes");
        }

        private void btnViewXml_ItemClick(object sender, ItemClickEventArgs e)
        {
            var focus = GridViewUtil.GetFocusedRow<NFeEstadual>(gridView1);

            new XFrmHighlighting(focus.XmlNfe, Lexer.Xml).ShowDialog();
        }
        private async Task carregarNotas()
        {
            using (var ctx = new BalcaoContext())
            {
                var notasFiscais = await ctx.NFeEstadualDao.FindAllAsync();

                this.Invoke(new MethodInvoker(delegate
                {
                    gridControl1.DataSource = notasFiscais.ToList();
                    this._gridFocusUtil.KeepFocusedRowChanged();
                    this.gridView1.Focus();
                }));
            }
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                using (var ctx = new BalcaoContext())
                {
                    var nfe = GridViewUtil.GetFocusedRow<NFeEstadual>(gridView1);
                    if (nfe != null)
                    {
                        var nfeDel = ctx.NFeEstadualDao.Find(nfe.IdNfe);
                        if (ctx.NFeEstadualDao.Delete(nfeDel))
                            btnRefresh_ItemClick(null, null);
                    }
                }
            }
            catch (Exception ex)
            {
                XMessageIts.ExceptionMessageDetails(ex, "Erro ao excluir NFe");
            }
        
            
        }

        private void XFrmPainelNFe_Shown(object sender, EventArgs e)
        {
            btnRefresh_ItemClick(null, null);
        }

        private void btnAssinarDocumento_ItemClick(object sender, ItemClickEventArgs e)
        {
            var seleted = gridView1.GetFocusedRow<NFeEstadual>();
            var man = new ITE.Fiscal.NFe.NfeManager();
            man.AssinarNFe(seleted);
        }

        private void btnEnviaNFe_ItemClick(object sender, ItemClickEventArgs e)
        {
            var nfsSelected = GridViewUtil.GetSelectedItens<NFeEstadual>(gridView1);
            var man = new ITE.Fiscal.NFe.NfeManager();

            if (man.GerarLoteEnvio(nfsSelected))
                XMessageIts.Mensagem("Lote gerado com sucesso");

        }

        private void btnValidarXml_ItemClick(object sender, ItemClickEventArgs e)
        {
            var nfsSelected = GridViewUtil.GetFocusedRow<NFeEstadual>(gridView1);
            var schema = @"C:\Users\Gercy\Documents\Visual Studio 2015\TFS\ITE\ITE.Fiscal\NFe\XMLSchemas\PL_009_V4\nfe_v4.00.xsd";
            var manager = new NfeManager();
            manager.ValidarXml(nfsSelected.XmlNfe, schema);
        }
    }
}