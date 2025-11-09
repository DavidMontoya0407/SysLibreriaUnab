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
    public partial class FrmCategoria : Form
    {
        private int? categoriaSeleccionadaId = null; // ← ID de la categoría en edición

        public FrmCategoria()
        {
            InitializeComponent();
            txtNombre.TextChanged += txtNombre_TextChanged;
            txtDescripcion.TextChanged += txtDescripcion_TextChanged;
        }

        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            CargarCategorias();
            DGV_CATEGORIA.CellDoubleClick += DGV_CATEGORIA_CellDoubleClick;
        }

        private void CargarCategorias()
        {
            DGV_CATEGORIA.Rows.Clear();

            using (var db = new BDLIBRERIAEntities())
            {
                var lista = db.Categoria.ToList();

                foreach (var cat in lista)
                {
                    DGV_CATEGORIA.Rows.Add(cat.IdCategoria, cat.Nombre, cat.Descripcion);
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("Complete todos los campos.");
                return;
            }

            using (var db = new BDLIBRERIAEntities())
            {
                var nueva = new Categoria
                {
                    Nombre = txtNombre.Text.Trim(),
                    Descripcion = txtDescripcion.Text.Trim()
                };

                db.Categoria.Add(nueva);
                db.SaveChanges();
            }

            MessageBox.Show("Categoría agregada correctamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimpiarCampos();
            CargarCategorias();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (DGV_CATEGORIA.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una fila para eliminar.");
                return;
            }

            var confirmacion = MessageBox.Show("¿Está segura de que desea eliminar esta categoría?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmacion != DialogResult.Yes)
                return;

            int id = Convert.ToInt32(DGV_CATEGORIA.SelectedRows[0].Cells[0].Value);

            using (var db = new BDLIBRERIAEntities())
            {
                var categoria = db.Categoria.Find(id);
                if (categoria != null)
                {
                    db.Categoria.Remove(categoria);
                    db.SaveChanges();
                }
            }

            MessageBox.Show("Categoría eliminada correctamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimpiarCampos();
            CargarCategorias();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (categoriaSeleccionadaId == null)
            {
                MessageBox.Show("Seleccione una categoría para modificar.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("Complete todos los campos.");
                return;
            }

            using (var db = new BDLIBRERIAEntities())
            {
                var categoria = db.Categoria.Find(categoriaSeleccionadaId.Value);
                if (categoria != null)
                {
                    categoria.Nombre = txtNombre.Text.Trim();
                    categoria.Descripcion = txtDescripcion.Text.Trim();
                    db.SaveChanges();
                }
            }

            MessageBox.Show("Categoría modificada correctamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimpiarCampos();
            CargarCategorias();
        }

        private void DGV_CATEGORIA_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var fila = DGV_CATEGORIA.Rows[e.RowIndex];
                categoriaSeleccionadaId = Convert.ToInt32(fila.Cells[0].Value); // ← Guardar ID

                txtNombre.Text = fila.Cells[1].Value?.ToString() ?? "";
                txtDescripcion.Text = fila.Cells[2].Value?.ToString() ?? "";
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            FiltrarCategorias();
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            FiltrarCategorias();
        }

        private void FiltrarCategorias()
        {
            string nombre = txtNombre.Text.Trim();
            string descripcion = txtDescripcion.Text.Trim();

            DGV_CATEGORIA.Rows.Clear();

            using (var db = new BDLIBRERIAEntities())
            {
                var lista = db.Categoria
                    .Where(c =>
                        c.Nombre.Contains(nombre) &&
                        c.Descripcion.Contains(descripcion))
                    .ToList();

                foreach (var cat in lista)
                {
                    DGV_CATEGORIA.Rows.Add(cat.IdCategoria, cat.Nombre, cat.Descripcion);
                }
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            categoriaSeleccionadaId = null; // ← Limpiar ID
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
