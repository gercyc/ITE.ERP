using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using ITE.Entidades.DaoManager;
using ITE.Entidades.Enumeradores;
using ITE.Entidades.POCO;
using ITE.Entidades.POCO.Sales;
using ITE.Entidades.Repositorio;
using ITE.Entidades.UnitControl;
using ITSolution.Framework.Arquivos;
using ITSolution.Framework.GuiUtil;
using ITSolution.Framework.Mensagem;
using ITSolution.Framework.Util;
using ITE.Entidades.POCO.Fiscal;
using ITSolution.Framework.Beans.Forms;
using ITSolution.Framework.Forms;
using ITE.Entitidades.Enumeradores.FiscalEnum;

namespace ITE.Vendas.Forms.Informativo
{
    public partial class XFrmDetalhesProduto : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private readonly Usuario user;
        private Produto _produtoAnt;
        private List<TransacoesProduto> transacoesProduto = new List<TransacoesProduto>();

        private XFrmDetalhesProduto()
        {
            InitializeComponent();
            this.ActiveControl = this.txtDescricao;
            this.openFileFoto.Filter = ImageUtilIts.ImageFilter;           

            new TextEditUtil(txtPrecoCompra).CustomizeNumberField();
            new TextEditUtil(txtPrecoVenda).CustomizeNumberField();
            this.cbTipoItem.AddEnumValues<TypeTipoItemEFD>();
            FormsUtil.AddShortcutEscapeOnDispose(this);
        }

        public XFrmDetalhesProduto(Produto p, Usuario user)
            : this()
        {
            this.Text = "Edição Produto: " + p.DescricaoProduto;
            this._produtoAnt = indexarCampos(p);
            IndexardadosEstoque(p);
            this.user = user;
        }

        private Produto indexarCampos(Produto p)
        {

            if (p != null)
            {
                //var ctx = new BalcaoContext();
                dtCadastro.DateTime = p.DataCadastro;
                txtDescricao.Text = p.DescricaoProduto;
                txtMargemLucro.Text = p.MargemLucro.ToString("N2");
                txtPrecoCompra.Text = p.PrecoCompra.ToString("N2");
                txtPrecoVenda.Text = p.PrecoVenda.ToString("N2");
                btnQtdPrd.Text = p.QuantidadeProduto.ToString("n3");
                cbUnidadeMed.AddItem<UnidadeMedida>(p.UnidadeMedida);
                btnNcm.Text = p.CodigoNCM;
                cbTipoItem.SelectedIndex = (int)p.IdentificacaoProduto;

                if ((int)p.StatusProduto < 0 || (int)p.StatusProduto > 2)
                {
                    p.StatusProduto = 0;
                }
                cbStatusProduto.SelectedIndex = (int)p.StatusProduto;

                txtCodigoBarras.Text = p.CodigoBarras;
                cbCategoriaProduto.AddItem<CategoriaProduto>(p.CategoriaProduto);
                cbCategoriaProduto.Refresh();
                pictureFotoProduto.Image = ImageUtilIts.GetImageFromBytes(p.FotoProduto);

                radioTipoProduto.SelectedIndex = (int)p.TipoItemProduto;


                //atributos
                txtComprimento.Text = p.Atributos.Comprimento.ToString();
                txtLargura.Text = p.Atributos.Largura.ToString();
                txtEspessura1.Text = p.Atributos.Espessura1.ToString();
                txtEspessura2.Text = p.Atributos.Espessura2.ToString();

                txtAcabamento.Text = p.Atributos.Acabamento;
                txtCor.Text = p.Atributos.Cor;

                gridControlTransacoes.DataSource = p.TransacoesProduto.ToList()
                    .OrderByDescending(t => t.DataTransacao);

                gridControlAlteracoes.DataSource = p.AlteracoesProduto.ToList()
                    .OrderByDescending(a => a.DataAlteracao);


                setProdutoEditavel(p);

            }
            return p;
        }

        private void setProdutoEditavel(Produto p)
        {

            using (var ctx = new BalcaoContext())
            {
                try
                {
                    var i = ctx.ItemVendaDao.First(it => it.IdProduto == p.IdProduto);


                    //nao deixe editar nada se tem venda vinculada
                    ComponenteUtil.ReadyOnly(true, cbStatusProduto,
                            txtCodigoBarras,
                            txtDescricao,
                            cbCategoriaProduto,
                            cbUnidadeMed,
                            radioTipoProduto,
                            txtComprimento,
                            txtLargura,
                            txtEspessura1,
                            txtEspessura2);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Produto pode ser totalmente editado: " + ex.Message);
                    var data1 = p.DataCadastro;
                    var data2 = DateTime.Now;
                    var prazo = DataUtil.CalcularDias(data1, data2);
                    //vai deixar edita somente se nao tem uma semana q cadastro
                    //7 dias eh o prazo para notar algo errado no cadastro
                    if (prazo >= 7)
                    {
                        ComponenteUtil.ReadyOnly(false, cbStatusProduto,
                            txtCodigoBarras,
                            txtDescricao,
                            cbCategoriaProduto,
                            cbUnidadeMed,
                            radioTipoProduto);
                    }
                }
            }
        }

