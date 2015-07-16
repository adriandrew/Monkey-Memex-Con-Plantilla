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

            }
            else
            {

                // Se redirecciona para que pueda enviar aportes.
                lnkEnviarAporteNoMiembros.PostBackUrl = "EnviarAporte";

                // Se cambia la imagen si el usuario esta loggueado, obviamente hasta que se recargue la pagina.
                imagenStatus.Src = "Images/estatusDentro.png";

            }          

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {

            //txtBusqueda.Text = "prueba";
            AplicacionWeb.Busqueda.TextoBusqueda = txtBusqueda.Text;

            this.Response.Redirect("Busqueda");

        }

    }
}