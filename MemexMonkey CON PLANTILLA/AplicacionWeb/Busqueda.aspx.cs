using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

namespace AplicacionWeb
{

    public partial class Busqueda : System.Web.UI.Page
    {

        #region Campos Estaticos

        private static string textoBusqueda = string.Empty;

        #endregion

        #region Propiedades Estaticas

        public static string TextoBusqueda
        {
            get { return Busqueda.textoBusqueda; }
            set { Busqueda.textoBusqueda = value; }
        }
               
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {

            AdministrarImagenes(TextoBusqueda);

        }
        
        private void AdministrarImagenes(string textoBusqueda)
        {

            var htmlImagenes = new StringBuilder();

            Entidades.ImagenesAspNet_Users imagenes = new Entidades.ImagenesAspNet_Users();

            List<Entidades.ImagenesAspNet_Users> listaImagenes = new List<Entidades.ImagenesAspNet_Users>();

            listaImagenes = imagenes.ObtenerBusqueda(textoBusqueda);

            foreach (Entidades.ImagenesAspNet_Users elementoImagenes in listaImagenes)
            {

                if (!string.IsNullOrEmpty(elementoImagenes.DirectorioRelativo) && !string.IsNullOrEmpty(elementoImagenes.RutaRelativa))
                {

                    VerificarArchivoImagen(htmlImagenes, elementoImagenes);

                }
                else if (!string.IsNullOrEmpty(elementoImagenes.EnlaceExterno))
                {

                    //VerificarEnlaceImagen(elementoImagenes);

                }

            }

        }

        private void VerificarArchivoImagen(StringBuilder htmlImagenes, Entidades.ImagenesAspNet_Users elementoImagenes)
        {

            string idImagen = elementoImagenes.IdImagen.ToString();

            string idCategoria = elementoImagenes.IdCategoria.ToString();

            string userId = elementoImagenes.UserId.ToString();

            string esAprobado = elementoImagenes.EsAprobado.ToString();

            string titulo = elementoImagenes.Titulo.ToString();

            string directorioRelativo = elementoImagenes.DirectorioRelativo.ToString();

            string rutaRelativa = elementoImagenes.RutaRelativa.ToString();

            string enlaceExterno = elementoImagenes.EnlaceExterno.ToString();

            string etiquetasBasicas = elementoImagenes.EtiquetasBasicas.ToString();

            string etiquetasOpcionales = elementoImagenes.EtiquetasOpcionales.ToString();

            string fechaSubida = elementoImagenes.FechaSubida.ToString();

            string fechaPublicacion = elementoImagenes.FechaPublicacion.ToString();

            string applicationId = elementoImagenes.ApplicationId.ToString();

            string userName = elementoImagenes.UserName;

            string loweredUserName = elementoImagenes.LoweredUserName;

            string mobileAlias = elementoImagenes.MobileAlias;

            string isAnonymous = elementoImagenes.IsAnonymous.ToString();

            string lastActivityDate = elementoImagenes.LastActivityDate.ToString();

            System.IO.DirectoryInfo directorio = new System.IO.DirectoryInfo(HttpContext.Current.Server.MapPath(directorioRelativo));

            if (directorio.Exists)
            {

                System.IO.FileInfo[] archivos = directorio.GetFiles();

                bool esArchivoEncontrado = false;

                foreach (System.IO.FileInfo archivo in archivos)
                {

                    string urlImagen = string.Format("{0}\\{1}", directorioRelativo, archivo);

                    if (rutaRelativa.Equals(urlImagen))
                    {

                        string tituloImagen = string.Format("<h2>{0}</h2>", titulo);

                        string nombreUsuario = string.Format("<h3>{0}{1}</h3>", "Aporte por: ", userName);

                        string fechaPublicacionImagen = string.Format("<h4>{0}</h4>", fechaPublicacion);

                        string archivoImagen = string.Format("<img src='{0}' alt='{1}'>", urlImagen, titulo);

                        string linkImagen = string.Format("<a class={0} href={1}{2} onmouseover={3}>{4}</a>", "iframe", "Individual/", idImagen, "InvocarFancybox()", archivoImagen);

                        string etiquetas = string.Format("<h4>{0} | {1}</h4>", etiquetasBasicas, etiquetasOpcionales);

                        string contenidoDivImagen = string.Format("{0}{1}{2}{3}{4}", tituloImagen, nombreUsuario, fechaPublicacionImagen, linkImagen, etiquetas);

                        string imagen = string.Format("<div class={0}>{1}</div>", "imagen", contenidoDivImagen);

                        // TODO. Pendiente optimizar y checar que se inyecten todas las imagenes buscadas, no nadamas una.
                        // Falta un return al metodo principal y despues hacer el innerhtml.
                        //htmlImagenes.AppendFormat(imagen);

                        imagenesBusqueda.InnerHtml = imagen;

                        esArchivoEncontrado = true;

                        break;

                    }

                }

                if (!esArchivoEncontrado)
                {

                    string imagenNoEncontrada = string.Format("<h2>{0}</br>{1}</h2>", "No se encontro la imagen:", rutaRelativa);

                    string imagen = string.Format("<div class={0}>{1}</div>", "imagen", imagenNoEncontrada);

                    htmlImagenes.AppendFormat(imagen);

                }

            }
            else if (!directorio.Exists)
            {

                htmlImagenes.Clear();

                htmlImagenes.AppendFormat(string.Format("<h2>{0}</h2>", "El directorio no existe."));

            }

          

        }

    }

}