        private Produto indexarDados()
        {
            Produto novo = new Produto();
            var categoria = cbCategoriaProduto.GetSelectedItem<CategoriaProduto>();
            var unidMedida = cbUnidadeMed.GetSelectedItem<UnidadeMedida>();

            novo.DescricaoProduto = txtDescricao.Text;
            novo.IdCategoriaProduto = categoria.IdCategoriaProduto;
            novo.IdUnidadeMedidaProduto = unidMedida.IdUnidadeMedida;
            novo.MargemLucro = ParseUtil.ToDecimal(txtMargemLucro.Text);
            novo.PrecoCompra = ParseUtil.ToDecimal(txtPrecoCompra.Text);
            novo.PrecoVenda = ParseUtil.ToDecimal(txtPrecoVenda.Text);
            novo.QuantidadeProduto = ParseUtil.ToDecimal(btnQtdPrd.Text, 3);

            novo.CodigoBarras = txtCodigoBarras.Text;

            novo.StatusProduto = (TypeStatusProduto)cbStatusProduto.SelectedIndex;
            novo.TipoItemProduto = radioTipoProduto.SelectedIndex == 0
                                    ? TypeItemProduto.Produto
                                    : TypeItemProduto.Servico;
            novo.CodigoNCM = btnNcm.Text;


            //var enumValue = cbTipoItem.SelectedItem as EnumTypeClazz;//posso passar tbm o EnumType
            novo.IdentificacaoProduto = (TypeTipoItemEFD)cbTipoItem.SelectedIndex;

            //adicione a alteracao ao produto
            novo.AlteracoesProduto.Add(new AlteracaoProduto(novo.IdProduto,
                "A", 0.0m, DateTime.Now, _produtoAnt.PrecoVenda, _produtoAnt.PrecoCompra, _produtoAnt.QuantidadeProduto));
            byte[] bytesProduto = null;

         
            if(pictureFotoProduto.Image != null)
            {
                bytesProduto = ImageUtilIts.GetBytesFromImage(pictureFotoProduto.Image);

                novo.FotoProduto = bytesProduto;
            }
            novo.IdProduto = this._produtoAnt.IdProduto;

            //atributo
            decimal comp = ParseUtil.ToDecimal(txtComprimento.Text);
            decimal largura = ParseUtil.ToDecimal(txtLargura.Text);
            decimal esp1 = ParseUtil.ToDecimal(txtEspessura1.Text);
            decimal esp2 = ParseUtil.ToDecimal(txtEspessura2.Text);

            novo.Atributos.Comprimento = comp;
            novo.Atributos.Largura = largura;
            novo.Atributos.Espessura1 = esp1;
            novo.Atributos.Espessura2 = esp2;
            novo.Atributos.Acabamento = txtAcabamento.Text;
            novo.Atributos.Acabamento = txtPeso.Text;


            return novo;
        }

        private void btnCancelar_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void btnSalvar_ItemClick(object sender, ItemClickEventArgs e)
        {
            var novo = indexarDados();

            if (novo.CodigoBarras.IsContainsNumber() || string.IsNullOrEmpty(novo.CodigoBarras))
            {
                using (var ctx = new BalcaoContext())
                {
                    var manager = new ProdutoDaoManager();
                    //sempre cheque o codigo de barras
                    var find = manager.GetProdutoByCodigoBarras(novo.CodigoBarras);

                    if (find != null && novo.IdProduto != this._produtoAnt.IdProduto)
                    {
                        XMessageIts.Advertencia("Código de barras " + novo.CodigoBarras + " já utilizado !");
                    }
                    var pFind = manager.GetProdutoByDescricao(novo.DescricaoProduto);
                    bool valido = false;

                    if (pFind != null)
                    {
                        //se to atualizando
                        if (_produtoAnt != null && novo.IdProduto == pFind.IdProduto)
                            valido = true;
                    }
                    else
                        valido = true;

                    if (valido)
                    {
                        var current = ctx.ProdutoDao.Find(_produtoAnt.IdProduto);

                        if (chEditar.Checked && !novo.DescricaoProduto.Equals(current.DescricaoProduto))
                        {
                            XMessageIts.Advertencia("Você está alterando o nome do produto.\n" +
                                "Todas as relações do produto serão afetas !",
                                "*** Atenção ***");
                        }
                        //atualize o produto
                        current.Update(novo);

                        var result = ctx.ProdutoDao.Update(current);

                        if (result)
                        {

                            this._produtoAnt.Update(current);
                            XMessageIts.Mensagem("Produto atualizado com sucesso!");
                        }
                    }
                    else
                    {
                        XMessageIts.Advertencia("Nome \"" + novo.DescricaoProduto + "\" já utilizado !",
                                      "Aviso");
                    }

                }
            }
            else
            {

                XMessageIts.Mensagem("Código de barras deve possui pelo menos um número e não pode conter espaços");
            }
        }

