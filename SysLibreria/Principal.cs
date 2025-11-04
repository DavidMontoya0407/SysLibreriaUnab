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
      
        public Principal()
        {
            InitializeComponent();
        }

        public Principal(Login loginForm)
        {
            InitializeComponent();

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

                default:
                    break;
            }
        }
    }
}
