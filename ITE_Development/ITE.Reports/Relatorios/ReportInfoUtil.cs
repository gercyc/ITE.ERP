using DevExpress.XtraReports.UI;
using ITE.Entidades.POCO;
using ITSolution.Framework.Entities;
using ITSolution.Framework.Util;

namespace ITE.Reports.Relatorios
{
    public class ReportInfoUtil
    {

        public static void FillFieldsMatriz(EmpresaMatriz mat, XRLabel xrLblMatriz,
         XRLabel xrLblEndereco, XRLabel xrLblTelEmpresa, XRPictureBox xrPictureLogo)
        {

            xrLblMatriz.Text = mat.RazaoSocial;

            var e = new Endereco(mat.NomeEndereco, mat.NumeroEndereco, mat.Bairro, mat.Complemento,
                                 mat.Cep, mat.Uf, mat.Cidade, mat.TipoEndereco);

            //endereco completo
            xrLblEndereco.Text = e.ToString();

            //se nao tem telefone fixo
            if (string.IsNullOrEmpty(mat.Telefone))
                xrLblTelEmpresa.Text = mat.Fax;//tente o outro
            else
                //use o telefone
                xrLblTelEmpresa.Text = mat.Telefone;

            //se tem um logo use-o
            if (mat.Logo != null)
            {
                xrLblMatriz.Visible = false;
                xrPictureLogo.Image = ImageUtilIts.GetImageFromBytes(mat.Logo);
            }
            else
            {       //se nao use os dados em string ja setados acima
                //esconda o panel da logo
                xrPictureLogo.Visible = false;
                //mostreo o label da matriz
                xrLblMatriz.Visible = true;
            }



            /*if (matriz.Telefone.Length <= 10)
                xrLabelTelEmpresa.Text = String.Format("{0:(##) ####-####}", tel); 
            else
               xrLabelTelEmpresa.Text = String.Format("{0:(##) #####-####}", tel); ;*/

        }


        public static void FillFieldsTelefoneCliente(CliFor cliente, XRLabel xrLblTelefoneCliente)
        {
            if (!string.IsNullOrEmpty(cliente.Telefone))
                xrLblTelefoneCliente.Text = cliente.Telefone;

            else if (!string.IsNullOrEmpty(cliente.Celular))
                xrLblTelefoneCliente.Text = cliente.Celular;

            else 
                xrLblTelefoneCliente.Text = cliente.TelefoneComercial;
        }
    }
}
