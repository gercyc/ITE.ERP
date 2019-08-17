using System;
using ITE.Entidades.POCO.RH;
using ITSolution.Framework.Mensagem;
using ITE.Entidades.Repositorio;

namespace ITE.RH.Forms.View
{
    public partial class XFrmAddDepartamento : DevExpress.XtraEditors.XtraForm
    {
        private Departamento deptoAnt;
        public XFrmAddDepartamento()
        {            
            InitializeComponent();
            this.ActiveControl = this.txtNomeDepto;
            this.txtNomeDepto.Focus();
        }
        public XFrmAddDepartamento(Departamento depto) : this()
        {
            this.deptoAnt = indexarDados(depto);
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var novo = indexarDepartamento();

            using (var ctx = new BalcaoContext())
            {

                if (deptoAnt == null)
                {
                    if (ctx.DepartamentoDao.Save(novo))
                    {
                        XMessageIts.Mensagem("Departamento incluso com sucesso !");
                        this.Dispose();

                    }
                }
                else
                {
                    var deptoBd = ctx.DepartamentoDao.Find(deptoAnt.IdDepartamento);
                    deptoBd.Update(novo);

                    if (ctx.DepartamentoDao.Update(deptoBd))
                    {
                        this.deptoAnt.Update(deptoBd);
                        XMessageIts.Mensagem("Departamento atualizado com sucesso!");
                        this.Dispose();

                    }
                }
            }
        }
   
        private Departamento indexarDepartamento()
        {
            return new Departamento(txtNomeDepto.Text);
        }
        private Departamento indexarDados(Departamento depto)
        {
            if (depto != null)
            {
                txtIdDepto.Text = depto.IdDepartamento.ToString();
                txtNomeDepto.Text = depto.NomeDepartamento;
            }
            return depto;
        }

    
    }
}