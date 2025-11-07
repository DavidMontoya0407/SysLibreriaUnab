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
    public partial class FormRol : Form
    {
        List<Rol> listaRoles = new List<Rol>();
        DGV_USUARIO DGV_USUARIO = new DGV_USUARIO();    
        public FormRol()
        {

            InitializeComponent();
        }

        public FormRol(DGV_USUARIO dgv_usuario)
        {
            InitializeComponent();
            DGV_USUARIO = dgv_usuario;
        }

        public FormRol(Principal principal)
        {
            InitializeComponent();
            
        }
        private void FormRol_Load(object sender, EventArgs e)
        {
            DGV_ROLES.Rows.Clear();

            using (BDLIBRERIAEntities db = new BDLIBRERIAEntities())
            {
                listaRoles = (from rol in db.Rol
                              select rol).ToList();

                foreach (var rol in listaRoles)
                {
                    DGV_ROLES.Rows.Add(rol.IdRol, rol.Nombre);
                }
            }
        }

        private void DGV_ROLES_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGV_ROLES.Rows[e.RowIndex].Selected)
            {
                DGV_USUARIO.COD_ROL.Text = DGV_ROLES.Rows[e.RowIndex].Cells[0].Value.ToString();
                DGV_USUARIO.NOM_ROL.Text = DGV_ROLES.Rows[e.RowIndex].Cells[1].Value.ToString();
                this.Close();
            }
        }

        private void TXT_ROL_TextChanged(object sender, EventArgs e)
        {
            DGV_ROLES.Rows.Clear();
            if (!string.IsNullOrWhiteSpace(TXT_ROL.Text))
            {
                foreach (var rol in listaRoles.Where(rol => ($"{rol.Nombre}").ToUpper().Trim().Contains(TXT_ROL.Text.ToUpper().Trim())))
                {
                    DGV_ROLES.Rows.Add(rol.IdRol, rol.Nombre);
                }
            }
            else
            {
                foreach (var rol in listaRoles)
                {
                    DGV_ROLES.Rows.Add(rol.IdRol, rol.Nombre);
                }
            }
        }

        private void BTN_AGG_ROL_Click(object sender, EventArgs e)
        {
            AgregarRol aggrol = new AgregarRol(this);
            aggrol.ShowDialog();
        }

        public void Refrescar(bool newbd)
        {
            DGV_ROLES.Rows.Clear();
            if(newbd)
            {
                using (BDLIBRERIAEntities db = new BDLIBRERIAEntities())
                {

                    listaRoles = (from rol in db.Rol
                                  select rol).ToList();
                    foreach (Rol rol in listaRoles)
                    {
                        DGV_ROLES.Rows.Add(rol.IdRol, rol.Nombre);
                    }
                 }

            }
            else
            {
                foreach (var rol in listaRoles)
                {
                    DGV_ROLES.Rows.Add(rol.IdRol, rol.Nombre);
                }
            }
        }

        private bool EliminarRol()
        {
            try
            {
                using (BDLIBRERIAEntities db = new BDLIBRERIAEntities())
                {
                    int idRol = Convert.ToInt32(DGV_ROLES.CurrentRow.Cells[0].Value);
                    Rol rol = db.Rol.Find(idRol);
                    if (rol != null)
                    {
                        DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar el rol seleccionado?", "Confirmar eliminación",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);


                        if (result == DialogResult.Yes)
                        {
                            db.Rol.Remove(rol);
                            db.SaveChanges();

                            MessageBox.Show("Rol eliminado con éxito", "Mensaje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
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

        private void BTN_ELIMINAR_Click(object sender, EventArgs e)
        {
            if(EliminarRol())
            {
                Refrescar(true);
            }
        }

       
    }
}
