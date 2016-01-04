using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace AplicacionWeb
{
    public partial class Login : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

            //if (Membership.GetUser() != null)
            //{

                   // Esta funcion se invoca desde cualquier evento onclick del lado del cliente.
                   //window.parent.jQuery.fancybox.close();

                    // Esta funcion se invoca desde el lado del servidor, se tiene que registrar el script.
                   //ScriptManager.RegisterStartupScript(this, GetType(), "", "parent.jQuery.fancybox.close();", true);

            //}


            if (!IsPostBack)
            {

                try
                {
                    
                    if (User.IsInRole("Administradores"))
                    {

                        LinkButton linkModerarr = (LinkButton) LoginView.FindControl("linkModerar");

                        linkModerarr.Visible = true;

                    }
                    else if (!User.IsInRole("Administradores"))
                    {
                        
                        LinkButton linkModerarr = (LinkButton) LoginView.FindControl("linkModerar");

                        linkModerarr.Visible = false;
                        
                    }

                }
                catch
                {
                        
                    // No se puso nada en este caso. Es una excepcion poco común.

                }
            
            }

        }
        
    }
}