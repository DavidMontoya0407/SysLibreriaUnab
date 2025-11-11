using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysLibreria
{
    public partial class FrmProducto : Form
    {
        private int? productoSeleccionadoId = null;
        public FrmProducto()
        {
            InitializeComponent();
            this.txtPrecio.KeyPress += new KeyPressEventHandler(txtPrecio_KeyPress);
            this.txtStock.KeyPress += new KeyPressEventHandler(txtStock_KeyPress);

            
            txtNombre.TextChanged += (s, e) => FiltrarProductos();
            txtDescripcion.TextChanged += (s, e) => FiltrarProductos();
            txtPrecio.TextChanged += (s, e) => FiltrarProductos();
            txtStock.TextChanged += (s, e) => FiltrarProductos();

           
            cbProveedor.SelectedIndexChanged += (s, e) => FiltrarProductos();
            cbCategoria.SelectedIndexChanged += (s, e) => FiltrarProductos();
        }

        private void FiltrarProductos()
        {
            string nombre = txtNombre.Text.Trim();
            string descripcion = txtDescripcion.Text.Trim();
            string precioTexto = txtPrecio.Text.Trim();
            string stockTexto = txtStock.Text.Trim();

            int? proveedorId = cbProveedor.SelectedValue as int?;
            int? categoriaId = cbCategoria.SelectedValue as int?;

            DGV_PRODUCTO.Rows.Clear();

            using (var db = new BDLIBRERIAEntities())
            {
                var query = db.Producto.AsQueryable();

                if (!string.IsNullOrEmpty(nombre))
                    query = query.Where(p => p.Nombre.Contains(nombre));

                if (!string.IsNullOrEmpty(descripcion))
                    query = query.Where(p => p.Descripcion.Contains(descripcion));

                if (!string.IsNullOrEmpty(precioTexto))
                    query = query.Where(p => p.Precio.ToString().Contains(precioTexto));

                if (!string.IsNullOrEmpty(stockTexto))
                    query = query.Where(p => p.Stock.ToString().Contains(stockTexto));

              
                if (proveedorId.HasValue && proveedorId.Value > 0)
                    query = query.Where(p => p.IdProveedor == proveedorId.Value);

                
                if (categoriaId.HasValue && categoriaId.Value > 0)
                    query = query.Where(p => p.IdCategoria == categoriaId.Value);

                var lista = query.Select(p => new
                {
                    p.IdProducto,
                    p.Nombre,
                    p.Descripcion,
                    p.Precio,
                    p.Stock,
                    ProveedorNombre = p.Proveedor.Nombre,
                    CategoriaNombre = p.Categoria.Nombre,
                    p.IdProveedor,
                    p.IdCategoria
                }).ToList();

                foreach (var p in lista)
                {
                    DGV_PRODUCTO.Rows.Add(
                        p.IdProducto,
                        p.Nombre,
                        p.Descripcion,
                        p.Precio.ToString("F2"),
                        p.Stock,
                        p.ProveedorNombre,
                        p.CategoriaNombre,
                        p.IdProveedor,
                        p.IdCategoria
                    );
                }
            }
        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            DGV_PRODUCTO.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_PRODUCTO.MultiSelect = false;

            CargarCombos();
            ConfigurarColumnas();
            CargarProductos();

            txtNombre.TextChanged += (s, ev) => FiltrarProductos();
            txtDescripcion.TextChanged += (s, ev) => FiltrarProductos();
            txtPrecio.TextChanged += (s, ev) => FiltrarProductos();
            txtStock.TextChanged += (s, ev) => FiltrarProductos();
            cbProveedor.SelectedIndexChanged += (s, ev) => FiltrarProductos();
            cbCategoria.SelectedIndexChanged += (s, ev) => FiltrarProductos();
        }

        private void CargarCombos()
        {
            using (var db = new BDLIBRERIAEntities())
            {
               
                var proveedores = db.Proveedor
                    .Select(p => new { p.IdProveedor, p.Nombre })
                    .ToList();

                proveedores.Insert(0, new { IdProveedor = 0, Nombre = "Todos" });

                cbProveedor.DataSource = proveedores;
                cbProveedor.DisplayMember = "Nombre";
                cbProveedor.ValueMember = "IdProveedor";
                cbProveedor.SelectedIndex = 0;

              
                var categorias = db.Categoria
                    .Select(c => new { c.IdCategoria, c.Nombre })
                    .ToList();

                categorias.Insert(0, new { IdCategoria = 0, Nombre = "Todos" });

                cbCategoria.DataSource = categorias;
                cbCategoria.DisplayMember = "Nombre";
                cbCategoria.ValueMember = "IdCategoria";
                cbCategoria.SelectedIndex = 0;
            }
        }
        private void ConfigurarColumnas()
        {
            DGV_PRODUCTO.Columns.Clear();
            DGV_PRODUCTO.Columns.Add("IdProducto", "ID");
            DGV_PRODUCTO.Columns.Add("Nombre", "Nombre");
            DGV_PRODUCTO.Columns.Add("Descripcion", "Descripción");
            DGV_PRODUCTO.Columns.Add("Precio", "Precio");
            DGV_PRODUCTO.Columns.Add("Stock", "Stock");
            DGV_PRODUCTO.Columns.Add("ProveedorNombre", "Proveedor");
            DGV_PRODUCTO.Columns.Add("CategoriaNombre", "Categoría");
            DGV_PRODUCTO.Columns.Add("IdProveedor", "IdProveedor");
            DGV_PRODUCTO.Columns.Add("IdCategoria", "IdCategoria");

            DGV_PRODUCTO.Columns["IdProducto"].Visible = false;
            DGV_PRODUCTO.Columns["IdProveedor"].Visible = false;
            DGV_PRODUCTO.Columns["IdCategoria"].Visible = false;
        }

        private void CargarProductos()
        {
            DGV_PRODUCTO.Rows.Clear();

            using (var db = new BDLIBRERIAEntities())
            {
                int? proveedorId = cbProveedor.SelectedValue as int?;
                int? categoriaId = cbCategoria.SelectedValue as int?;

                var query = db.Producto.AsQueryable();

                if (proveedorId.HasValue && proveedorId.Value > 0)
                    query = query.Where(p => p.IdProveedor == proveedorId.Value);

                if (categoriaId.HasValue && categoriaId.Value > 0)
                    query = query.Where(p => p.IdCategoria == categoriaId.Value);

                var lista = query
                    .Select(p => new
                    {
                        p.IdProducto,
                        p.Nombre,
                        p.Descripcion,
                        p.Precio,
                        p.Stock,
                        ProveedorNombre = p.Proveedor.Nombre,
                        CategoriaNombre = p.Categoria.Nombre,
                        p.IdProveedor,
                        p.IdCategoria
                    }).ToList();

                foreach (var p in lista)
                {
                    DGV_PRODUCTO.Rows.Add(
                        p.IdProducto,
                        p.Nombre,
                        p.Descripcion,
                        p.Precio.ToString("F2"),
                        p.Stock,
                        p.ProveedorNombre,
                        p.CategoriaNombre,
                        p.IdProveedor,
                        p.IdCategoria
                    );
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
        string.IsNullOrWhiteSpace(txtDescripcion.Text) ||
        string.IsNullOrWhiteSpace(txtPrecio.Text) ||
        string.IsNullOrWhiteSpace(txtStock.Text))
            {
                MessageBox.Show("Complete todos los campos.");
                return;
            }

            string precioTexto = txtPrecio.Text.Replace(",", ".");
            if (!decimal.TryParse(precioTexto, out decimal precio))
            {
                MessageBox.Show("Ingrese un precio válido (ejemplo: 1.25).");
                return;
            }

            if (!int.TryParse(txtStock.Text, out int stock))
            {
                MessageBox.Show("Ingrese una cantidad válida en Stock.");
                return;
            }

            if (cbProveedor.SelectedValue == null || cbCategoria.SelectedValue == null)
            {
                MessageBox.Show("Seleccione proveedor y categoría válidos.");
                return;
            }

            using (var db = new BDLIBRERIAEntities())
            {
                var nuevo = new Producto
                {
                    Nombre = txtNombre.Text.Trim(),
                    Descripcion = txtDescripcion.Text.Trim(),
                    Precio = precio,
                    Stock = stock,
                    IdProveedor = Convert.ToInt32(cbProveedor.SelectedValue),
                    IdCategoria = Convert.ToInt32(cbCategoria.SelectedValue)
                };

                db.Producto.Add(nuevo);
                db.SaveChanges();
            }

            MessageBox.Show("Producto agregado correctamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimpiarCampos();
            CargarProductos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGV_PRODUCTO.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione un producto para eliminar.");
                    return;
                }

                var confirmacion = MessageBox.Show("¿Está segura de que desea eliminar este producto?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmacion != DialogResult.Yes)
                    return;

                int id = Convert.ToInt32(DGV_PRODUCTO.SelectedRows[0].Cells["IdProducto"].Value);

                using (var db = new BDLIBRERIAEntities())
                {
                    var producto = db.Producto.Find(id);
                    if (producto != null)
                    {
                        db.Producto.Remove(producto);
                        db.SaveChanges();

                        MessageBox.Show("Producto eliminado correctamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                LimpiarCampos();
                CargarProductos();
            }
            catch(Exception p)
            {
                MessageBox.Show("Error al eliminar el producto. Es posible que esté asociado a otras entidades. " , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (productoSeleccionadoId == null)
            {
                MessageBox.Show("Seleccione un producto para modificar.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtDescripcion.Text) ||
                string.IsNullOrWhiteSpace(txtPrecio.Text) ||
                string.IsNullOrWhiteSpace(txtStock.Text))
            {
                MessageBox.Show("Complete todos los campos antes de modificar.");
                return;
            }

            string precioTexto = txtPrecio.Text.Replace(",", ".");
            if (!decimal.TryParse(precioTexto, out decimal precio))
            {
                MessageBox.Show("Ingrese un precio válido.");
                return;
            }

            if (!int.TryParse(txtStock.Text, out int stock))
            {
                MessageBox.Show("Ingrese una cantidad válida en Stock.");
                return;
            }

            if (cbProveedor.SelectedValue == null || cbCategoria.SelectedValue == null)
            {
                MessageBox.Show("Seleccione proveedor y categoría válidos.");
                return;
            }

            using (var db = new BDLIBRERIAEntities())
            {
                var producto = db.Producto.Find(productoSeleccionadoId.Value);
                if (producto != null)
                {
                    producto.Nombre = txtNombre.Text.Trim();
                    producto.Descripcion = txtDescripcion.Text.Trim();
                    producto.Precio = precio;
                    producto.Stock = stock;
                    producto.IdProveedor = Convert.ToInt32(cbProveedor.SelectedValue);
                    producto.IdCategoria = Convert.ToInt32(cbCategoria.SelectedValue);

                    db.SaveChanges();
                }
            }

            MessageBox.Show("Producto modificado correctamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimpiarCampos();
            CargarProductos();
        }

        private void DGV_PRODUCTO_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
            cbProveedor.SelectedIndex = 0;
            cbCategoria.SelectedIndex = 0;
            productoSeleccionadoId = null;
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.' || e.KeyChar == ',') &&
                (txtPrecio.Text.Contains(".") || txtPrecio.Text.Contains(",")))
            {
                e.Handled = true;
            }
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void DGV_PRODUCTO_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var fila = DGV_PRODUCTO.Rows[e.RowIndex];
                fila.Selected = true;

                productoSeleccionadoId = Convert.ToInt32(fila.Cells["IdProducto"].Value);

                txtNombre.Text = fila.Cells["Nombre"].Value?.ToString() ?? "";
                txtDescripcion.Text = fila.Cells["Descripcion"].Value?.ToString() ?? "";
                txtPrecio.Text = Convert.ToDecimal(fila.Cells["Precio"].Value).ToString("F2");
                txtStock.Text = fila.Cells["Stock"].Value?.ToString() ?? "";

                if (fila.Cells["IdProveedor"].Value != null)
                    cbProveedor.SelectedValue = Convert.ToInt32(fila.Cells["IdProveedor"].Value);

                if (fila.Cells["IdCategoria"].Value != null)
                    cbCategoria.SelectedValue = Convert.ToInt32(fila.Cells["IdCategoria"].Value);
            }
        }

        private void DGV_PRODUCTO_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
