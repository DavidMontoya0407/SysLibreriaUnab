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
    public partial class FrmVentas : Form
    {

        List<Venta> listaVentas = new List<Venta>();
        FormReporte Formreporte = new FormReporte();
        public FrmVentas()
        {
            InitializeComponent();

        }

        public FrmVentas(FormReporte formReporte)
        {
            InitializeComponent();
            Formreporte = formReporte;
        }


       
       
      

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

       
        

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {

            DateTime fInicio = dtpFechaInicial.Value.Date;
            DateTime fFinal = dtpFechafin.Value.Date;

         
            dgvVentas.Rows.Clear();

            if (fInicio > fFinal)
            {
                MessageBox.Show("La fecha inicial no puede ser mayor que la fecha final.",
                                "Error de rango", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var ventasFiltradas = listaVentas
                .Where(v => v.Fecha.Date >= fInicio && v.Fecha.Date <= fFinal)
                .ToList();

       
            if (ventasFiltradas.Count == 0)
            {
                MessageBox.Show("No se encontraron ventas en el rango de fechas seleccionado.",
                                "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

         
            foreach (var venta in ventasFiltradas)
            {
                dgvVentas.Rows.Add(
                    venta.IdVenta,
                    venta.Fecha.ToString("dd/MM/yyyy"),  
                    venta.Cliente.Nombre,
                    venta.Usuario.Nombres
                );
            }


        }

        private void dgvVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

            if (dgvVentas.Rows[e.RowIndex].Selected)
            {
                Formreporte.TXT_FECHA.Text = dgvVentas.Rows[e.RowIndex].Cells[1].Value.ToString();
                Formreporte.TXT_CLIENTE.Text = dgvVentas.Rows[e.RowIndex].Cells[2].Value.ToString();
                Formreporte.TXT_VENDEDOR.Text = dgvVentas.Rows[e.RowIndex].Cells[3].Value.ToString();
                this.Close();
            }

        }

        private void FrmVentas_Load_1(object sender, EventArgs e)
        {
            dgvVentas.Rows.Clear();
            using (BDLIBRERIAEntities DB = new BDLIBRERIAEntities())
            {
                listaVentas = (from venta in DB.Venta
                               select venta).ToList();
                foreach (var venta in listaVentas)
                {
                    dgvVentas.Rows.Add(venta.IdVenta, venta.Fecha, venta.Cliente.Nombre, venta.Usuario.Nombres);
                }
            }
        }

        private void dtpFechaInicial_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dgvVentas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            

            if (dgvVentas.Rows[e.RowIndex].Selected)
            {
                Formreporte.TXT_FECHA.Text = dgvVentas.Rows[e.RowIndex].Cells[1].Value.ToString();
                Formreporte.TXT_CLIENTE.Text = dgvVentas.Rows[e.RowIndex].Cells[2].Value.ToString();
                Formreporte.TXT_VENDEDOR.Text = dgvVentas.Rows[e.RowIndex].Cells[3].Value.ToString();
                this.Close();
            }
           
        }
    }
}
       
     
