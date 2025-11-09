namespace SysLibreria
{
    partial class FormReporte
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LBL_FECHA = new System.Windows.Forms.Label();
            this.TXT_FECHA = new System.Windows.Forms.TextBox();
            this.LBL_VENDEDOR = new System.Windows.Forms.Label();
            this.TXT_VENDEDOR = new System.Windows.Forms.TextBox();
            this.LBL_CLIENTE = new System.Windows.Forms.Label();
            this.TXT_CLIENTE = new System.Windows.Forms.TextBox();
            this.Venta = new System.Windows.Forms.GroupBox();
            this.DGV_REPORTE = new System.Windows.Forms.DataGridView();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_Unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Venta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_REPORTE)).BeginInit();
            this.SuspendLayout();
            // 
            // LBL_FECHA
            // 
            this.LBL_FECHA.AutoSize = true;
            this.LBL_FECHA.Location = new System.Drawing.Point(7, 34);
            this.LBL_FECHA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_FECHA.Name = "LBL_FECHA";
            this.LBL_FECHA.Size = new System.Drawing.Size(49, 18);
            this.LBL_FECHA.TabIndex = 0;
            this.LBL_FECHA.Text = "Fecha";
            // 
            // TXT_FECHA
            // 
            this.TXT_FECHA.Location = new System.Drawing.Point(61, 25);
            this.TXT_FECHA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT_FECHA.Multiline = true;
            this.TXT_FECHA.Name = "TXT_FECHA";
            this.TXT_FECHA.ReadOnly = true;
            this.TXT_FECHA.Size = new System.Drawing.Size(151, 24);
            this.TXT_FECHA.TabIndex = 1;
            // 
            // LBL_VENDEDOR
            // 
            this.LBL_VENDEDOR.AutoSize = true;
            this.LBL_VENDEDOR.Location = new System.Drawing.Point(305, 28);
            this.LBL_VENDEDOR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_VENDEDOR.Name = "LBL_VENDEDOR";
            this.LBL_VENDEDOR.Size = new System.Drawing.Size(71, 18);
            this.LBL_VENDEDOR.TabIndex = 2;
            this.LBL_VENDEDOR.Text = "Vendedor";
            // 
            // TXT_VENDEDOR
            // 
            this.TXT_VENDEDOR.Location = new System.Drawing.Point(384, 22);
            this.TXT_VENDEDOR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT_VENDEDOR.Name = "TXT_VENDEDOR";
            this.TXT_VENDEDOR.ReadOnly = true;
            this.TXT_VENDEDOR.Size = new System.Drawing.Size(212, 24);
            this.TXT_VENDEDOR.TabIndex = 3;
            // 
            // LBL_CLIENTE
            // 
            this.LBL_CLIENTE.AutoSize = true;
            this.LBL_CLIENTE.Location = new System.Drawing.Point(7, 84);
            this.LBL_CLIENTE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_CLIENTE.Name = "LBL_CLIENTE";
            this.LBL_CLIENTE.Size = new System.Drawing.Size(53, 18);
            this.LBL_CLIENTE.TabIndex = 4;
            this.LBL_CLIENTE.Text = "Cliente";
            // 
            // TXT_CLIENTE
            // 
            this.TXT_CLIENTE.Location = new System.Drawing.Point(61, 78);
            this.TXT_CLIENTE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT_CLIENTE.Multiline = true;
            this.TXT_CLIENTE.Name = "TXT_CLIENTE";
            this.TXT_CLIENTE.ReadOnly = true;
            this.TXT_CLIENTE.Size = new System.Drawing.Size(151, 24);
            this.TXT_CLIENTE.TabIndex = 5;
            // 
            // Venta
            // 
            this.Venta.BackColor = System.Drawing.Color.LavenderBlush;
            this.Venta.Controls.Add(this.TXT_CLIENTE);
            this.Venta.Controls.Add(this.LBL_CLIENTE);
            this.Venta.Controls.Add(this.TXT_VENDEDOR);
            this.Venta.Controls.Add(this.LBL_VENDEDOR);
            this.Venta.Controls.Add(this.TXT_FECHA);
            this.Venta.Controls.Add(this.LBL_FECHA);
            this.Venta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Venta.Location = new System.Drawing.Point(17, 17);
            this.Venta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Venta.Name = "Venta";
            this.Venta.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Venta.Size = new System.Drawing.Size(677, 129);
            this.Venta.TabIndex = 6;
            this.Venta.TabStop = false;
            this.Venta.Text = "Venta";
            this.Venta.Enter += new System.EventHandler(this.Venta_Enter);
            // 
            // DGV_REPORTE
            // 
            this.DGV_REPORTE.BackgroundColor = System.Drawing.Color.White;
            this.DGV_REPORTE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_REPORTE.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.Cantidad,
            this.P_Unitario,
            this.Descuento,
            this.Total});
            this.DGV_REPORTE.Location = new System.Drawing.Point(13, 154);
            this.DGV_REPORTE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DGV_REPORTE.Name = "DGV_REPORTE";
            this.DGV_REPORTE.ReadOnly = true;
            this.DGV_REPORTE.RowHeadersWidth = 51;
            this.DGV_REPORTE.Size = new System.Drawing.Size(681, 281);
            this.DGV_REPORTE.TabIndex = 7;
            this.DGV_REPORTE.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_REPORTE_CellContentClick);
            this.DGV_REPORTE.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_REPORTE_CellMouseDoubleClick);
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.MinimumWidth = 6;
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            this.Producto.Width = 125;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 125;
            // 
            // P_Unitario
            // 
            this.P_Unitario.HeaderText = "P_Unitario";
            this.P_Unitario.MinimumWidth = 6;
            this.P_Unitario.Name = "P_Unitario";
            this.P_Unitario.ReadOnly = true;
            this.P_Unitario.Width = 125;
            // 
            // Descuento
            // 
            this.Descuento.HeaderText = "Descuento";
            this.Descuento.MinimumWidth = 6;
            this.Descuento.Name = "Descuento";
            this.Descuento.ReadOnly = true;
            this.Descuento.Width = 125;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 125;
            // 
            // FormReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(706, 447);
            this.Controls.Add(this.DGV_REPORTE);
            this.Controls.Add(this.Venta);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormReporte";
            this.Text = "FormReporte";
            this.Load += new System.EventHandler(this.FormReporte_Load);
            this.Venta.ResumeLayout(false);
            this.Venta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_REPORTE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LBL_FECHA;
        private System.Windows.Forms.Label LBL_VENDEDOR;
        private System.Windows.Forms.Label LBL_CLIENTE;
        private System.Windows.Forms.GroupBox Venta;
        private System.Windows.Forms.DataGridView DGV_REPORTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_Unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        public System.Windows.Forms.TextBox TXT_FECHA;
        public System.Windows.Forms.TextBox TXT_VENDEDOR;
        public System.Windows.Forms.TextBox TXT_CLIENTE;
    }
}