        private void txtPrecoVenda_Leave(object sender, EventArgs e)
        {
            //calcule a margem de lucro se o textbox for modificado
            if (txtPrecoVenda.IsModified)
            {
                var pVenda = ParseUtil.ToDecimal(txtPrecoVenda.Text);
                var vCompra = ParseUtil.ToDecimal(txtPrecoCompra.Text);
                var margemLucro = _produtoAnt.CalcularMargemLucro(pVenda, vCompra);
                _produtoAnt.MargemLucro = margemLucro;
                txtMargemLucro.Text = margemLucro.ToString("N2");
            }
        }

        private void txtPrecoCompra_Leave(object sender, EventArgs e)
        {
            //calcule a margem de lucro se o textbox for modificado
            if (txtPrecoCompra.IsModified)
            {
                var pVenda = ParseUtil.ToDecimal(txtPrecoVenda.Text);
                var vCompra = ParseUtil.ToDecimal(txtPrecoCompra.Text);
                var margemLucro = _produtoAnt.CalcularMargemLucro(pVenda, vCompra);
                _produtoAnt.MargemLucro = margemLucro;
                txtMargemLucro.Text = margemLucro.ToString("N2");
            }
        }


        private void txtMargemLucro_Leave(object sender, EventArgs e)
        {
            //calcule a margem de lucro se o textbox for modificado
            if (txtMargemLucro.IsModified)
            {
                var pMargem = ParseUtil.ToDecimal(txtMargemLucro.Text);
                var vCompra = ParseUtil.ToDecimal(txtPrecoCompra.Text);
                var vVenda = _produtoAnt.CalcularMargemSobPrecoCompra(vCompra, pMargem);
                _produtoAnt.MargemLucro = vVenda;
                txtPrecoVenda.Text = vVenda.ToString("N2");
            }
        }

