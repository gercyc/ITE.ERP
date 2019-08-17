using System;
using ITE.Entidades.Repositorio;
using ITE.Entidades.POCO;
using ITSolution.Framework.Validador;
using ITSolution.Framework.Mensagem;

namespace ITE.Vendas.Forms.View
{
    public partial class XFrmGrupoUsuarioView : DevExpress.XtraEditors.XtraForm
    {
        public XFrmGrupoUsuarioView()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var nome = txtNomeGrupo.Text;
            GrupoUsuario grupo = new GrupoUsuario(nome);

            if (ValidadorDTO.ValidateWarningAll(grupo))
            {

                if (new BalcaoContext().GrupoUsuarioDao.Save(grupo))
                {
                    XMessageIts.Mensagem("Grupo salvo com sucesso");
                    this.Dispose();
                }
            }
        }
    }
}