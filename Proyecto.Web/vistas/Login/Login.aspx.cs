using System;
using System.Web;

namespace Proyecto.Web.vistas.Login
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //la primera ves que carga la pagina mostrar
            //postBack=es una accion

            if (!IsPostBack) {


             if (Request.Cookies["cookieEmail"] !=null)
               
                txtemail.Text = Request.Cookies["cookieEmail"].Value.ToString();
                 
             }   
            

            // if (!IsPostBack)
            //  ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> swal('Buen trabajo!', 'Se realizo proceso con exito!', 'success') </Script>");


        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {

                string stMensaje = string.Empty;
                if (string.IsNullOrEmpty(txtemail.Text)) stMensaje += "ingrese Email,";
                if (string.IsNullOrEmpty(txtPassword.Text)) stMensaje += "ingrese Password,";
                

                if (!string.IsNullOrEmpty(stMensaje)) throw new Exception(stMensaje.TrimEnd(','));

                //defino objeto con propiedades
                logica.Models.clsUsuarios obclsUsuarios = new logica.Models.clsUsuarios
                {
                    stLogin = txtemail.Text,
                    stPassword=txtPassword.Text

                };
                //instancio controlador
                Controllers.LoginController obloginController = new Controllers.LoginController();

                bool blBandera = obloginController.getvalidarUsuarioController(obclsUsuarios);

                if (blBandera) {

                    Session["sessionEmail"] = txtemail.Text;

                    if (CheckRecordar.Checked) { 

                        //crear objeto cookie
                        HttpCookie cookie = new HttpCookie("cookieEmail",txtemail.Text);

                        //adicciono time de vida
                        cookie.Expires = DateTime.Now.AddDays(2);

                        //adicciono ala coleccion de cookie
                        Response.Cookies.Add(cookie);

                    }
                    else
                    {
                        //crear objeto cookie
                        HttpCookie cookie = new HttpCookie("cookieEmail", txtemail.Text);

                        //cookie expira el dira de ayer
                       cookie.Expires = DateTime.Now.AddDays(-1);
                        Response.Cookies.Add(cookie);

                    }

             Response.Redirect("../Index/Index.aspx?stEmail="+txtemail.Text); //redirecciono y atrapo el coreo y lo pongo en la url
                }


                else throw new Exception("Usuario o clave incorrecta");

            }
            catch (Exception ex)
            {

                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> swal('error!','" + ex.Message + "!', 'error') </Script>");

            }

        }
    }
}