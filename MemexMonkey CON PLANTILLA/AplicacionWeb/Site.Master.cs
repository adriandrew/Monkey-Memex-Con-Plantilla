using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

namespace AplicacionWeb
{
    public partial class Site : System.Web.UI.MasterPage
    {

        protected void Page_Load(object sender, EventArgs e)
        {

            if (Membership.GetUser() == null)
            {

                // Se redirecciona si es que no está loggueado.
                lnkEnviarAporteNoMiembros.PostBackUrl = "Registrarse";

                // Se cambia la imagen si el usuario no esta loggueado.
                imagenStatus.Src = "Images/estatusFuera.png";
                
                imagenStatus.Alt = "Usuario Anonimo";

                imagenStatus.Attributes.Add("title", "Usuario Anonimo");

                nombreUsuarioTexto.InnerText = "Hola Usuario Anonimo";

            }
            else
            {

                // Se redirecciona para que pueda enviar aportes.
                lnkEnviarAporteNoMiembros.PostBackUrl = "EnviarAporte";

                // Se cambia la imagen si el usuario esta loggueado, obviamente hasta que se recargue la pagina.
                imagenStatus.Src = "Images/estatusDentro.png";

                string nombreUsuarioActual = HttpContext.Current.User.Identity.Name;

                imagenStatus.Alt = nombreUsuarioActual;

                imagenStatus.Attributes.Add("title",  nombreUsuarioActual);

                nombreUsuarioTexto.InnerText = "Hola " + nombreUsuarioActual;

            }

            CargarImagenMejorPublicacionAyer();

        }

        protected void btnBusqueda_Click(object sender, EventArgs e)
        {

            AplicacionWeb.Busqueda.TextoBusqueda = txtBusqueda.Text;

            this.Response.Redirect("Busqueda");

        }

        #region Metodos Privados

        private void CargarImagenMejorPublicacionAyer()
        {

            var htmlImagenes = new StringBuilder();

            string inyectarImagenes = string.Empty;

            Entidades.ImagenesAspNet_Users imagenes = new Entidades.ImagenesAspNet_Users();

            List<Entidades.ImagenesAspNet_Users> listaImagenes = new List<Entidades.ImagenesAspNet_Users>();

            listaImagenes = imagenes.ObtenerMejorPublicacionAyer(DateTime.Today.AddDays(-1));

            foreach (Entidades.ImagenesAspNet_Users elementoImagenes in listaImagenes)
            {

                if (!string.IsNullOrEmpty(elementoImagenes.DirectorioRelativo) && !string.IsNullOrEmpty(elementoImagenes.RutaRelativa))
                {

                    inyectarImagenes += MostrarImagenDirectamente(htmlImagenes, elementoImagenes);

                    break;

                }
                else if (!string.IsNullOrEmpty(elementoImagenes.EnlaceExterno))
                {

                    //VerificarEnlaceImagen(elementoImagenes);

                }

            }

            navMasVotado.InnerHtml = inyectarImagenes;

        }

        private string MostrarImagenDirectamente(StringBuilder htmlImagenes, Entidades.ImagenesAspNet_Users elementoImagenes)
        {

            string idImagen = elementoImagenes.IdImagen.ToString();

            string titulo = elementoImagenes.Titulo.ToString();

            string rutaRelativa = elementoImagenes.RutaRelativa.ToString();

            string inyectarImagen = string.Empty;

            string urlImagen = string.Format("{0}", rutaRelativa);

            string archivoImagen = string.Format("<img src='{0}' alt='{1}'>", urlImagen, titulo);

            string linkImagen = string.Format("<a class={0} href={1}{2} onmouseover={3}>{4}</a>", "iframe", "Individual/", idImagen, "InvocarFancybox('75%','100%','false','0.8')", archivoImagen);

            string contenidoDivImagen = string.Format("{0}", linkImagen);

            inyectarImagen = string.Format("<div>{0}</div>", contenidoDivImagen);
            
            return inyectarImagen;

        }

        #endregion

    }
}