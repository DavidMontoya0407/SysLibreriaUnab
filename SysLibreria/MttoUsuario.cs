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
    public partial class DGV_USUARIO : Form
    {
        List<Usuario> listaUsuario = new List<Usuario>();
        Login login = new Login();
        Principal Principal = new Principal();
        public DGV_USUARIO()
        {
            InitializeComponent();
        }

        public DGV_USUARIO(Login loginForm)
        {
            InitializeComponent();
            login = loginForm;
            
        }

        public DGV_USUARIO(Principal principalForm)
        {
            InitializeComponent();
            Principal = principalForm;
        }

        private void BTN_ROL_Click(object sender, EventArgs e)
        {
            FormRol frmRol = new FormRol(this);
            frmRol.ShowDialog();
        }

        private void MttoUsuario_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            using (BDLIBRERIAEntities DB = new BDLIBRERIAEntities())
            {
                listaUsuario = (from usuario in DB.Usuario
                                select usuario).ToList();
                foreach (var usuario in listaUsuario)
                {
                    dataGridView1.Rows.Add(usuario.IdUsuario, usuario.Nombres, usuario.Apellidos, usuario.Rol.Nombre,usuario.IdRol,
                       (usuario.Estado == 0 ? "Activo" : "Inactivo"));
                }
            }

        }


        private void Refrescar(bool newbd)
        {
            dataGridView1.Rows.Clear();
            if (newbd)
            {
                using (BDLIBRERIAEntities DB = new BDLIBRERIAEntities())
                {
                    listaUsuario = (from usuario in DB.Usuario
                                    select usuario).ToList();

                    foreach (var usuario in listaUsuario)
                    {
                        dataGridView1.Rows.Add(usuario.IdUsuario, usuario.Nombres, usuario.Apellidos, usuario.Rol.Nombre,usuario.IdRol,
                           usuario.Estado.Equals("1") ? "Inactivo" : "Activo");
                    }
                }
            }
            else
            {
                foreach (Usuario usuario in listaUsuario.OrderBy(usuario => usuario.IdUsuario))
                {
                    dataGridView1.Rows.Add(usuario.IdUsuario, usuario.Nombres, usuario.Apellidos, usuario.Rol.Nombre, usuario.IdRol,
                       usuario.Estado.Equals("1") ? "Inactivo" : "Activo");
                }
            }
        }

        private bool ValidarCampos(bool nuevo)
        {
            if (string.IsNullOrWhiteSpace(COD_ROL.Text))
            {
                MessageBox.Show("Debe ingresar el rol del usuario", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(TXT_NOMBRE.Text))
            {
                MessageBox.Show("El campo Nombre Rol es obligatorio", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(LBL_APELLIDO.Text))
            {
                MessageBox.Show("El campo Apellido es obligatorio", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if( string.IsNullOrWhiteSpace(TXT_USER.Text))
            {
                MessageBox.Show("El campo Usuario es obligatorio", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if(string.IsNullOrWhiteSpace(TXT_CONTRASEÑA.Text))
            {   MessageBox.Show("El campo Contraseña es obligatorio", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (CB_ESTADO.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un estado para el usuario", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        public void limpiarCampos()
        { 
            COD_ROL.Text = string.Empty;
            NOM_ROL.Text = string.Empty;
            TXT_NOMBRE.Text = string.Empty;
            TXT_APELLIDOS.Text = string.Empty;
            TXT_USER.Text = string.Empty;
            TXT_CONTRASEÑA.Text = string.Empty;
            CB_ESTADO.SelectedIndex = 0;
        }

        public bool agregarUsuario()
        {
            try
            {
                using (BDLIBRERIAEntities DB = new BDLIBRERIAEntities())
                {
                    Usuario usuario = new Usuario();

                    usuario.Nombres = TXT_NOMBRE.Text.Trim();
                    usuario.Apellidos = TXT_APELLIDOS.Text.Trim();
                    usuario.NomUsuario = TXT_USER.Text.Trim();
                    usuario.Contraseña = TXT_CONTRASEÑA.Text.Trim();
                    usuario.Estado = Convert.ToByte(CB_ESTADO.SelectedIndex);
                    usuario.IdRol = int.Parse(COD_ROL.Text);
                    
                    DB.Usuario.Add(usuario);
                    DB.SaveChanges();
                    MessageBox.Show("Usuario agregado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                           
            
            }
            catch (Exception )
            {
                MessageBox.Show("Error al agregar el usuario" 
                    , "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }

        }

        private bool EliminarUsuario()
        { 
            try
            {
                using (BDLIBRERIAEntities db = new BDLIBRERIAEntities())
                {
                    int idUsuario = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    var usuario = db.Usuario.Find(idUsuario);
                    if (usuario != null)
                    {

                        DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar el usuario seleccionado?", "Confirmar eliminación",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            db.Usuario.Remove(usuario);
                            db.SaveChanges();
                            MessageBox.Show("Usuario eliminado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return true;

                        }
                    }
                  
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Debe seleccionar un registro a eliminar", "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            return false;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        public void COD_ROL_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void BTN_AGREGAR_Click(object sender, EventArgs e)
        {
            if (ValidarCampos(true))
            {
                if (agregarUsuario())
                {
                   
                    Refrescar(true);
                }
                limpiarCampos();
            }
        }

        private void BTN_ELIMINAR_Click(object sender, EventArgs e)
        {
            if (EliminarUsuario())
            {
                Refrescar(true);
            }
        }

        private void NOM_ROL_TextChanged(object sender, EventArgs e)
        {

        }

        private void CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
       
            if (dataGridView1.Rows[e.RowIndex].Selected)
            {
              
                TXT_NOMBRE.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                TXT_APELLIDOS.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                TXT_CO_USER.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                //TXT_USER.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                //TXT_CONTRASEÑA.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                NOM_ROL.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                COD_ROL.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                string estado = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                if (estado == "Activo")
                {
                    CB_ESTADO.SelectedIndex = 0;
                }
                else
                {
                    CB_ESTADO.SelectedIndex = 1;
                }

            }
        }

        public bool modificarusuario()
        {
            try
            {
                using (BDLIBRERIAEntities DB = new BDLIBRERIAEntities())
                {
                    int idUsuario = int.Parse(TXT_CO_USER.Text); 

                   
                    Usuario usuario = DB.Usuario.FirstOrDefault(u => u.IdUsuario == idUsuario);

                    if (usuario != null)
                    {
                        
                        usuario.Nombres = TXT_NOMBRE.Text.Trim();
                        usuario.Apellidos = TXT_APELLIDOS.Text.Trim();
                        usuario.Estado = Convert.ToByte(CB_ESTADO.SelectedIndex);
                        usuario.IdRol = int.Parse(COD_ROL.Text);

                        
                        DB.SaveChanges();

                        MessageBox.Show("Usuario modificado correctamente", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el usuario a modificar.", "Advertencia",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el usuario: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void BTN_MODIFICAR_Click(object sender, EventArgs e)
        {
            if (ValidarCamposmodificar(true))
            {
                if (modificarusuario())
                {

                    Refrescar(true);
                }
                limpiarCampos();
            }
        }

        private bool ValidarCamposmodificar(bool nuevo)
        {
            if (string.IsNullOrWhiteSpace(COD_ROL.Text))
            {
                MessageBox.Show("Debe ingresar el rol del usuario", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(TXT_NOMBRE.Text))
            {
                MessageBox.Show("El campo Nombre Rol es obligatorio", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(LBL_APELLIDO.Text))
            {
                MessageBox.Show("El campo Apellido es obligatorio", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
          
            if (CB_ESTADO.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un estado para el usuario", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
             
        }

        private void TXT_USER_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
