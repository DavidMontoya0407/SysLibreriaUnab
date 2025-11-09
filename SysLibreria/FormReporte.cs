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
        List<DetalleVenta> listaDetalleVenta = new List<DetalleVenta>();
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
            DGV_REPORTE.Rows.Clear();
           


            using (BDLIBRERIAEntities DB = new BDLIBRERIAEntities())
            {
                
                listaDetalleVenta = DB.DetalleVenta
                                     .Include("Producto")
                                     .Where(dv => dv.IdVenta == idVenta)
                                     .ToList();

                foreach (var dt in listaDetalleVenta)
                {
                    DGV_REPORTE.Rows.Add(dt.Producto.Nombre, dt.Cantidad, dt.Producto.Precio.ToString("F2"),  dt.Descuento, dt.Total.ToString("F2"));
                }


            }

            

            CargarDatosVenta();

            

        }


        private void CargarDatosVenta()
        {
            using (BDLIBRERIAEntities DB = new BDLIBRERIAEntities())
            {
                var venta = DB.Venta
                    .Include("Cliente")
                    .Include("Usuario")
                    .FirstOrDefault(v => v.IdVenta == idVenta);

                if (venta != null)
                {
                    TXT_FECHA.Text = venta.Fecha.ToString();
                    TXT_CLIENTE.Text = venta.Cliente.Nombre;
                    TXT_VENDEDOR.Text = venta.Usuario.Nombres;
                    TXT_SUBTOTAL.Text = venta.SubTotal.ToString("F2");
                    TXT_IVA.Text = venta.Iva.ToString("F2");
                    TXT_TOTAL.Text = venta.Total.ToString("F2");
                }
                else
                {
                    MessageBox.Show("No se encontró la venta con el ID.");
                }
            }
        }

        private void TXT_SALIR_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}