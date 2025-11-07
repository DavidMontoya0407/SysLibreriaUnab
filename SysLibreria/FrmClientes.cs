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
    public partial class FrmClientes : Form
    {
        BDLIBRERIAEntities db = new BDLIBRERIAEntities();
        int IdClienteSeleccionado = 0;

        public FrmClientes()
        {
            InitializeComponent();
            CargarClientes();


        }
        private void CargarClientes()
        {
            var lista = db.Cliente.Select(c => new
            {
                c.IdCliente,
                c.Nombre,
                c.Documento,
                c.Direccion
            }).ToList();

            dgvClientes.DataSource = lista;
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {

        }

        


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                using (BDLIBRERIAEntities db = new BDLIBRERIAEntities())
                {

                    int documento;
                    if (!int.TryParse(txtDocumento.Text, out documento))
                    {
                        MessageBox.Show("Ingrese un número válido en el campo Documento.");
                        return;
                    }


                    if (IdClienteSeleccionado == 0)
                    {

                        Cliente nuevo = new Cliente
                        {
                            Nombre = txtNombre.Text,
                            Documento = documento,
                            Direccion = txtDireccion.Text
                        };
                        db.Cliente.Add(nuevo);
                        db.SaveChanges();
                        MessageBox.Show("Cliente guardado correctamente.");
                    }
                    else
                    {

                        var clienteExistente = db.Cliente.FirstOrDefault(c => c.IdCliente == IdClienteSeleccionado);
                        if (clienteExistente != null)
                        {
                            clienteExistente.Nombre = txtNombre.Text;
                            clienteExistente.Documento = documento;
                            clienteExistente.Direccion = txtDireccion.Text;
                            db.SaveChanges();
                            MessageBox.Show("Cliente actualizado correctamente.");
                        }

                    }


                    LimpiarClientes();
                    CargarClientes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el cliente: " + ex.Message);
            }
        }

        private void LimpiarClientes()

        {
            txtID.Text = "";
            txtNombre.Text = "";
            txtDocumento.Text = "";
            txtDireccion.Text = "";
        }



        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow != null)
            {
                IdClienteSeleccionado = Convert.ToInt32(dgvClientes.CurrentRow.Cells["IdCliente"].Value);
                txtNombre.Text = dgvClientes.CurrentRow.Cells["Nombre"].Value.ToString();
                txtDocumento.Text = dgvClientes.CurrentRow.Cells["Documento"].Value.ToString();
                txtDireccion.Text = dgvClientes.CurrentRow.Cells["Direccion"].Value.ToString();

            }
            else
            {
                MessageBox.Show("Selecciona un cliente para editar.");
            }
            LimpiarClientes();
            CargarClientes();
        }






        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (IdClienteSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un cliente antes de eliminar.");
                return;
            }

            DialogResult confirmacion = MessageBox.Show(
                "¿Seguro quiere elimar este cliente?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmacion == DialogResult.Yes)
            {
                try
                {
                    using (BDLIBRERIAEntities db = new BDLIBRERIAEntities())
                    {
                        var clienteEliminar = db.Cliente.FirstOrDefault(c => c.IdCliente == IdClienteSeleccionado);
                        if (clienteEliminar != null)
                        {
                            db.Cliente.Remove(clienteEliminar);
                            db.SaveChanges();
                            MessageBox.Show("Cliente eliminado correctamente.");
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el cliente a eliminar.");
                        }
                    }

                    LimpiarClientes();
                    CargarClientes();
                    IdClienteSeleccionado = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message);
                }
            }
        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

       
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            using (var db = new BDLIBRERIAEntities())
            {
                if (!db.Cliente.Any())
                {
                    db.Database.ExecuteSqlCommand("DBCC CHECKIDENT ('Cliente', RESEED, 0)");
                }
            }

            LimpiarClientes();
            IdClienteSeleccionado = 0;
            txtNombre.Focus();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvClientes_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow fila = dgvClientes.Rows[e.RowIndex];


                IdClienteSeleccionado = Convert.ToInt32(fila.Cells["IdCliente"].Value);
                txtID.Text = fila.Cells["IdCliente"].Value.ToString();
                txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
                txtDocumento.Text = fila.Cells["Documento"].Value.ToString();
                txtDireccion.Text = fila.Cells["Direccion"].Value.ToString();
            }

        }

        private void FrmClientes_Load_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
