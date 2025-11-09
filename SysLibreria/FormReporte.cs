using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Configuration;
using System.Data.Entity.Core.EntityClient;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysLibreria
{
    public partial class FormReporte : Form
    {
        private int idVenta;

        public FormReporte()
        {
            InitializeComponent();


        }
        public FormReporte(int idVenta)
        {
            InitializeComponent();
            this.idVenta = idVenta;

        }


        private void DGV_REPORTE_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void Venta_Enter(object sender, EventArgs e)
        {

        }

        private void FormReporte_Load(object sender, EventArgs e)
        {
            CargarDatosVenta();
        }
        private void CargarDatosVenta()
        {
            try
            {
                
                string efConnectionString = ConfigurationManager.ConnectionStrings["BDLIBRERIAEntities"].ConnectionString;
                var entityBuilder = new EntityConnectionStringBuilder(efConnectionString);
                string sqlConnectionString = entityBuilder.ProviderConnectionString;

               
                string query = @"
            SELECT v.Fecha, c.Nombre AS Cliente, u.Nombres AS Vendedor
            FROM dbo.Venta v
            JOIN dbo.Cliente c ON v.IdCliente = c.IdCliente
            JOIN dbo.Usuario u ON v.IdUsuario = u.IdUsuario
            WHERE v.IdVenta = @idVenta";

                using (SqlConnection con = new SqlConnection(sqlConnectionString))
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@idVenta", idVenta);
                    con.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        TXT_FECHA.Text = reader["Fecha"].ToString();
                        TXT_CLIENTE.Text = reader["Cliente"].ToString();
                        TXT_VENDEDOR.Text = reader["Vendedor"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("No se encontró la venta con el ID especificado.");
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error de SQL: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void DGV_REPORTE_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string cadenaConexion = "tu_cadena_de_conexion";
            string query = "SELECT p.Nombre AS Producto, dv.Cantidad, dv.PrecioUnitario, dv.Descuento, dv.Total " +
                           "FROM DetalleVenta dv " +
                           "JOIN Productos p ON dv.IdProducto = p.IdProducto " +
                           "WHERE dv.IdVenta = @idVenta";

            using (SqlConnection con = new SqlConnection(cadenaConexion))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@idVenta", idVenta); 
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DGV_REPORTE.DataSource = dt;
            }
        }
    }
}