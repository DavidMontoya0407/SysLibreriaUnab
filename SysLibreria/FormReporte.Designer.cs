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
            this.txtIdVenta = new System.Windows.Forms.TextBox();
            this.lblVenta = new System.Windows.Forms.Label();
            this.DGV_REPORTE = new System.Windows.Forms.DataGridView();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_Unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.Label();
            this.TXT_SUBTOTAL = new System.Windows.Forms.TextBox();
            this.LBL_IVA = new System.Windows.Forms.Label();
            this.TXT_IVA = new System.Windows.Forms.TextBox();
            this.LBL_TOTAL = new System.Windows.Forms.Label();
            this.TXT_TOTAL = new System.Windows.Forms.TextBox();
            this.TXT_SALIR = new System.Windows.Forms.Button();
            this.Venta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_REPORTE)).BeginInit();
            this.SuspendLayout();
            // 
            // LBL_FECHA
            // 
            this.LBL_FECHA.AutoSize = true;
            this.LBL_FECHA.Location = new System.Drawing.Point(5, 28);
            this.LBL_FECHA.Name = "LBL_FECHA";
            this.LBL_FECHA.Size = new System.Drawing.Size(41, 15);
            this.LBL_FECHA.TabIndex = 0;
            this.LBL_FECHA.Text = "Fecha";
            // 
            // TXT_FECHA
            // 
            this.TXT_FECHA.Location = new System.Drawing.Point(46, 20);
            this.TXT_FECHA.Multiline = true;
            this.TXT_FECHA.Name = "TXT_FECHA";
            this.TXT_FECHA.ReadOnly = true;
            this.TXT_FECHA.Size = new System.Drawing.Size(114, 20);
            this.TXT_FECHA.TabIndex = 1;
            // 
            // LBL_VENDEDOR
            // 
            this.LBL_VENDEDOR.AutoSize = true;
            this.LBL_VENDEDOR.Location = new System.Drawing.Point(229, 23);
            this.LBL_VENDEDOR.Name = "LBL_VENDEDOR";
            this.LBL_VENDEDOR.Size = new System.Drawing.Size(60, 15);
            this.LBL_VENDEDOR.TabIndex = 2;
            this.LBL_VENDEDOR.Text = "Vendedor";
            // 
            // TXT_VENDEDOR
            // 
            this.TXT_VENDEDOR.Location = new System.Drawing.Point(288, 18);
            this.TXT_VENDEDOR.Name = "TXT_VENDEDOR";
            this.TXT_VENDEDOR.ReadOnly = true;
            this.TXT_VENDEDOR.Size = new System.Drawing.Size(160, 21);
            this.TXT_VENDEDOR.TabIndex = 3;
            // 
            // LBL_CLIENTE
            // 
            this.LBL_CLIENTE.AutoSize = true;
            this.LBL_CLIENTE.Location = new System.Drawing.Point(5, 68);
            this.LBL_CLIENTE.Name = "LBL_CLIENTE";
            this.LBL_CLIENTE.Size = new System.Drawing.Size(45, 15);
            this.LBL_CLIENTE.TabIndex = 4;
            this.LBL_CLIENTE.Text = "Cliente";
            // 
            // TXT_CLIENTE
            // 
            this.TXT_CLIENTE.Location = new System.Drawing.Point(46, 63);
            this.TXT_CLIENTE.Multiline = true;
            this.TXT_CLIENTE.Name = "TXT_CLIENTE";
            this.TXT_CLIENTE.ReadOnly = true;
            this.TXT_CLIENTE.Size = new System.Drawing.Size(114, 20);
            this.TXT_CLIENTE.TabIndex = 5;
            // 
            // Venta
            // 
            this.Venta.BackColor = System.Drawing.Color.LavenderBlush;
            this.Venta.Controls.Add(this.txtIdVenta);
            this.Venta.Controls.Add(this.lblVenta);
            this.Venta.Controls.Add(this.TXT_CLIENTE);
            this.Venta.Controls.Add(this.LBL_CLIENTE);
            this.Venta.Controls.Add(this.TXT_VENDEDOR);
            this.Venta.Controls.Add(this.LBL_VENDEDOR);
            this.Venta.Controls.Add(this.TXT_FECHA);
            this.Venta.Controls.Add(this.LBL_FECHA);
            this.Venta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Venta.Location = new System.Drawing.Point(13, 14);
            this.Venta.Name = "Venta";
            this.Venta.Size = new System.Drawing.Size(508, 105);
            this.Venta.TabIndex = 6;
            this.Venta.TabStop = false;
            this.Venta.Text = "Venta";
            this.Venta.Enter += new System.EventHandler(this.Venta_Enter);
            // 
            // txtIdVenta
            // 
            this.txtIdVenta.Location = new System.Drawing.Point(288, 63);
            this.txtIdVenta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIdVenta.Name = "txtIdVenta";
            this.txtIdVenta.ReadOnly = true;
            this.txtIdVenta.Size = new System.Drawing.Size(160, 21);
            this.txtIdVenta.TabIndex = 7;
            // 
            // lblVenta
            // 
            this.lblVenta.AutoSize = true;
            this.lblVenta.Location = new System.Drawing.Point(229, 68);
            this.lblVenta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVenta.Name = "lblVenta";
            this.lblVenta.Size = new System.Drawing.Size(53, 15);
            this.lblVenta.TabIndex = 6;
            this.lblVenta.Text = "ID Venta";
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
            this.DGV_REPORTE.Location = new System.Drawing.Point(10, 125);
            this.DGV_REPORTE.Name = "DGV_REPORTE";
            this.DGV_REPORTE.ReadOnly = true;
            this.DGV_REPORTE.RowHeadersWidth = 51;
            this.DGV_REPORTE.Size = new System.Drawing.Size(511, 156);
            this.DGV_REPORTE.TabIndex = 7;
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
            // SubTotal
            // 
            this.SubTotal.AutoSize = true;
            this.SubTotal.Location = new System.Drawing.Point(18, 290);
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.Size = new System.Drawing.Size(50, 13);
            this.SubTotal.TabIndex = 8;
            this.SubTotal.Text = "SubTotal";
            // 
            // TXT_SUBTOTAL
            // 
            this.TXT_SUBTOTAL.Location = new System.Drawing.Point(74, 287);
            this.TXT_SUBTOTAL.Name = "TXT_SUBTOTAL";
            this.TXT_SUBTOTAL.ReadOnly = true;
            this.TXT_SUBTOTAL.Size = new System.Drawing.Size(110, 20);
            this.TXT_SUBTOTAL.TabIndex = 9;
            // 
            // LBL_IVA
            // 
            this.LBL_IVA.AutoSize = true;
            this.LBL_IVA.Location = new System.Drawing.Point(190, 290);
            this.LBL_IVA.Name = "LBL_IVA";
            this.LBL_IVA.Size = new System.Drawing.Size(24, 13);
            this.LBL_IVA.TabIndex = 10;
            this.LBL_IVA.Text = "IVA";
            // 
            // TXT_IVA
            // 
            this.TXT_IVA.Location = new System.Drawing.Point(220, 287);
            this.TXT_IVA.Name = "TXT_IVA";
            this.TXT_IVA.ReadOnly = true;
            this.TXT_IVA.Size = new System.Drawing.Size(110, 20);
            this.TXT_IVA.TabIndex = 11;
            // 
            // LBL_TOTAL
            // 
            this.LBL_TOTAL.AutoSize = true;
            this.LBL_TOTAL.Location = new System.Drawing.Point(336, 294);
            this.LBL_TOTAL.Name = "LBL_TOTAL";
            this.LBL_TOTAL.Size = new System.Drawing.Size(31, 13);
            this.LBL_TOTAL.TabIndex = 12;
            this.LBL_TOTAL.Text = "Total";
            // 
            // TXT_TOTAL
            // 
            this.TXT_TOTAL.Location = new System.Drawing.Point(373, 287);
            this.TXT_TOTAL.Name = "TXT_TOTAL";
            this.TXT_TOTAL.ReadOnly = true;
            this.TXT_TOTAL.Size = new System.Drawing.Size(110, 20);
            this.TXT_TOTAL.TabIndex = 13;
            // 
            // TXT_SALIR
            // 
            this.TXT_SALIR.Location = new System.Drawing.Point(315, 324);
            this.TXT_SALIR.Name = "TXT_SALIR";
            this.TXT_SALIR.Size = new System.Drawing.Size(186, 32);
            this.TXT_SALIR.TabIndex = 14;
            this.TXT_SALIR.Text = " Salir";
            this.TXT_SALIR.UseVisualStyleBackColor = true;
            this.TXT_SALIR.Click += new System.EventHandler(this.TXT_SALIR_Click);
            // 
            // FormReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(530, 363);
            this.Controls.Add(this.TXT_SALIR);
            this.Controls.Add(this.TXT_TOTAL);
            this.Controls.Add(this.LBL_TOTAL);
            this.Controls.Add(this.TXT_IVA);
            this.Controls.Add(this.LBL_IVA);
            this.Controls.Add(this.TXT_SUBTOTAL);
            this.Controls.Add(this.SubTotal);
            this.Controls.Add(this.DGV_REPORTE);
            this.Controls.Add(this.Venta);
            this.Name = "FormReporte";
            this.Text = "FormReporte";
            this.Load += new System.EventHandler(this.FormReporte_Load);
            this.Venta.ResumeLayout(false);
            this.Venta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_REPORTE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TextBox txtIdVenta;
        private System.Windows.Forms.Label lblVenta;
        private System.Windows.Forms.Label SubTotal;
        private System.Windows.Forms.TextBox TXT_SUBTOTAL;
        private System.Windows.Forms.Label LBL_IVA;
        private System.Windows.Forms.TextBox TXT_IVA;
        private System.Windows.Forms.Label LBL_TOTAL;
        private System.Windows.Forms.TextBox TXT_TOTAL;
        private System.Windows.Forms.Button TXT_SALIR;
    }
}