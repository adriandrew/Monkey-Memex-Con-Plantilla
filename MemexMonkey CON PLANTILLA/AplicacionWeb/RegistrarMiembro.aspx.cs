using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AplicacionWeb.Miembros
{
    public partial class RegistrarMiembro : System.Web.UI.Page
    {

        #region Eventos

        protected void Page_Load(object sender, EventArgs e)
        {

            //System.Threading.Thread.Sleep(10000);

            //if (Membership.GetUser() != null)
            //{

            //     // Esta funcion se invoca desde el lado del servidor, se tiene que registrar el script.
            //    ScriptManager.RegisterStartupScript(this, GetType(), "", "parent.jQuery.fancybox.close();", true);

            //}

        }

        protected void CreateUserWizard_CreatedUser(object sender, EventArgs e)
        {

            Roles.AddUserToRole(CreateUserWizard.UserName, "Miembros");

        }

        #endregion

        #region Metodos Privados
        
        #endregion

    }
}