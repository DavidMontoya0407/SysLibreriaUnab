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
            CB_MENU.Items.Add("VENTAS");
            CB_MENU.Items.Add("FACTURAS");

            CB_MENU.SelectedIndex = -1;

            CbProductos.Items.Clear();
            CbProductos.Items.Add("---Inventario Producto---");
            CbProductos.Items.Add("PRODUCTOS");
            CbProductos.Items.Add("CATEGORIAS");
            CbProductos.SelectedIndex = 0;
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

                case "VENTAS":
                    FrmVentas frmVentas = new FrmVentas();
                    frmVentas.StartPosition = FormStartPosition.CenterScreen;
                    frmVentas.ShowDialog(this);
                    break;

                case "FACTURAS":
                    Factura factura = new Factura();
                        factura.ShowDialog(this);
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
    }
}

