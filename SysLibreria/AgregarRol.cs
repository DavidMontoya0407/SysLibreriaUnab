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
    public partial class AgregarRol : Form
    {
      private FormRol formRol;
        public AgregarRol()
        {
            InitializeComponent();
        }

        public AgregarRol(FormRol pformRol)
        {
            InitializeComponent();
            formRol = pformRol;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (camposValidos(true))
            {
                if (agregarRol())
                {
                    formRol.Refrescar(true);
                }
                this.Close();
            }
        }

        private bool camposValidos(bool nuevo)
        {
          
            if (string.IsNullOrWhiteSpace(TXT_AGG_ROL.Text))
            {
                MessageBox.Show("Debe ingresar un rol",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            return true;

        }

        public bool agregarRol()
        {
            try
            {
                using (BDLIBRERIAEntities db = new BDLIBRERIAEntities())
                {
                    Rol Rol = new Rol();
                    Rol.Nombre = TXT_AGG_ROL.Text;

                    db.Rol.Add(Rol);
                    db.SaveChanges();

                    MessageBox.Show("Rol registrado con exito", "Mensaje",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al registrar Rol", "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                Console.WriteLine($"Error: {e.Message}");

                return false;
            }
        }

    
    }
}
