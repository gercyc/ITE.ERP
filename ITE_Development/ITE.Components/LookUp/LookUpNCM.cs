using System;
using System.Linq;
using System.Reflection;
using DevExpress.XtraEditors;
using ITE.Entidades.POCO.Fiscal;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.Beans.Forms;
using ITSolution.Framework.Forms;
using ITSolution.Framework.GuiUtil;
using ITSolution.Framework.Util;

namespace ITE.Components.LookUp
{
    public partial class LookUpNCM : XtraUserControl
    {
        public Delegate AfterSelect { get; set; }

        public Ncms NCM { get; set; }

        public bool IsNcm
        {
            get
            {
                return this.NCM != null;
            }
        }

        public LookUpNCM()
        {
            InitializeComponent();
        }

        private void buttonEditoNcm_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            using (var ctx = new BalcaoContext(false))
            {
                //var paramsEntity = new ParamsFindEntity()
                //{
                //    Context = ctx,
                //    Columns = new string[] { "CodigoNcm",
                //        "DescricaoNcm",
                //        "AliquotaII",
                //        "AliquotaIPI",
                //        "AliquotaPIS",
                //        "AliquotaCOFINS",
                //        "AliquotaICMS",
                //        "AliquotaICMSST" },
                //    Title = "Localizar NCM:",
                //    DynamicObject = null
                //};

                //var selected = XFrmFindEntity.ShowDialogFindEntity<Ncms>(paramsEntity);
                //var codNcm = selected.GetType().GetProperty("CodigoNcm").GetValue(selected, null);

                //carrega o layout dentro do projeto
                var layoutStream = GridViewUtil.GetLayoutStreamFromResource(Assembly.GetExecutingAssembly(),
                "ITE.Components.Resources.ncm_layout.xml");

                var selected = XFrmFindEntity.ShowDialogFindTEntity<Ncms>(ctx, layoutStream);

                if (selected != null)
                    FindSetNCM(selected.CodigoNcm);
            }
        }

        private void txtNcm_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
                FindSetNCM(textEditNcm.Text);
        }

        public void FindSetNCM(string codNcm)
        {
            using (var ctx = new BalcaoContext(false))
            {
                try
                {
                    codNcm = codNcm.Replace(".", string.Empty);

                    var ncm = ctx.NcmsDao.Where(c => c.CodigoNcm == codNcm)
                                   .First();
                    this.NCM = ncm;

                    this.buttonEditNcm.Text = ncm.DescricaoNcm;
                    this.textEditNcm.Text = ncm.CodigoNcm;

                    AfterSelect.DynamicInvoke();
                }
                catch (Exception ex)
                {
                    //da nada nao
                    LoggerUtilIts.ShowExceptionLogs(ex);
                }
            }
        }
    }
}
