using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ITE.Entidades.POCO.Contabil;
using ITE.Entidades.POCO;
using ITE.Entidades.DaoManager.ContabilDaoManager;
using ITSolution.Framework.Mensagem;
using ITE.Entidades.UnitControl;

namespace ITE.Contabil.Desenvolvimento.Lotes
{
    public partial class XFrmAddLoteContabil : DevExpress.XtraEditors.XtraForm
    {
        private LoteContabil _loteAnterior;
        private Usuario _currentUser;

        public XFrmAddLoteContabil()
        {
            InitializeComponent();
            lookUpMatriz1.FindSetMatriz(UnitWork.Filial.Matriz);
        }
        public XFrmAddLoteContabil(LoteContabil loteAnt, Usuario user) : this()
        {
            this._loteAnterior = loteAnt;
            this._currentUser = user;
            IndexarFormulario(loteAnt);
        }

        private void IndexarFormulario(LoteContabil loteAnt)
        {
            lookUpMatriz1.FindSetMatriz(loteAnt.Matriz);
            txtDescricao.Text = loteAnt.DescricaoLote;
            dtInicial.DateTime = loteAnt.DataInicial;
            dtFinal.DateTime = loteAnt.DataFinal.Value;
        }

        public XFrmAddLoteContabil(Usuario user) : this()
        {
            this._currentUser = user;
        }
        private LoteContabil IndexarLote()
        {
            var descricao = txtDescricao.Text;
            var dtInicio = dtInicial.DateTime;
            var dtFim = dtFinal.DateTime;
            var matriz = lookUpMatriz1.Matriz;

            var l = new LoteContabil()
            {
                IdMatriz = matriz.IdMatriz,
                Matriz = matriz,
                DataInicial = dtInicio,
                DataFinal = dtFim,
                DescricaoLote = descricao,
                IdUsuario = _currentUser.IdUsuario,
                DataCriacao = DateTime.Now
            };

            return l;
        }

        private void btnSalvarLote_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var manager = new LoteContabilDaoManager();
            //adicao
            if (_loteAnterior == null)
            {
                var newLote = IndexarLote();
                if (manager.SaveLote(newLote))
                {
                    XMessageIts.Mensagem("Lote criado com sucesso.");
                    this.Dispose();
                }
            }
            else
            {
                _loteAnterior.Update(IndexarLote());

                if (manager.Update(_loteAnterior))
                {
                    XMessageIts.Mensagem("Lote atualizado com sucesso.");
                    this.Dispose();
                }
            }
        }
    }
}