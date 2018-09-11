using System;

using System.Data;
using System.Data.SqlClient;

namespace Proyecto.logica.BL
{
    public class clsUsuarios
    {
        SqlConnection _SqlConnection = null;//me permite conectar con base de datos
        SqlCommand _sqlCommand = null;// me permite ejecutar comandos sql
        SqlDataAdapter _SqlDataAdapter = null;// permite adabtar conjuntos de datos en sql
        string stConexion = string.Empty;

        public clsUsuarios()
        {
            clsConexion obclsConexion = new clsConexion();
            stConexion = obclsConexion.getConexion();
        }
        public bool getvalidarUsuario(Models.clsUsuarios obclsUsuarios)
        {

            try
            {
                DataSet dsConsulta = new DataSet();

                _SqlConnection = new SqlConnection(stConexion);
                _SqlConnection.Open();

                _sqlCommand = new SqlCommand("spconsultarUsuarios", _SqlConnection);
                _sqlCommand.CommandType = CommandType.StoredProcedure;

                _sqlCommand.Parameters.Add(new SqlParameter("@clogin", obclsUsuarios.stLogin));
                _sqlCommand.Parameters.Add(new SqlParameter("@cpassword", obclsUsuarios.stPassword));

                _sqlCommand.ExecuteNonQuery();
                _SqlDataAdapter = new SqlDataAdapter(_sqlCommand);
                _SqlDataAdapter.Fill(dsConsulta);

                if (dsConsulta.Tables[0].Rows.Count > 0) return true;
                else return false;
            }
            catch (Exception ex) { throw ex; }
            finally { _SqlConnection.Close(); }
        }
    }
}
