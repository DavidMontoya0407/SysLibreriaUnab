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
            TXT_VENDEDOR.Text = SesionActual.IdUsuario.ToString();
        }
    }
}
