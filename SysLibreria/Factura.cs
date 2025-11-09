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
            if(!string.IsNullOrWhiteSpace(TXT_BPRUCTO.Text))
            {
                foreach(var prod in listaProductos.Where(prod => ($"{prod.Nombre}").ToUpper().Trim().Contains(TXT_BPRUCTO.Text.ToUpper().Trim())))
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
            if(!string.IsNullOrWhiteSpace(TXT_CODIGO.Text))
            {
                foreach(var prod in listaProductos.Where(prod => ($"{prod.IdProducto}").ToUpper().Trim().Contains(TXT_CODIGO.Text.ToUpper().Trim())))
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

                    int nuevaFila = DGV_DVENTA.Rows.Add();

                    DGV_DVENTA.Rows[nuevaFila].Cells[0].Value = filaProducto.Cells[1].Value; 
                    DGV_DVENTA.Rows[nuevaFila].Cells[1].Value = cantidad; 
                    DGV_DVENTA.Rows[nuevaFila].Cells[2].Value = filaProducto.Cells[3].Value; 

                    decimal precio = Convert.ToDecimal(filaProducto.Cells[3].Value);
                    decimal subtotalFila = precio * cantidad;
                    DGV_DVENTA.Rows[nuevaFila].Cells[4].Value = subtotalFila;

                   
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




    }
}
