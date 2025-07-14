using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABMElectrodomésticos
{
    public class ConexionSql
    {
        static string connectionstring;
        public static SqlConnection ConexionSQL;
        static string datasource = "Matias\\MSSQLSERVER01"; //nombre del servidor 
        static string basededatos = "Electrodomesticos"; //nombre de la base de datos
        static SqlCommand Orden;
        static SqlDataReader Lector;

        public static void ConectarBD()
        {

            connectionstring = @"Data Source=" + datasource + ";Initial Catalog=" + basededatos + ";Trusted_Connection=True;";
            ConexionSQL = new SqlConnection(connectionstring);
            try
            {
                ConexionSQL.Open();
            }
            catch
            {
                MessageBox.Show("Error al intentar abrir base de datos", "AVISO IMPORTANTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void CierraBD()
        {
            ConexionSQL.Close();
        }

        public static SqlDataReader LecturaBD(string consulta)
        {
            Orden = new SqlCommand(consulta, ConexionSQL);
            Lector = Orden.ExecuteReader();
            return Lector;
        }

        public static void EjecutaQuery(string dame_query)
        {
            using (ConexionSQL)
            {
                try
                {
                    SqlCommand ejecuta = new SqlCommand(dame_query, ConexionSQL);
                    ejecuta.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        public static DataTable LecturaBD_DataTable(string consulta)
        {
            DataTable tabla = new DataTable();

            try
            {
                ConectarBD();

                using (SqlCommand cmd = new SqlCommand(consulta, ConexionSQL))
                using (SqlDataAdapter adaptador = new SqlDataAdapter(cmd))
                {
                    adaptador.Fill(tabla);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al leer la base de datos:\n" + ex.Message,
                                "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return tabla;
        }
    }
}