        private void barBtnRecEstoque_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_produtoAnt != null)
            {
                //var r = new ProdutoDaoManager().RecalculaEstoqueProduto(produto);
                //if (r)
                //    XMessageIts.Mensagem("Estoque gerado com sucesso!");
            }
        }

        private void barBtnCarregarTransacoes_ItemClick(object sender, ItemClickEventArgs e)
        {
            var ctx = new BalcaoContext();
            if (_produtoAnt != null)
            {
                gridControlTransacoes.DataSource = ctx.TransacoesProdutoDao.Where(p => p.IdProduto == _produtoAnt.IdProduto).ToList().OrderByDescending(t => t.DataTransacao);
            }
        }

        private void btnQtdPrd_Click(object sender, EventArgs e)
        {
            var qtd = new ProdutoDaoManager().GetQuantidadeAtualProduto(_produtoAnt.IdProduto);
            btnQtdPrd.Text = qtd.ToString();
        }

        private void pictureFotoProduto_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var op = openFileFoto.ShowDialog();
                if (op == DialogResult.OK)
                {
                    byte[] b = ImageUtilIts.GetBytesFromStream(openFileFoto.OpenFile());
                    pictureFotoProduto.Image = ImageUtilIts.GetImageFromBytes(b);
                }
            }
        }

        private void groupControl5_DoubleClick(object sender, EventArgs e)
        {
            if (pictureFotoProduto.Image != null)
            {
                var img = ImageUtilIts.GetBytesFromImage(pictureFotoProduto.Image);
                var path = Path.Combine(Path.GetTempPath(), Path.GetTempFileName() + ".jpg");
                FileManagerIts.WriteBytesToFile(path, img);
                FileManagerIts.OpenFromSystem(path);
            }
        }

        private void XFrmDetalhesProduto_DEV_Shown(object sender, EventArgs e)
        {
            barBtnCarregarTransacoes_ItemClick(null, null);
        }
        private void XFrmDetalhesProduto_DEV_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Dispose();
        }

        private void XFrmDetalhesProduto_Shown(object sender, EventArgs e)
        {
            barBtnCarregarTransacoes_ItemClick(null, null);
        }

        private void chEditar_CheckedChanged(object sender, EventArgs e)
        {
            if (chEditar.Checked)
            {
                if (new UnitWork().UserManager.IsSuperUser(user.NomeUtilizador))
                {
                    this.txtDescricao.Properties.ReadOnly = false;
                }
                else
                {
                    XMessageIts.Erro("Você não tem permissão para editar o produto!", "Área restrita");
                    chEditar.Checked = false;
                }
            }
            else
            {
                this.txtDescricao.Properties.ReadOnly = true;
                this.txtDescricao.Focus();
            }
        }

        private void btnNcm_Click(object sender, EventArgs e)
        {
            using (var ctx = new BalcaoContext())
            {
                ctx.LazyLoading(false);

                var paramsFind = new ParamsFindEntity()
                {
                    Context = ctx,
                    Columns = new string[] { "CodigoNcm", "DescricaoNcm" },
                    Title = "Localizar NCM:",
                    DynamicObject = null
                };

                var selected = XFrmFindEntity.ShowDialogFindEntity<Ncms>(paramsFind);

                try
                {
                    if (selected != null)
                    {
                        var codNcm = selected.GetType().GetProperty("CodigoNcm").GetValue(selected, null);
                        this.btnNcm.Text = codNcm;
                    }
                }
                catch
                {
                    //da nada nao
                }
            }
        }
        private async void IndexardadosEstoque(Produto p)
        {
            try
            {
                if (p != null)
                {
                    using (var ctx = new BalcaoContext())
                    {
                        ctx.LazyLoading(true);
                        var pCurrent = await ctx.Produtos.Where(pr => pr.IdProduto == p.IdProduto)
                            .Include(prd => prd.TransacoesProduto)
                            .FirstOrDefaultAsync();

                        //obtem as movimentacoes dos produtos agrupados por local de estoque e saldo em cada local. Encapsular dps.
                        var q = pCurrent.TransacoesProduto.GroupBy(l => l.LocalEstoque.CodigoLocalEstoque)
                            .Select(s => new SaldoByLocalEstoque
                            {
                                CodigoLocal = s.First().LocalEstoque.CodigoLocalEstoque,
                                Quantidade = (s.Where(t => t.TipoTransacao == TypeTransacaoProduto.Entrada) != null ?
                                s.Where(t => t.TipoTransacao == TypeTransacaoProduto.Entrada).Sum(qt => qt.Quantidade) : 0M)
                                -
                                (s.Where(t => t.TipoTransacao == TypeTransacaoProduto.Saida) != null ?
                                s.Where(t => t.TipoTransacao == TypeTransacaoProduto.Saida).Sum(qt => qt.Quantidade) : 0M),
                                Valor = 0M
                            });

                        gridControlSaldoLoc.DataSource = q.ToList();

                        var entradas = pCurrent.TransacoesProduto.ToList().Where(t => t.TipoTransacao == TypeTransacaoProduto.Entrada);
                        var saidas = pCurrent.TransacoesProduto.ToList().Where(t => t.TipoTransacao == TypeTransacaoProduto.Saida);

                        var vlrMedioEntradas = 0M;
                        var qtdEntrada = 0M;

                        var vlrMedioSaidas = 0M;
                        var qtdSaida = 0M;

                        if (entradas.Count() > 0)
                        {
                            vlrMedioEntradas = entradas.Sum(v => v.ValorTotal);
                            qtdEntrada = entradas.Sum(e => e.Quantidade);
                            vlrMedioEntradas = vlrMedioEntradas / qtdEntrada;
                        }

                        if (saidas.Count() > 0)
                        {
                            vlrMedioSaidas = saidas.Sum(v => v.ValorTotal);
                            qtdSaida = saidas.Sum(e => e.Quantidade);
                            vlrMedioSaidas = vlrMedioSaidas / qtdSaida;
                        }

                        var saldoFisico = (qtdEntrada - qtdSaida);

                        gridControlEntradas.DataSource = entradas;
                        gridControlSaidas.DataSource = saidas;
                        txtCategoria.Text = pCurrent.CategoriaProduto.NomeCategoriaProduto;
                        rdTipoProduto.SelectedIndex = (int)p.TipoItemProduto;

                        txtPrecoMedioVendas.Text = vlrMedioSaidas.ToString("n2");
                        txtCustoMedio.Text = vlrMedioEntradas.ToString("n2");
                        txtSaldoEstoque.Text = saldoFisico.ToString("n3");
                        txtSaldoFisico2.Text = saldoFisico.ToString("n3");
                    }

                }
            }
            catch (Exception ex)
            {
                XMessageIts.ExceptionMessage(ex);
            }

        }
        internal class SaldoByLocalEstoque
        {
            public string CodigoLocal { get; set; }
            public decimal Valor { get; set; }
            public decimal Quantidade { get; set; }
        }
    }
}