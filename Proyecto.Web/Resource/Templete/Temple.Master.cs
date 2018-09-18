using System;

namespace Proyecto.Web.Resource.Templete
{
    public partial class Temple : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {

                string[] stEmail = null;
                if (Session["sessionEmail"] != null)

                {
                    stEmail = Session["sessionEmail"].ToString().Split('@');
                    lbUsuarios.Text = stEmail[0];

                } else  Response.Redirect("../../vistas/Login/Login.aspx");


            }
        }

      
        protected void lblSalir_Click(object sender, EventArgs e)
        {
            //Session.Remove("sessionEmail");//elimina una variable de session  SOLO ELIMINA UNA
            Session.RemoveAll();//elimina todas las variables de session
            Response.Redirect("../../vistas/Login/Login.aspx");
        }
    }
}