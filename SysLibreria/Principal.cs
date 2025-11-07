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

            CB_MENU.SelectedIndex = -1; 
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

                default:
                    break;
            }
        }
    }
}

