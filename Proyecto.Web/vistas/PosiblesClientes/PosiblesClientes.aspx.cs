using System;
using System.Data;
using System.Web.UI.WebControls;

namespace Proyecto.Web.vistas.PosiblesClientes
{
    public partial class PosiblesClientes : System.Web.UI.Page
    {

        #region Metodos y funcones
        /// <summary>
        /// optiene consulta de posibles clientes
        /// </summary>
        void getPosiblesCliente()
        {
            try
            {
                Controllers.clsPosiblesClientesController obPosiblesClientesController = new Controllers.clsPosiblesClientesController();
                DataSet dsConsulta = obPosiblesClientesController.getConsultarPosiblesClientesController();

                if (dsConsulta.Tables[0].Rows.Count > 0) gvwDatos.DataSource = dsConsulta;

                else gvwDatos.DataSource = null;


                gvwDatos.DataBind();//para tumar los cambios

            }
            catch (Exception ex)  { ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> swal('error!','" + ex.Message + "!', 'error') </Script>"); }
                       
        }
        #endregion

        #region Eventos
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            
                getPosiblesCliente();

            }
           

        protected void btn_Guardar(object sender, EventArgs e)
        {
            try
            {
                string stMensaje = string.Empty;
                if (string.IsNullOrEmpty(txtidentificacion.Text)) stMensaje += "ingrese Identificacion,";


                if (!string.IsNullOrEmpty(stMensaje)) throw new Exception(stMensaje.TrimEnd(','));

                logica.Models.clsPosiblesClientes obclsPosiblesClientes = new logica.Models.clsPosiblesClientes {

                    inIdentificacion = Convert.ToInt64(txtidentificacion.Text),
                    stEmpresa = txtEmpresa.Text,
                    stprimerNombre = txtPrimerNombre.Text,
                    stSegundoNombre = txtSegundoNombre.Text,
                    stprimerApellido = txtPrimerApellido.Text,
                    stSegundoApellido = txtSegundoApellido.Text,
                    stDireccion = txtDireccion.Text,
                    stTelefono = txtTelefono.Text,
                    stCorreo = txtCorreo.Text

                };

                Controllers.clsPosiblesClientesController obclsPosiblesClientesController = new Controllers.clsPosiblesClientesController();



                if (string.IsNullOrEmpty(LblOpcion.Text)) LblOpcion.Text = "1";

                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> alert('" + obclsPosiblesClientesController.setAdministrarPosiblesClientesController(obclsPosiblesClientes, Convert.ToInt32(LblOpcion.Text)) + "') </Script>");

                LblOpcion.Text = txtidentificacion.Text = txtEmpresa.Text = txtPrimerNombre.Text = txtSegundoNombre.Text = txtPrimerApellido.Text = txtSegundoApellido.Text = txtDireccion.Text = txtTelefono.Text = txtCorreo.Text = string.Empty;

                getPosiblesCliente();
            }
            catch (Exception ex)
            {ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> alert('" + ex.Message + "') </Script>"); }
          
                    
            }


        


        protected void gvwDatos_RowCommand(object sender, System.Web.UI.WebControls.GridViewCommandEventArgs e)
        {
            try
            {
                int inIndice = Convert.ToInt32(e.CommandArgument);

                if (e.CommandName.Equals("Editar"))
                {

                    LblOpcion.Text = "2";
                    //accede a un contro web dentro de un grid

                    txtidentificacion.Text = ((Label)gvwDatos.Rows[inIndice].FindControl("lblIdentificacion")).Text;

                    txtEmpresa.Text = gvwDatos.Rows[inIndice].Cells[1].Text.Equals("&nbsp;") ? string.Empty : gvwDatos.Rows[inIndice].Cells[1].Text;
                    txtPrimerNombre.Text = gvwDatos.Rows[inIndice].Cells[2].Text.Equals("&nbsp;") ? string.Empty : gvwDatos.Rows[inIndice].Cells[2].Text;
                    txtSegundoNombre.Text = gvwDatos.Rows[inIndice].Cells[3].Text.Equals("&nbsp;") ? string.Empty : gvwDatos.Rows[inIndice].Cells[3].Text;
                    txtPrimerApellido.Text = gvwDatos.Rows[inIndice].Cells[4].Text.Equals("&nbsp;") ? string.Empty : gvwDatos.Rows[inIndice].Cells[4].Text;
                    txtSegundoApellido.Text=gvwDatos.Rows[inIndice].Cells[5].Text.Equals("&nbsp;") ? string.Empty : gvwDatos.Rows[inIndice].Cells[5].Text;
                    txtDireccion.Text = gvwDatos.Rows[inIndice].Cells[6].Text.Equals("&nbsp;") ? string.Empty : gvwDatos.Rows[inIndice].Cells[6].Text;
                    txtTelefono.Text = gvwDatos.Rows[inIndice].Cells[7].Text.Equals("&nbsp;") ? string.Empty : gvwDatos.Rows[inIndice].Cells[7].Text;
                    txtCorreo.Text = gvwDatos.Rows[inIndice].Cells[8].Text.Equals("&nbsp;") ? string.Empty : gvwDatos.Rows[inIndice].Cells[8].Text;

                }
                else if (e.CommandName.Equals("Eliminar"))
                {
                    LblOpcion.Text = "3";

                    
                      

                        logica.Models.clsPosiblesClientes obclsPosiblesClientes = new logica.Models.clsPosiblesClientes
                        {

                    inIdentificacion =Convert.ToInt64 (((Label)gvwDatos.Rows[inIndice].FindControl("lblIdentificacion")).Text),
                            
                            stEmpresa = string.Empty,
                            stprimerNombre = string.Empty,
                            stSegundoNombre = string.Empty,
                            stprimerApellido = string.Empty,
                            stSegundoApellido = string.Empty,
                            stDireccion = string.Empty,
                            stTelefono = string.Empty,
                            stCorreo = string.Empty,

                        };

                        Controllers.clsPosiblesClientesController obclsPosiblesClientesController = new Controllers.clsPosiblesClientesController();

                        
                        ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> alert('" + obclsPosiblesClientesController.setAdministrarPosiblesClientesController(obclsPosiblesClientes, Convert.ToInt32(LblOpcion.Text)) + "') </Script>");
                        LblOpcion.Text = string.Empty;

                        getPosiblesCliente();

                    }


                }
            
            catch (Exception ex) { ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> alert('" + ex.Message + "') </Script>"); }


           }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {

 LblOpcion.Text = txtidentificacion.Text = txtEmpresa.Text = txtPrimerNombre.Text = txtSegundoNombre.Text = txtPrimerApellido.Text = txtSegundoApellido.Text = txtDireccion.Text = txtTelefono.Text = txtCorreo.Text = string.Empty;


        }
        #endregion
    }
}
    
