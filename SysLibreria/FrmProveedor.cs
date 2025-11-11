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
    public partial class FrmProveedor : Form
    {

        List<Proveedor> listaProveedores = new List<Proveedor>();
        public FrmProveedor()
        {
            InitializeComponent();
        }

        private void LBL_NOMBRE_Click(object sender, EventArgs e)
        {

        }

        private void FrmProveedor_Load(object sender, EventArgs e)
        {
            DGV_PROVEEDOR.Rows.Clear();
            using (BDLIBRERIAEntities DB = new BDLIBRERIAEntities())
            {
                listaProveedores = (from prv in DB.Proveedor

                                    select prv).ToList();
                foreach (var prv in listaProveedores)
                {
                    DGV_PROVEEDOR.Rows.Add(prv.IdProveedor, prv.Nombre, prv.Telefono, prv.Direccion, prv.Correo);
                }
            }
        }

        private void DGV_PROVEEDOR_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGV_PROVEEDOR.Rows[e.RowIndex].Selected)
            {
                TXT_COD.Text = DGV_PROVEEDOR.Rows[e.RowIndex].Cells[0].Value.ToString();
                TXT_NOMBRE.Text = DGV_PROVEEDOR.Rows[e.RowIndex].Cells[1].Value.ToString();
                TXT_TELEFONO.Text = DGV_PROVEEDOR.Rows[e.RowIndex].Cells[2].Value.ToString();
                TXT_DIRECCION.Text = DGV_PROVEEDOR.Rows[e.RowIndex].Cells[3].Value.ToString();
                TXT_CORREO.Text = DGV_PROVEEDOR.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }


        private void BTN_GUARDAR_Click_1(object sender, EventArgs e)
        {
            if (Validar(true))
            {
                using (BDLIBRERIAEntities DB = new BDLIBRERIAEntities())
                {
                    Proveedor nuevoProveedor = new Proveedor();
                    nuevoProveedor.Nombre = TXT_NOMBRE.Text;
                    nuevoProveedor.Telefono = TXT_TELEFONO.Text;
                    nuevoProveedor.Direccion = TXT_DIRECCION.Text;
                    nuevoProveedor.Correo = TXT_CORREO.Text;
                    DB.Proveedor.Add(nuevoProveedor);
                    DB.SaveChanges();
                }
                MessageBox.Show("Proveedor guardado correctamente.");
                limpiar();
                FrmProveedor_Load(sender, e);
            }
        }



        private void BTN_MODIFICAR_Click(object sender, EventArgs e)
        {
            if (Validar(true))
            {
                using (BDLIBRERIAEntities DB = new BDLIBRERIAEntities())
                {
                    int idProveedor = int.Parse(TXT_COD.Text);
                    Proveedor proveedorExistente = DB.Proveedor.Find(idProveedor);
                    if (proveedorExistente != null)
                    {
                        proveedorExistente.Nombre = TXT_NOMBRE.Text;
                        proveedorExistente.Telefono = TXT_TELEFONO.Text;
                        proveedorExistente.Direccion = TXT_DIRECCION.Text;
                        proveedorExistente.Correo = TXT_CORREO.Text;
                        DB.SaveChanges();
                        MessageBox.Show("Proveedor actualizado correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("Proveedor no encontrado.");
                    }
                }
                limpiar();
                FrmProveedor_Load(sender, e);
            }
        }


        private void BTN_ELIMINAR_Click_1(object sender, EventArgs e)
        {
            if (validareeliminar(true))
            {
                using (BDLIBRERIAEntities DB = new BDLIBRERIAEntities())
                {
                    int idProveedor = int.Parse(TXT_COD.Text);
                    Proveedor proveedorExistente = DB.Proveedor.Find(idProveedor);
                    if (proveedorExistente != null)
                    {
                        DB.Proveedor.Remove(proveedorExistente);
                        DB.SaveChanges();
                        MessageBox.Show("Proveedor eliminado correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("Proveedor no encontrado.");
                    }
                }
                limpiar();
                FrmProveedor_Load(sender, e);
            }
          
        }

        private void limpiar()
        {
            TXT_COD.Clear();
            TXT_NOMBRE.Clear();
            TXT_TELEFONO.Clear();
            TXT_DIRECCION.Clear();
            TXT_CORREO.Clear();
        } 

        private bool Validar(bool nuevo)
        {
            if (string.IsNullOrWhiteSpace(TXT_NOMBRE.Text))
            {
                MessageBox.Show("El nombre es obligatorio.","Validación",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(TXT_TELEFONO.Text))
            {
                MessageBox.Show("El teléfono es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if(string.IsNullOrWhiteSpace(TXT_DIRECCION.Text))
            {
                MessageBox.Show("La dirección es obligatoria.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(TXT_CORREO.Text))
            {
                MessageBox.Show("El correo es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private bool validareeliminar(bool eli)
        {
            if (string.IsNullOrWhiteSpace(TXT_COD.Text))
            {
                MessageBox.Show("Seleccione un proveedor para eliminar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }

}