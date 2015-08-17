using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AplicacionWeb
{
    public partial class Error : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            // Ejemplo de como invocar una imagen directamente sin buscarla en el directorio.

            //InvocarImagenDirectamente();

        }

        #region Meter imagen directamente. Optimización al 100%.

        private void InvocarImagenDirectamente()
        {

            string urlImagen = "\\Aportes\\09-08-2014\\Wake me up when september ends.jpg";

            Image imgPendiente = CrearImagePendiente(urlImagen, "holaa :D");

            imagen.Controls.Add(imgPendiente);

        }

        private Image CrearImagePendiente(string urlImagen, string titulo)
        {

            Image imgPendiente = new Image();

            imgPendiente.ImageUrl = urlImagen;

            imgPendiente.AlternateText = titulo;

            imgPendiente.ToolTip = titulo;

            imgPendiente.Attributes.Add("style", "width: 540px; max-width: 540px;");

            return imgPendiente;

        }
        
        #endregion

    }
}