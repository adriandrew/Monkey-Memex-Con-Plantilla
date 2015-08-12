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

        #region Eventos

        protected void Page_Load(object sender, EventArgs e)
        {

            CargarUsuarios();

        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {

            string nombre = ddlUsuarios.Text;

            EliminarUsuario(nombre);

        }
        
        protected void CreateUserWizard_CreatedUser(object sender, EventArgs e)
        {

            string nombre = CreateUserWizard.UserName;

            AgregarUsuarioAdministrador(nombre);

        }

        #endregion

        #region Metodos Privados

        private void CargarUsuarioss()
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

        private void EliminarUsuario(string nombre)
        {

            Membership.DeleteUser(nombre, true);
            
        }

        private void AgregarUsuarioAdministrador(string nombre)
        {

            Roles.AddUserToRole(nombre, "Administradores");

        }

        private void CargarUsuarios()
        {

            gvUsuarios.DataSource = Membership.GetAllUsers();

            gvUsuarios.DataBind();

        }

        #endregion

        protected void gvUsuarios_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

            //gvUsuarios.Rows(gvUsuarios.SelectedIndex).Columns("UserName");

        }
        
    }
}