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
    public partial class Principal : Form
    {
        List<Usuario> listaUsuario = new List<Usuario>();

        public static int IdUsuarioLogueado;
        public static string NombreUsuario;

        public Principal()
        {
            InitializeComponent();
        }

        public Principal(Login loginForm)
        {
            InitializeComponent();

        }
        private void Principal_Load(object sender, EventArgs e)
        {
            CB_MENU.Items.Clear();


            CB_MENU.Items.Add("ROLES");
            CB_MENU.Items.Add("USUARIOS");
            CB_MENU.Items.Add("CLIENTES");
            CB_MENU.Items.Add("PROVEEDORES");


            CB_MENU.SelectedIndex = -1;

            CbProductos.Items.Clear();
            CbProductos.Items.Add("--Inventario de Productos--");
            CbProductos.Items.Add("PRODUCTOS");
            CbProductos.Items.Add("CATEGORIAS");
            CbProductos.SelectedIndex = 0;




            CBFactura.Items.Clear();
            CBFactura.Items.Add("--Facturas--");
            CBFactura.Items.Add("FACTURA");
            CBFactura.Items.Add("VENTAS");
            CBFactura.SelectedIndex = 0;


        }


        private void CB_MENU_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (CB_MENU.SelectedItem.ToString())
            {
                case "USUARIOS":
                    DGV_USUARIO mttoUsuario = new DGV_USUARIO(this);
                    mttoUsuario.ShowDialog();
                    break;

                case "ROLES":
                    FormRol formRol = new FormRol();
                    formRol.ShowDialog(this);
                    break;

                case "CLIENTES":
                    FrmClientes frmClientes = new FrmClientes();
                    frmClientes.ShowDialog(this);
                    break;
                case "PROVEEDORES":
                    FrmProveedor frmProveedors = new FrmProveedor();
                    frmProveedors.ShowDialog(this);
                    break;


                default:
                    break;
            }
        }



        private void CbProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (CbProductos.SelectedIndex)
            {
                case 1:
                    FrmProducto frmProducto = new FrmProducto();
                    frmProducto.ShowDialog();
                    break;

                case 2:
                    FrmCategoria frmCategoria = new FrmCategoria();
                    frmCategoria.ShowDialog();
                    break;
            }


            CbProductos.SelectedIndex = 0;
        }

        private void Gp_Menu_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void CBFactura_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (CBFactura.SelectedItem.ToString())
            {
                case "FACTURA":
                    Factura frm = new Factura(this);
                    frm.ShowDialog();
                    break;

                case "VENTAS":
                    FrmVentas frmventa = new FrmVentas();
                    frmventa.ShowDialog(this);
                    break;

            }
              

               
                CBFactura.SelectedIndex = 0;
            
        }
    }
    
}

