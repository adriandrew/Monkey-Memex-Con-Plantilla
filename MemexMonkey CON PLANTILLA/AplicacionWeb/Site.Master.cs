using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AplicacionWeb
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Membership.GetUser() == null)
            {

                // Se redirecciona .
                lnkEnviarAporteNoMiembros.PostBackUrl = "../Registrarse";

                // Se cambia la imagen si el usuario no esta loggueado.
                imagenStatus.Src = "Images/estatusFuera.png";

            }
            else
            {

                lnkEnviarAporteNoMiembros.PostBackUrl = "../EnviarAporte";

                // Se cambia la imagen si el usuario esta loggueado.
                imagenStatus.Src = "Images/estatusDentro.png";

            }          

        }

    }
}