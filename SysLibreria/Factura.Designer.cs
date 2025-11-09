namespace SysLibreria
{
    partial class Factura
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
            this.components = new System.ComponentModel.Container();
            this.LBL_NPRODUCTO = new System.Windows.Forms.Label();
            this.TXT_BPRUCTO = new System.Windows.Forms.TextBox();
            this.LBL_NOMBRE = new System.Windows.Forms.Label();
            this.TXT_NOMBRE_CLIENTE = new System.Windows.Forms.TextBox();
            this.TXT_DIRECCION_CLIENTE = new System.Windows.Forms.Label();
            this.TXT_DIRECCION = new System.Windows.Forms.TextBox();
            this.LBL_DOCUMENTO = new System.Windows.Forms.Label();
            this.TXT_DOCUMENTO = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LBL_VENDEDOR = new System.Windows.Forms.Label();
            this.TXT_VENDEDOR = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LBL_TPAGO = new System.Windows.Forms.Label();
            this.LBL_MONTO = new System.Windows.Forms.Label();
            this.TXT_MONTO = new System.Windows.Forms.TextBox();
            this.TB_TP = new System.Windows.Forms.ComboBox();
            this.LBL_CAMBIO = new System.Windows.Forms.Label();
            this.TXT_CAMBIO = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_CPAGO = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LBL_CODIGO = new System.Windows.Forms.Label();
            this.TXT_CODIGO = new System.Windows.Forms.TextBox();
            this.DGV_PRODUCTOS = new System.Windows.Forms.DataGridView();
            this.Cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.DGV_DVENTA = new System.Windows.Forms.DataGridView();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdProucto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.LBL_TOTAL = new System.Windows.Forms.Label();
            this.TXT_TOTAL = new System.Windows.Forms.TextBox();
            this.LBL_SUBTOTAL = new System.Windows.Forms.Label();
            this.TXT_SUBTOTAL = new System.Windows.Forms.TextBox();
            this.LBL_IVA = new System.Windows.Forms.Label();
            this.TXT_IVA = new System.Windows.Forms.TextBox();
            this.BTN_GUARDAR = new System.Windows.Forms.Button();
            this.BTN_SALIR = new System.Windows.Forms.Button();
            this.cmsVenta = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eliminarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarCantidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarDescuentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PRODUCTOS)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DVENTA)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.cmsVenta.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBL_NPRODUCTO
            // 
            this.LBL_NPRODUCTO.AutoSize = true;
            this.LBL_NPRODUCTO.Location = new System.Drawing.Point(12, 23);
            this.LBL_NPRODUCTO.Name = "LBL_NPRODUCTO";
            this.LBL_NPRODUCTO.Size = new System.Drawing.Size(44, 13);
            this.LBL_NPRODUCTO.TabIndex = 0;
            this.LBL_NPRODUCTO.Text = "Nombre";
            this.LBL_NPRODUCTO.Click += new System.EventHandler(this.LBL_PRODUCTO_Click);
            // 
            // TXT_BPRUCTO
            // 
            this.TXT_BPRUCTO.Location = new System.Drawing.Point(62, 20);
            this.TXT_BPRUCTO.Name = "TXT_BPRUCTO";
            this.TXT_BPRUCTO.Size = new System.Drawing.Size(148, 20);
            this.TXT_BPRUCTO.TabIndex = 1;
            this.TXT_BPRUCTO.TextChanged += new System.EventHandler(this.TXT_BPRUCTO_TextChanged);
            // 
            // LBL_NOMBRE
            // 
            this.LBL_NOMBRE.AutoSize = true;
            this.LBL_NOMBRE.Location = new System.Drawing.Point(15, 29);
            this.LBL_NOMBRE.Name = "LBL_NOMBRE";
            this.LBL_NOMBRE.Size = new System.Drawing.Size(44, 13);
            this.LBL_NOMBRE.TabIndex = 2;
            this.LBL_NOMBRE.Text = "Nombre";
            // 
            // TXT_NOMBRE_CLIENTE
            // 
            this.TXT_NOMBRE_CLIENTE.Location = new System.Drawing.Point(98, 29);
            this.TXT_NOMBRE_CLIENTE.Name = "TXT_NOMBRE_CLIENTE";
            this.TXT_NOMBRE_CLIENTE.Size = new System.Drawing.Size(250, 20);
            this.TXT_NOMBRE_CLIENTE.TabIndex = 3;
            // 
            // TXT_DIRECCION_CLIENTE
            // 
            this.TXT_DIRECCION_CLIENTE.AutoSize = true;
            this.TXT_DIRECCION_CLIENTE.Location = new System.Drawing.Point(15, 78);
            this.TXT_DIRECCION_CLIENTE.Name = "TXT_DIRECCION_CLIENTE";
            this.TXT_DIRECCION_CLIENTE.Size = new System.Drawing.Size(52, 13);
            this.TXT_DIRECCION_CLIENTE.TabIndex = 4;
            this.TXT_DIRECCION_CLIENTE.Text = "Direccion";
            // 
            // TXT_DIRECCION
            // 
            this.TXT_DIRECCION.Location = new System.Drawing.Point(98, 78);
            this.TXT_DIRECCION.Name = "TXT_DIRECCION";
            this.TXT_DIRECCION.Size = new System.Drawing.Size(250, 20);
            this.TXT_DIRECCION.TabIndex = 5;
            // 
            // LBL_DOCUMENTO
            // 
            this.LBL_DOCUMENTO.AutoSize = true;
            this.LBL_DOCUMENTO.Location = new System.Drawing.Point(15, 123);
            this.LBL_DOCUMENTO.Name = "LBL_DOCUMENTO";
            this.LBL_DOCUMENTO.Size = new System.Drawing.Size(62, 13);
            this.LBL_DOCUMENTO.TabIndex = 6;
            this.LBL_DOCUMENTO.Text = "Documento";
            // 
            // TXT_DOCUMENTO
            // 
            this.TXT_DOCUMENTO.Location = new System.Drawing.Point(98, 123);
            this.TXT_DOCUMENTO.Name = "TXT_DOCUMENTO";
            this.TXT_DOCUMENTO.Size = new System.Drawing.Size(250, 20);
            this.TXT_DOCUMENTO.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TXT_DOCUMENTO);
            this.groupBox1.Controls.Add(this.LBL_DOCUMENTO);
            this.groupBox1.Controls.Add(this.TXT_DIRECCION);
            this.groupBox1.Controls.Add(this.TXT_DIRECCION_CLIENTE);
            this.groupBox1.Controls.Add(this.TXT_NOMBRE_CLIENTE);
            this.groupBox1.Controls.Add(this.LBL_NOMBRE);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 161);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del cliente";
            // 
            // LBL_VENDEDOR
            // 
            this.LBL_VENDEDOR.AutoSize = true;
            this.LBL_VENDEDOR.Location = new System.Drawing.Point(6, 28);
            this.LBL_VENDEDOR.Name = "LBL_VENDEDOR";
            this.LBL_VENDEDOR.Size = new System.Drawing.Size(53, 13);
            this.LBL_VENDEDOR.TabIndex = 9;
            this.LBL_VENDEDOR.Text = "Vendedor";
            this.LBL_VENDEDOR.Click += new System.EventHandler(this.LBL_VENDEDOR_Click);
            // 
            // TXT_VENDEDOR
            // 
            this.TXT_VENDEDOR.Location = new System.Drawing.Point(65, 25);
            this.TXT_VENDEDOR.Name = "TXT_VENDEDOR";
            this.TXT_VENDEDOR.ReadOnly = true;
            this.TXT_VENDEDOR.Size = new System.Drawing.Size(250, 20);
            this.TXT_VENDEDOR.TabIndex = 10;
            this.TXT_VENDEDOR.TextChanged += new System.EventHandler(this.TXT_VENDEDOR_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TXT_VENDEDOR);
            this.groupBox2.Controls.Add(this.LBL_VENDEDOR);
            this.groupBox2.Location = new System.Drawing.Point(449, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(400, 66);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del vendedor";
            // 
            // LBL_TPAGO
            // 
            this.LBL_TPAGO.AutoSize = true;
            this.LBL_TPAGO.Location = new System.Drawing.Point(10, 23);
            this.LBL_TPAGO.Name = "LBL_TPAGO";
            this.LBL_TPAGO.Size = new System.Drawing.Size(70, 13);
            this.LBL_TPAGO.TabIndex = 12;
            this.LBL_TPAGO.Text = "Tipo de pago";
            // 
            // LBL_MONTO
            // 
            this.LBL_MONTO.AutoSize = true;
            this.LBL_MONTO.Location = new System.Drawing.Point(250, 22);
            this.LBL_MONTO.Name = "LBL_MONTO";
            this.LBL_MONTO.Size = new System.Drawing.Size(37, 13);
            this.LBL_MONTO.TabIndex = 14;
            this.LBL_MONTO.Text = "Monto";
            // 
            // TXT_MONTO
            // 
            this.TXT_MONTO.Location = new System.Drawing.Point(290, 16);
            this.TXT_MONTO.Name = "TXT_MONTO";
            this.TXT_MONTO.Size = new System.Drawing.Size(105, 20);
            this.TXT_MONTO.TabIndex = 15;
            this.TXT_MONTO.TextChanged += new System.EventHandler(this.TXT_MONTO_TextChanged);
            // 
            // TB_TP
            // 
            this.TB_TP.FormattingEnabled = true;
            this.TB_TP.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta"});
            this.TB_TP.Location = new System.Drawing.Point(134, 19);
            this.TB_TP.Name = "TB_TP";
            this.TB_TP.Size = new System.Drawing.Size(105, 21);
            this.TB_TP.TabIndex = 16;
            this.TB_TP.Text = "--Seleccionar--";
            // 
            // LBL_CAMBIO
            // 
            this.LBL_CAMBIO.AutoSize = true;
            this.LBL_CAMBIO.Location = new System.Drawing.Point(245, 55);
            this.LBL_CAMBIO.Name = "LBL_CAMBIO";
            this.LBL_CAMBIO.Size = new System.Drawing.Size(42, 13);
            this.LBL_CAMBIO.TabIndex = 17;
            this.LBL_CAMBIO.Text = "Cambio";
            // 
            // TXT_CAMBIO
            // 
            this.TXT_CAMBIO.Location = new System.Drawing.Point(290, 48);
            this.TXT_CAMBIO.Name = "TXT_CAMBIO";
            this.TXT_CAMBIO.ReadOnly = true;
            this.TXT_CAMBIO.Size = new System.Drawing.Size(105, 20);
            this.TXT_CAMBIO.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Comprobante de pago";
            // 
            // TB_CPAGO
            // 
            this.TB_CPAGO.FormattingEnabled = true;
            this.TB_CPAGO.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta"});
            this.TB_CPAGO.Location = new System.Drawing.Point(134, 51);
            this.TB_CPAGO.Name = "TB_CPAGO";
            this.TB_CPAGO.Size = new System.Drawing.Size(105, 21);
            this.TB_CPAGO.TabIndex = 20;
            this.TB_CPAGO.Text = "--Seleccionar--";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TB_CPAGO);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.TXT_CAMBIO);
            this.groupBox3.Controls.Add(this.LBL_CAMBIO);
            this.groupBox3.Controls.Add(this.TB_TP);
            this.groupBox3.Controls.Add(this.TXT_MONTO);
            this.groupBox3.Controls.Add(this.LBL_MONTO);
            this.groupBox3.Controls.Add(this.LBL_TPAGO);
            this.groupBox3.Location = new System.Drawing.Point(449, 86);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(399, 86);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pagos";
            // 
            // LBL_CODIGO
            // 
            this.LBL_CODIGO.AutoSize = true;
            this.LBL_CODIGO.Location = new System.Drawing.Point(216, 23);
            this.LBL_CODIGO.Name = "LBL_CODIGO";
            this.LBL_CODIGO.Size = new System.Drawing.Size(40, 13);
            this.LBL_CODIGO.TabIndex = 22;
            this.LBL_CODIGO.Text = "Codigo";
            // 
            // TXT_CODIGO
            // 
            this.TXT_CODIGO.Location = new System.Drawing.Point(262, 20);
            this.TXT_CODIGO.Name = "TXT_CODIGO";
            this.TXT_CODIGO.Size = new System.Drawing.Size(83, 20);
            this.TXT_CODIGO.TabIndex = 23;
            this.TXT_CODIGO.TextChanged += new System.EventHandler(this.TXT_CODIGO_TextChanged);
            // 
            // DGV_PRODUCTOS
            // 
            this.DGV_PRODUCTOS.AllowUserToAddRows = false;
            this.DGV_PRODUCTOS.AllowUserToDeleteRows = false;
            this.DGV_PRODUCTOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_PRODUCTOS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cod,
            this.Nombre,
            this.Descripcion,
            this.Precio});
            this.DGV_PRODUCTOS.Location = new System.Drawing.Point(15, 56);
            this.DGV_PRODUCTOS.Name = "DGV_PRODUCTOS";
            this.DGV_PRODUCTOS.ReadOnly = true;
            this.DGV_PRODUCTOS.Size = new System.Drawing.Size(364, 138);
            this.DGV_PRODUCTOS.TabIndex = 24;
            this.DGV_PRODUCTOS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_PRODUCTOS_CellContentClick);
            this.DGV_PRODUCTOS.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_PRODUCTOS_CellMouseDoubleClick);
            // 
            // Cod
            // 
            this.Cod.HeaderText = "Cod";
            this.Cod.Name = "Cod";
            this.Cod.ReadOnly = true;
            this.Cod.Width = 30;
            // 
            // Nombre
            // 
            this.Nombre.FillWeight = 75F;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 140;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 50;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.DGV_PRODUCTOS);
            this.groupBox4.Controls.Add(this.TXT_CODIGO);
            this.groupBox4.Controls.Add(this.LBL_CODIGO);
            this.groupBox4.Controls.Add(this.TXT_BPRUCTO);
            this.groupBox4.Controls.Add(this.LBL_NPRODUCTO);
            this.groupBox4.Location = new System.Drawing.Point(15, 184);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(396, 205);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Producto";
            // 
            // DGV_DVENTA
            // 
            this.DGV_DVENTA.AllowUserToAddRows = false;
            this.DGV_DVENTA.AllowUserToDeleteRows = false;
            this.DGV_DVENTA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_DVENTA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.Cantidad,
            this.PUnitario,
            this.Descuento,
            this.Total,
            this.IdProucto});
            this.DGV_DVENTA.Location = new System.Drawing.Point(8, 22);
            this.DGV_DVENTA.Name = "DGV_DVENTA";
            this.DGV_DVENTA.ReadOnly = true;
            this.DGV_DVENTA.Size = new System.Drawing.Size(384, 168);
            this.DGV_DVENTA.TabIndex = 26;
            this.DGV_DVENTA.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_DVENTA_CellClick);
            this.DGV_DVENTA.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_DVENTA_CellMouseDown);
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            this.Producto.Width = 130;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 50;
            // 
            // PUnitario
            // 
            this.PUnitario.HeaderText = "PUnitario";
            this.PUnitario.Name = "PUnitario";
            this.PUnitario.ReadOnly = true;
            this.PUnitario.Width = 40;
            // 
            // Descuento
            // 
            this.Descuento.HeaderText = "Descuento";
            this.Descuento.Name = "Descuento";
            this.Descuento.ReadOnly = true;
            this.Descuento.Width = 75;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 50;
            // 
            // IdProucto
            // 
            this.IdProucto.HeaderText = "IdProucto";
            this.IdProucto.Name = "IdProucto";
            this.IdProucto.ReadOnly = true;
            this.IdProucto.Visible = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.DGV_DVENTA);
            this.groupBox5.Location = new System.Drawing.Point(451, 188);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(406, 200);
            this.groupBox5.TabIndex = 27;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Detalle de la venta";
            // 
            // LBL_TOTAL
            // 
            this.LBL_TOTAL.AutoSize = true;
            this.LBL_TOTAL.Location = new System.Drawing.Point(28, 414);
            this.LBL_TOTAL.Name = "LBL_TOTAL";
            this.LBL_TOTAL.Size = new System.Drawing.Size(31, 13);
            this.LBL_TOTAL.TabIndex = 28;
            this.LBL_TOTAL.Text = "Total";
            // 
            // TXT_TOTAL
            // 
            this.TXT_TOTAL.Location = new System.Drawing.Point(63, 411);
            this.TXT_TOTAL.Name = "TXT_TOTAL";
            this.TXT_TOTAL.ReadOnly = true;
            this.TXT_TOTAL.Size = new System.Drawing.Size(83, 20);
            this.TXT_TOTAL.TabIndex = 29;
            // 
            // LBL_SUBTOTAL
            // 
            this.LBL_SUBTOTAL.AutoSize = true;
            this.LBL_SUBTOTAL.Location = new System.Drawing.Point(169, 414);
            this.LBL_SUBTOTAL.Name = "LBL_SUBTOTAL";
            this.LBL_SUBTOTAL.Size = new System.Drawing.Size(46, 13);
            this.LBL_SUBTOTAL.TabIndex = 30;
            this.LBL_SUBTOTAL.Text = "Subtotal";
            this.LBL_SUBTOTAL.Click += new System.EventHandler(this.label2_Click);
            // 
            // TXT_SUBTOTAL
            // 
            this.TXT_SUBTOTAL.Location = new System.Drawing.Point(221, 411);
            this.TXT_SUBTOTAL.Name = "TXT_SUBTOTAL";
            this.TXT_SUBTOTAL.ReadOnly = true;
            this.TXT_SUBTOTAL.Size = new System.Drawing.Size(83, 20);
            this.TXT_SUBTOTAL.TabIndex = 31;
            // 
            // LBL_IVA
            // 
            this.LBL_IVA.AutoSize = true;
            this.LBL_IVA.Location = new System.Drawing.Point(348, 414);
            this.LBL_IVA.Name = "LBL_IVA";
            this.LBL_IVA.Size = new System.Drawing.Size(24, 13);
            this.LBL_IVA.TabIndex = 32;
            this.LBL_IVA.Text = "IVA";
            // 
            // TXT_IVA
            // 
            this.TXT_IVA.Location = new System.Drawing.Point(378, 411);
            this.TXT_IVA.Name = "TXT_IVA";
            this.TXT_IVA.ReadOnly = true;
            this.TXT_IVA.Size = new System.Drawing.Size(83, 20);
            this.TXT_IVA.TabIndex = 33;
            // 
            // BTN_GUARDAR
            // 
            this.BTN_GUARDAR.Location = new System.Drawing.Point(30, 437);
            this.BTN_GUARDAR.Name = "BTN_GUARDAR";
            this.BTN_GUARDAR.Size = new System.Drawing.Size(192, 27);
            this.BTN_GUARDAR.TabIndex = 34;
            this.BTN_GUARDAR.Text = "Guardar e imprimir";
            this.BTN_GUARDAR.UseVisualStyleBackColor = true;
            this.BTN_GUARDAR.Click += new System.EventHandler(this.BTN_GUARDAR_Click);
            // 
            // BTN_SALIR
            // 
            this.BTN_SALIR.Location = new System.Drawing.Point(234, 437);
            this.BTN_SALIR.Name = "BTN_SALIR";
            this.BTN_SALIR.Size = new System.Drawing.Size(192, 27);
            this.BTN_SALIR.TabIndex = 35;
            this.BTN_SALIR.Text = "Salir";
            this.BTN_SALIR.UseVisualStyleBackColor = true;
            // 
            // cmsVenta
            // 
            this.cmsVenta.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarProductoToolStripMenuItem,
            this.editarCantidadToolStripMenuItem,
            this.editarDescuentoToolStripMenuItem});
            this.cmsVenta.Name = "cmsVenta";
            this.cmsVenta.Size = new System.Drawing.Size(170, 70);
            // 
            // eliminarProductoToolStripMenuItem
            // 
            this.eliminarProductoToolStripMenuItem.Name = "eliminarProductoToolStripMenuItem";
            this.eliminarProductoToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.eliminarProductoToolStripMenuItem.Text = "Eliminar producto";
            this.eliminarProductoToolStripMenuItem.Click += new System.EventHandler(this.eliminarProductoToolStripMenuItem_Click);
            // 
            // editarCantidadToolStripMenuItem
            // 
            this.editarCantidadToolStripMenuItem.Name = "editarCantidadToolStripMenuItem";
            this.editarCantidadToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.editarCantidadToolStripMenuItem.Text = "Editar cantidad";
            this.editarCantidadToolStripMenuItem.Click += new System.EventHandler(this.editarCantidadToolStripMenuItem_Click);
            // 
            // editarDescuentoToolStripMenuItem
            // 
            this.editarDescuentoToolStripMenuItem.Name = "editarDescuentoToolStripMenuItem";
            this.editarDescuentoToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.editarDescuentoToolStripMenuItem.Text = "Editar descuento";
            this.editarDescuentoToolStripMenuItem.Click += new System.EventHandler(this.editarDescuentoToolStripMenuItem_Click);
            // 
            // Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 492);
            this.Controls.Add(this.BTN_SALIR);
            this.Controls.Add(this.BTN_GUARDAR);
            this.Controls.Add(this.TXT_IVA);
            this.Controls.Add(this.LBL_IVA);
            this.Controls.Add(this.TXT_SUBTOTAL);
            this.Controls.Add(this.LBL_SUBTOTAL);
            this.Controls.Add(this.TXT_TOTAL);
            this.Controls.Add(this.LBL_TOTAL);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Factura";
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.Factura_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PRODUCTOS)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DVENTA)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.cmsVenta.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_NPRODUCTO;
        private System.Windows.Forms.TextBox TXT_BPRUCTO;
        private System.Windows.Forms.Label LBL_NOMBRE;
        private System.Windows.Forms.TextBox TXT_NOMBRE_CLIENTE;
        private System.Windows.Forms.Label TXT_DIRECCION_CLIENTE;
        private System.Windows.Forms.TextBox TXT_DIRECCION;
        private System.Windows.Forms.Label LBL_DOCUMENTO;
        private System.Windows.Forms.TextBox TXT_DOCUMENTO;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LBL_VENDEDOR;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label LBL_TPAGO;
        private System.Windows.Forms.Label LBL_MONTO;
        private System.Windows.Forms.TextBox TXT_MONTO;
        private System.Windows.Forms.ComboBox TB_TP;
        private System.Windows.Forms.Label LBL_CAMBIO;
        private System.Windows.Forms.TextBox TXT_CAMBIO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TB_CPAGO;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label LBL_CODIGO;
        private System.Windows.Forms.TextBox TXT_CODIGO;
        private System.Windows.Forms.DataGridView DGV_PRODUCTOS;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView DGV_DVENTA;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label LBL_TOTAL;
        private System.Windows.Forms.TextBox TXT_TOTAL;
        private System.Windows.Forms.Label LBL_SUBTOTAL;
        private System.Windows.Forms.TextBox TXT_SUBTOTAL;
        private System.Windows.Forms.Label LBL_IVA;
        private System.Windows.Forms.TextBox TXT_IVA;
        private System.Windows.Forms.Button BTN_GUARDAR;
        private System.Windows.Forms.Button BTN_SALIR;
        public System.Windows.Forms.TextBox TXT_VENDEDOR;
        private System.Windows.Forms.ContextMenuStrip cmsVenta;
        private System.Windows.Forms.ToolStripMenuItem eliminarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarCantidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarDescuentoToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProucto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
    }
}