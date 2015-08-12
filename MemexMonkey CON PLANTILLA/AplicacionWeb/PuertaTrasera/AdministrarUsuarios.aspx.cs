using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Web.Security;

namespace AplicacionWeb.PuertaTrasera
{
    public partial class AdministrarUsuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            CargarUsuarios();

        }

        #region Metodos Privados

        private void CargarUsuarios()
        {

            var usuarios = Membership.GetAllUsers();

            List<MembershipUser> lista = new List<MembershipUser>();
                        
            foreach (MembershipUser usuario in usuarios)
            {
                
                lista.Add(usuario);

            }

            ddlUsuarios.DataSource = lista;

            ddlUsuarios.DataBind();

        }

        #endregion

    }
}