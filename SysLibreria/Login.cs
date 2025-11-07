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
    public partial class Login : Form
    {
        List<Usuario> listaUsuario = new List<Usuario>();
        public Login()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private bool validar(bool validar)
        {
            if(string.IsNullOrWhiteSpace(TXT_USUARIO.Text))
            {
                MessageBox.Show("Ingrese el nombre de usuario","Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TXT_USUARIO.Focus();
                return false ;
            }
            if(string.IsNullOrWhiteSpace(TXT_CONTRASEÑA.Text))
                {
                MessageBox.Show("Ingrese la contraseña","Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TXT_CONTRASEÑA.Focus();
                return false;
            }
            return true;
        }

        private bool autenticar(bool autenticar)
        {
            using (BDLIBRERIAEntities DB = new BDLIBRERIAEntities())
            {
                var usuarioe = (from u in DB.Usuario
                           where u.NomUsuario == TXT_USUARIO.Text && u.Contraseña == TXT_CONTRASEÑA.Text
                           select u).FirstOrDefault();
                return usuarioe != null;
            }
      

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try { 
            if (validar(true))
            {
                if (autenticar(true)) 
                {
                  Principal principalForm = new Principal(this);
                    principalForm.Show();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al autenticar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void LBL_CONTTRASEÑA_Click(object sender, EventArgs e)
        {

        }

        private void TXT_USUARIO_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
