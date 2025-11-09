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
            txtIdVenta.Text = idVenta.ToString(); 
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
                        MessageBox.Show("No se encontró la venta con el ID.");
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error de SQL: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

      
        
    }
}