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
    public partial class Factura : Form
    {
        List<Producto> listaProductos = new List<Producto>();
        List<Factura> listaFacturas = new List<Factura>();
        List<Usuario> usuarios = new List<Usuario>();
        Principal Principal = new Principal();


        public Factura()
        {
            InitializeComponent();
        }



        public Factura(Principal principal)
        {
            InitializeComponent();
        }



        private void TXT_BPRUCTO_TextChanged(object sender, EventArgs e)
        {
            DGV_PRODUCTOS.Rows.Clear();
            if (!string.IsNullOrWhiteSpace(TXT_BPRUCTO.Text))
            {
                foreach (var prod in listaProductos.Where(prod => ($"{prod.Nombre}").ToUpper().Trim().Contains(TXT_BPRUCTO.Text.ToUpper().Trim())))
                {
                    DGV_PRODUCTOS.Rows.Add(prod.IdProducto, prod.Nombre, prod.Descripcion, prod.Precio);
                }
            }
            else
            {
                foreach (var producto in listaProductos)
                {
                    DGV_PRODUCTOS.Rows.Add(producto.IdProducto, producto.Nombre, producto.Descripcion, producto.Precio);
                }
            }
        }

        private void LBL_PRODUCTO_Click(object sender, EventArgs e)
        {

        }

        private void LBL_VENDEDOR_Click(object sender, EventArgs e)
        {

        }

        private void Factura_Load(object sender, EventArgs e)
        {
            DGV_PRODUCTOS.Rows.Clear();
            using (BDLIBRERIAEntities DB = new BDLIBRERIAEntities())
            {
                listaProductos = (from producto in DB.Producto
                                  select producto).ToList();

                foreach (var producto in listaProductos)
                {
                    DGV_PRODUCTOS.Rows.Add(producto.IdProducto, producto.Nombre, producto.Descripcion, producto.Precio);
                }
            }

            using (BDLIBRERIAEntities DB = new BDLIBRERIAEntities())
            {
                var usuarioe = DB.Usuario.FirstOrDefault(u => u.IdUsuario == SesionActual.IdUsuario);
                if (usuarioe != null)
                {
                    TXT_VENDEDOR.Text = usuarioe.Nombres;
                }
                else
                {
                    TXT_VENDEDOR.Text = "Desconocido";
                }
            }

            ContextMenuStrip cmsVenta = new ContextMenuStrip();

            cmsVenta.Items.Add("Editar descuento", null, editarDescuentoToolStripMenuItem_Click);
            cmsVenta.Items.Add("Editar cantidad", null, editarCantidadToolStripMenuItem_Click);
            cmsVenta.Items.Add("Eliminar producto", null, eliminarProductoToolStripMenuItem_Click);


            DGV_DVENTA.ContextMenuStrip = cmsVenta;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DGV_PRODUCTOS_CellContentClick(object sender, EventArgs e)
        {

        }

        private void TXT_CODIGO_TextChanged(object sender, EventArgs e)
        {
            DGV_PRODUCTOS.Rows.Clear();
            if (!string.IsNullOrWhiteSpace(TXT_CODIGO.Text))
            {
                foreach (var prod in listaProductos.Where(prod => ($"{prod.IdProducto}").ToUpper().Trim().Contains(TXT_CODIGO.Text.ToUpper().Trim())))
                {
                    DGV_PRODUCTOS.Rows.Add(prod.IdProducto, prod.Nombre, prod.Descripcion, prod.Precio);
                }
            }
            else
            {
                foreach (var producto in listaProductos)
                {
                    DGV_PRODUCTOS.Rows.Add(producto.IdProducto, producto.Nombre, producto.Descripcion, producto.Precio);
                }
            }
        }

        private void TXT_VENDEDOR_TextChanged(object sender, EventArgs e)
        {

        }

        private void DGV_PRODUCTOS_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow filaProducto = DGV_PRODUCTOS.Rows[e.RowIndex];

            using (FrmCantidad frm = new FrmCantidad())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    int cantidad = frm.Cantidad;

                    decimal desc = 0;

                    int nuevaFila = DGV_DVENTA.Rows.Add();
                    decimal precio = Math.Round(Convert.ToDecimal(filaProducto.Cells[3].Value), 2);
                    DGV_DVENTA.Rows[nuevaFila].Cells[0].Value = filaProducto.Cells[1].Value;
                    DGV_DVENTA.Rows[nuevaFila].Cells[1].Value = cantidad;
                    DGV_DVENTA.Rows[nuevaFila].Cells[2].Value = precio;
                    DGV_DVENTA.Rows[nuevaFila].Cells[3].Value = desc;
                    DGV_DVENTA.Rows[nuevaFila].Cells[5].Value = filaProducto.Cells[0].Value;
                    decimal subtotalFila = precio * cantidad;
                    DGV_DVENTA.Rows[nuevaFila].Cells[4].Value = subtotalFila.ToString("F2");


                    CalcularTotales();
                }
            }
        }


        private void CalcularTotales()
        {
            decimal subtotalGeneral = 0;


            foreach (DataGridViewRow fila in DGV_DVENTA.Rows)
            {
                if (fila.Cells[4].Value != null)
                    subtotalGeneral += Convert.ToDecimal(fila.Cells[4].Value);
            }


            decimal iva = subtotalGeneral * 0.13m;


            decimal total = subtotalGeneral + iva;


            TXT_SUBTOTAL.Text = subtotalGeneral.ToString("F2");
            TXT_IVA.Text = iva.ToString("F2");
            TXT_TOTAL.Text = total.ToString("F2");


        }

        private void CalcularCambio()
        {
            try
            {

                decimal total = 0;
                decimal monto = 0;


                if (!decimal.TryParse(TXT_TOTAL.Text, out total))
                    total = 0;

                if (!decimal.TryParse(TXT_MONTO.Text, out monto))
                    monto = 0;


                decimal cambio = monto - total;


                if (cambio < 0)
                    cambio = 0;


                TXT_CAMBIO.Text = cambio.ToString("F2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular el cambio: " + ex.Message);
            }
        }


        private void TXT_MONTO_TextChanged(object sender, EventArgs e)
        {
            CalcularCambio();
        }

        private void DGV_DVENTA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //const int INDICE_COLUMNA_DESCUENTO = 2;

            //if (e.RowIndex >= 0 && e.ColumnIndex == INDICE_COLUMNA_DESCUENTO)
            //{
            //    using (FormDescuento frmDescuento = new FormDescuento())
            //    {
            //        if (frmDescuento.ShowDialog() == DialogResult.OK)
            //        {
            //            decimal descuento = frmDescuento.Descuento;
            //            DGV_DVENTA.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = descuento;
            //        }
            //        else
            //        {
            //            DGV_DVENTA.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 0;
            //        }
            //    }
            //}
        }

        private void eliminarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DGV_DVENTA.CurrentRow != null)
            {
                DGV_DVENTA.Rows.Remove(DGV_DVENTA.CurrentRow);
                CalcularTotales();
            }
        }

        private void editarCantidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DGV_DVENTA.CurrentRow != null)
            {
                using (FrmCantidad frm = new FrmCantidad())
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        int nuevaCantidad = frm.Cantidad;


                        DGV_DVENTA.CurrentRow.Cells[1].Value = nuevaCantidad;


                        decimal precio = Convert.ToDecimal(DGV_DVENTA.CurrentRow.Cells[2].Value);
                        DGV_DVENTA.CurrentRow.Cells[4].Value = precio * nuevaCantidad;

                        CalcularTotales();
                    }
                }
            }
        }

        private void DGV_DVENTA_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void editarDescuentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DGV_DVENTA.CurrentRow != null)
            {
                using (FormDescuento frm = new FormDescuento())
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        decimal descuento = frm.Descuento;


                        DataGridViewRow fila = DGV_DVENTA.CurrentRow;

                        decimal cantidad = Convert.ToDecimal(fila.Cells[1].Value);
                        decimal precioUnit = Convert.ToDecimal(fila.Cells[2].Value);


                        decimal subtotal = cantidad * precioUnit;


                        decimal montoDescuento = subtotal * (descuento / 100);


                        decimal total = subtotal - montoDescuento;


                        fila.Cells[3].Value = descuento.ToString("F2");
                        fila.Cells[4].Value = total.ToString("F2");


                        CalcularTotales();
                    }
                }
            }
        }

        private bool validarCampos(bool nuevo)
        {
            if (string.IsNullOrWhiteSpace(TXT_NOMBRE_CLIENTE.Text))
            {
                MessageBox.Show("El nombre del cliente es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(TXT_DIRECCION.Text))
            {
                MessageBox.Show("La dirección del cliente es obligatoria.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(TXT_DOCUMENTO.Text))
            {
                MessageBox.Show("El documento del cliente es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;

        }

        public bool agregarfactura()
        {
            string timestamp = DateTime.Now.ToString("yyyyMMddHHmmssfff");
            try
            {
              
                using (BDLIBRERIAEntities DB = new BDLIBRERIAEntities())
                {
                    Cliente cliente = new Cliente();
                    {
                        cliente.Nombre = TXT_NOMBRE_CLIENTE.Text.Trim();
                        cliente.Documento = int.Parse(TXT_DOCUMENTO.Text);
                        cliente.Direccion = TXT_DIRECCION.Text.Trim();
                    }
                    DB.Cliente.Add(cliente);
                    DB.SaveChanges();
                    Venta nuevaVenta = new Venta
                    {
                                    
                        IdUsuario = SesionActual.IdUsuario,
                        IdCliente = cliente.IdCliente,
                        Fecha = DateTime.Now,
                        NumeroVenta = timestamp.GetHashCode(),
                        SubTotal = decimal.Parse(TXT_SUBTOTAL.Text),
                        Iva = decimal.Parse(TXT_IVA.Text),
                        Total = decimal.Parse(TXT_TOTAL.Text)
                    };
                    DB.Venta.Add(nuevaVenta);
                    DB.SaveChanges();
                    foreach (DataGridViewRow fila in DGV_DVENTA.Rows)
                    {
                        DetalleVenta detalle = new DetalleVenta
                        {
                            IdVenta = nuevaVenta.IdVenta,
                            IdProducto = int.Parse(fila.Cells[5].Value.ToString()),
                            Cantidad = int.Parse(fila.Cells[1].Value.ToString()),
                            Descuento = decimal.Parse(fila.Cells[3].Value.ToString()),
                            Total = decimal.Parse(fila.Cells[4].Value.ToString())
                        };
                        DB.DetalleVenta.Add(detalle);

                        var producto = DB.Producto.FirstOrDefault(p => p.IdProducto == detalle.IdProducto);
                        if (producto != null)
                        {
                            if (producto.Stock >= detalle.Cantidad)
                            {
                                producto.Stock -= detalle.Cantidad;
                            }
                            else
                            {
                                MessageBox.Show($"No hay suficiente stock para el producto '{producto.Nombre}'.", "Stock insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return false;
                            }
                        }

                    }
                    DB.SaveChanges();
                }
                MessageBox.Show("Factura agregada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la factura: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        private void limpiarCampos()
        {
            TXT_NOMBRE_CLIENTE.Clear();
            TXT_DOCUMENTO.Clear();
            TXT_DIRECCION.Clear();
            DGV_DVENTA.Rows.Clear();
            TXT_SUBTOTAL.Clear();
            TXT_IVA.Clear();
            TXT_TOTAL.Clear();
            TXT_MONTO.Clear();
            TXT_CAMBIO.Clear();
        }

        private void BTN_GUARDAR_Click(object sender, EventArgs e)
        {
            if(validarCampos(true))
            {
                if(agregarfactura())
                {
                    limpiarCampos();
                }
            }
        }

        private void BTN_SALIR_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
