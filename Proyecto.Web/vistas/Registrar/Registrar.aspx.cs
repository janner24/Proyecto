using System;


namespace Proyecto.Web.vistas.Registrar
{
    public partial class Registrar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!IsPostBack)
               // ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> swal('Buen trabajo!', 'Se realizo proceso con exito!', 'success') </Script>");

        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {

                string stMensaje = string.Empty;
                if (string.IsNullOrEmpty(txtNombre.Text)) stMensaje += "ingrese Nombre,";
                if (string.IsNullOrEmpty(txtApellido.Text)) stMensaje += "ingrese Apellido,";
                if (string.IsNullOrEmpty(Txteamil.Text)) stMensaje += "ingrese Email,";
                if (string.IsNullOrEmpty(TxtPassword.Text)) stMensaje += "ingrese Password,";
                if (string.IsNullOrEmpty(Txtconpassword.Text)) stMensaje += "confirmar password,";

                if (!string.IsNullOrEmpty(stMensaje)) throw new Exception(stMensaje.TrimEnd(','));
            }
            catch (Exception ex)
            {

                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> swal('error!','" + ex.Message + "!', 'error') </Script>");

            }

        }
    }
}