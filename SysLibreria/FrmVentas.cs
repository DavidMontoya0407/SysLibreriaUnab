using System;
using System.Collections.Generic;
using System.ComponentModel; 
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysLibreria
{
    public partial class FrmVentas : Form
    {
        public FrmVentas()
        {
            InitializeComponent();
            CargarClientes();
        }



        BDLIBRERIAEntities db = new BDLIBRERIAEntities();
        int IdVentaSeleccionada = 0;

       

        private void FrmVentas_Load(object sender, EventArgs e)
        {
            dtpFecha.Value = DateTime.Now; 
        }

        private void CargarClientes()
        {
            var clientes = db.Cliente
                             .Select(c => new
                             {
                                 c.IdCliente,
                                 c.Nombre
                             })
                             .ToList();

            CBCliente.DataSource = clientes;
            CBCliente.DisplayMember = "Nombre";
            CBCliente.ValueMember = "IdCliente";
            CBCliente.SelectedIndex = -1; 
        }

       
        private void LimpiarVentas()
        {
            txtNumVenta.Text = "";
            CBCliente.SelectedIndex = -1;
            dtpFecha.Value = DateTime.Now;
          
        }

     
        private void CargarVentas()
        {
              dgvVentas.DataSource = db.Venta
                          .Select(v => new
                          {
                              v.IdVenta,
                              v.Fecha,
                              Cliente = v.Cliente.Nombre,
                              v.SubTotal,
                              v.Iva,
                              v.Total
                          })
                          .ToList();

          
        }

       
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvVentas.CurrentRow != null)
            {
                IdVentaSeleccionada = Convert.ToInt32(dgvVentas.CurrentRow.Cells["IdVenta"].Value);
                dtpFecha.Value = Convert.ToDateTime(dgvVentas.CurrentRow.Cells["Fecha"].Value);
                CBCliente.Text = dgvVentas.CurrentRow.Cells["Cliente"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una venta para editar.");
            }
        }

  
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (IdVentaSeleccionada == 0)
            {
                MessageBox.Show("Seleccione una venta antes de eliminar.");
                return;
            }

            DialogResult confirmacion = MessageBox.Show(
                "¿Seguro quiere eliminar esta venta?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmacion == DialogResult.Yes)
            {
                try
                {
                    var ventaEliminar = db.Venta.FirstOrDefault(v => v.IdVenta == IdVentaSeleccionada);
                    if (ventaEliminar != null)
                    {
                        db.Venta.Remove(ventaEliminar);
                        db.SaveChanges();
                        MessageBox.Show("Venta eliminada correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se encontró la venta a eliminar.");
                    }

                    LimpiarVentas();
                    CargarVentas();
                    IdVentaSeleccionada = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar la venta: " + ex.Message);
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarVentas();
            CBCliente.Focus();
        }

       
       
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

       

      
        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                Venta nuevaVenta = new Venta
                {
                    Fecha = dtpFecha.Value,
                    IdCliente = Convert.ToInt32(CBCliente.SelectedValue),
                    
                };

               
                db.Venta.Add(nuevaVenta);
                db.SaveChanges();

                MessageBox.Show("Venta guardada correctamente");

                CargarVentas();
            }
            catch (Exception ex)
            {
                { string error = ex.InnerException?.InnerException?.Message
                       ?? ex.InnerException?.Message
                       ?? ex.Message;

                    MessageBox.Show("Error al guardar:\n" + error);
                }

            }
            }
        private void dgvVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtNumVenta_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
