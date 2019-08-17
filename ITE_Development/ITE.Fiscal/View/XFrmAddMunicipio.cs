using System;
using ITE.Entidades.POCO.Fiscal;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.Mensagem;

namespace ITE.Fiscal.View
{
    public partial class XFrmAddMunicipio : DevExpress.XtraEditors.XtraForm
    {
        private Municipios _municipioAnt;
       
        public XFrmAddMunicipio()
        {
            InitializeComponent();
        }

        public XFrmAddMunicipio(Municipios municipioAnt) : this()
        {
            this._municipioAnt = municipioAnt;
        }

        private void btnSalvar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (var ctx = new BalcaoContext())
            {
                if (_municipioAnt!=null)
                {
                    var fUpdate = ctx.MunicipiosDao.Find(_municipioAnt.IdMunicipio);
                    fUpdate.Update(indexarMunicipio());

                    if (ctx.MunicipiosDao.Update(fUpdate))
                    {
                        XMessageIts.Mensagem("Municipio atualizado com sucesso!" );
                    }

                }
                else
                {
                    if (ctx.MunicipiosDao.Save(indexarMunicipio()))
                    {
                        XMessageIts.Mensagem("Municipio cadastrado com sucesso!" );
                    }
                    
                    this.Dispose();
                }
            }
        }

        private Municipios indexarMunicipio()
        {
            var uf = lkUnidFederacao.EditValue as UnidadeFederacao;
            string nomeMunicipio = txtNomeLocal.Text;
            string codigoIbge = txtCodigoIbge.Text;

            var municipio = new Municipios(nomeMunicipio, codigoIbge, uf);
            return municipio;
        }

        private void indexarCampos()
        {
            if (_municipioAnt != null)
            {
                lkUnidFederacao.EditValue = _municipioAnt.UnidadeFederacao;
                lkUnidFederacao.Text = _municipioAnt.UnidadeFederacao.CodigoUF;
                lkUnidFederacao.ResetText();
                txtCodigoIbge.Text = _municipioAnt.CodigoIbge;
                txtNomeLocal.Text = _municipioAnt.NomeMunicipio;
            }
        }

        public void carregarUfs()
        {
            using (var ctx = new BalcaoContext())
            {
                var ufs = ctx.UnidadeFederacaoDao.FindAll();
                lkUnidFederacao.Properties.DataSource = ufs;
            }
        }

        private void XFrmAddMunicipio_Shown(object sender, EventArgs e)
        {
            carregarUfs();
            if (_municipioAnt != null) indexarCampos();
        }
    }
}