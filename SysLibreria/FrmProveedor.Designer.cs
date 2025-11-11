namespace SysLibreria
{
    partial class FrmProveedor
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
            this.LBL_COD = new System.Windows.Forms.Label();
            this.LBL_TELEFONO = new System.Windows.Forms.Label();
            this.LBL_NOMBRE = new System.Windows.Forms.Label();
            this.LBL_DIRECCION = new System.Windows.Forms.Label();
            this.LBL_CORREO = new System.Windows.Forms.Label();
            this.TXT_COD = new System.Windows.Forms.TextBox();
            this.TXT_TELEFONO = new System.Windows.Forms.TextBox();
            this.TXT_NOMBRE = new System.Windows.Forms.TextBox();
            this.TXT_DIRECCION = new System.Windows.Forms.TextBox();
            this.TXT_CORREO = new System.Windows.Forms.TextBox();
            this.DGV_PROVEEDOR = new System.Windows.Forms.DataGridView();
            this.Cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTN_GUARDAR = new System.Windows.Forms.Button();
            this.BTN_MODIFICAR = new System.Windows.Forms.Button();
            this.BTN_ELIMINAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PROVEEDOR)).BeginInit();
            this.SuspendLayout();
            // 
            // LBL_COD
            // 
            this.LBL_COD.AutoSize = true;
            this.LBL_COD.Location = new System.Drawing.Point(23, 56);
            this.LBL_COD.Name = "LBL_COD";
            this.LBL_COD.Size = new System.Drawing.Size(26, 13);
            this.LBL_COD.TabIndex = 0;
            this.LBL_COD.Text = "Cod";
            // 
            // LBL_TELEFONO
            // 
            this.LBL_TELEFONO.AutoSize = true;
            this.LBL_TELEFONO.Location = new System.Drawing.Point(23, 115);
            this.LBL_TELEFONO.Name = "LBL_TELEFONO";
            this.LBL_TELEFONO.Size = new System.Drawing.Size(49, 13);
            this.LBL_TELEFONO.TabIndex = 1;
            this.LBL_TELEFONO.Text = "Telefono";
            // 
            // LBL_NOMBRE
            // 
            this.LBL_NOMBRE.AutoSize = true;
            this.LBL_NOMBRE.Location = new System.Drawing.Point(192, 53);
            this.LBL_NOMBRE.Name = "LBL_NOMBRE";
            this.LBL_NOMBRE.Size = new System.Drawing.Size(44, 13);
            this.LBL_NOMBRE.TabIndex = 2;
            this.LBL_NOMBRE.Text = "Nombre";
            this.LBL_NOMBRE.Click += new System.EventHandler(this.LBL_NOMBRE_Click);
            // 
            // LBL_DIRECCION
            // 
            this.LBL_DIRECCION.AutoSize = true;
            this.LBL_DIRECCION.Location = new System.Drawing.Point(192, 115);
            this.LBL_DIRECCION.Name = "LBL_DIRECCION";
            this.LBL_DIRECCION.Size = new System.Drawing.Size(52, 13);
            this.LBL_DIRECCION.TabIndex = 3;
            this.LBL_DIRECCION.Text = "Direccion";
            // 
            // LBL_CORREO
            // 
            this.LBL_CORREO.AutoSize = true;
            this.LBL_CORREO.Location = new System.Drawing.Point(442, 53);
            this.LBL_CORREO.Name = "LBL_CORREO";
            this.LBL_CORREO.Size = new System.Drawing.Size(38, 13);
            this.LBL_CORREO.TabIndex = 4;
            this.LBL_CORREO.Text = "Correo";
            // 
            // TXT_COD
            // 
            this.TXT_COD.Location = new System.Drawing.Point(73, 53);
            this.TXT_COD.Name = "TXT_COD";
            this.TXT_COD.ReadOnly = true;
            this.TXT_COD.Size = new System.Drawing.Size(100, 20);
            this.TXT_COD.TabIndex = 5;
            // 
            // TXT_TELEFONO
            // 
            this.TXT_TELEFONO.Location = new System.Drawing.Point(73, 112);
            this.TXT_TELEFONO.Name = "TXT_TELEFONO";
            this.TXT_TELEFONO.Size = new System.Drawing.Size(100, 20);
            this.TXT_TELEFONO.TabIndex = 6;
            // 
            // TXT_NOMBRE
            // 
            this.TXT_NOMBRE.Location = new System.Drawing.Point(242, 46);
            this.TXT_NOMBRE.Name = "TXT_NOMBRE";
            this.TXT_NOMBRE.Size = new System.Drawing.Size(194, 20);
            this.TXT_NOMBRE.TabIndex = 7;
            // 
            // TXT_DIRECCION
            // 
            this.TXT_DIRECCION.Location = new System.Drawing.Point(242, 108);
            this.TXT_DIRECCION.Name = "TXT_DIRECCION";
            this.TXT_DIRECCION.Size = new System.Drawing.Size(194, 20);
            this.TXT_DIRECCION.TabIndex = 8;
            // 
            // TXT_CORREO
            // 
            this.TXT_CORREO.Location = new System.Drawing.Point(504, 46);
            this.TXT_CORREO.Name = "TXT_CORREO";
            this.TXT_CORREO.Size = new System.Drawing.Size(194, 20);
            this.TXT_CORREO.TabIndex = 9;
            // 
            // DGV_PROVEEDOR
            // 
            this.DGV_PROVEEDOR.AllowUserToAddRows = false;
            this.DGV_PROVEEDOR.AllowUserToDeleteRows = false;
            this.DGV_PROVEEDOR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_PROVEEDOR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cod,
            this.Nombre,
            this.Telefono,
            this.Direccion,
            this.Correo});
            this.DGV_PROVEEDOR.Location = new System.Drawing.Point(28, 182);
            this.DGV_PROVEEDOR.Name = "DGV_PROVEEDOR";
            this.DGV_PROVEEDOR.ReadOnly = true;
            this.DGV_PROVEEDOR.Size = new System.Drawing.Size(739, 224);
            this.DGV_PROVEEDOR.TabIndex = 10;
            this.DGV_PROVEEDOR.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_PROVEEDOR_CellDoubleClick);
            // 
            // Cod
            // 
            this.Cod.HeaderText = "Cod";
            this.Cod.Name = "Cod";
            this.Cod.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            // 
            // BTN_GUARDAR
            // 
            this.BTN_GUARDAR.Location = new System.Drawing.Point(57, 149);
            this.BTN_GUARDAR.Name = "BTN_GUARDAR";
            this.BTN_GUARDAR.Size = new System.Drawing.Size(138, 21);
            this.BTN_GUARDAR.TabIndex = 11;
            this.BTN_GUARDAR.Text = "Agregar";
            this.BTN_GUARDAR.UseVisualStyleBackColor = true;
            this.BTN_GUARDAR.Click += new System.EventHandler(this.BTN_GUARDAR_Click_1);
            // 
            // BTN_MODIFICAR
            // 
            this.BTN_MODIFICAR.Location = new System.Drawing.Point(221, 149);
            this.BTN_MODIFICAR.Name = "BTN_MODIFICAR";
            this.BTN_MODIFICAR.Size = new System.Drawing.Size(138, 21);
            this.BTN_MODIFICAR.TabIndex = 12;
            this.BTN_MODIFICAR.Text = "Modificar";
            this.BTN_MODIFICAR.UseVisualStyleBackColor = true;
            this.BTN_MODIFICAR.Click += new System.EventHandler(this.BTN_MODIFICAR_Click);
            // 
            // BTN_ELIMINAR
            // 
            this.BTN_ELIMINAR.Location = new System.Drawing.Point(386, 149);
            this.BTN_ELIMINAR.Name = "BTN_ELIMINAR";
            this.BTN_ELIMINAR.Size = new System.Drawing.Size(138, 21);
            this.BTN_ELIMINAR.TabIndex = 13;
            this.BTN_ELIMINAR.Text = "Eliminar";
            this.BTN_ELIMINAR.UseVisualStyleBackColor = true;
            this.BTN_ELIMINAR.Click += new System.EventHandler(this.BTN_ELIMINAR_Click_1);
            // 
            // FrmProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTN_ELIMINAR);
            this.Controls.Add(this.BTN_MODIFICAR);
            this.Controls.Add(this.BTN_GUARDAR);
            this.Controls.Add(this.DGV_PROVEEDOR);
            this.Controls.Add(this.TXT_CORREO);
            this.Controls.Add(this.TXT_DIRECCION);
            this.Controls.Add(this.TXT_NOMBRE);
            this.Controls.Add(this.TXT_TELEFONO);
            this.Controls.Add(this.TXT_COD);
            this.Controls.Add(this.LBL_CORREO);
            this.Controls.Add(this.LBL_DIRECCION);
            this.Controls.Add(this.LBL_NOMBRE);
            this.Controls.Add(this.LBL_TELEFONO);
            this.Controls.Add(this.LBL_COD);
            this.Name = "FrmProveedor";
            this.Text = "FrmProveedor";
            this.Load += new System.EventHandler(this.FrmProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PROVEEDOR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_COD;
        private System.Windows.Forms.Label LBL_TELEFONO;
        private System.Windows.Forms.Label LBL_NOMBRE;
        private System.Windows.Forms.Label LBL_DIRECCION;
        private System.Windows.Forms.Label LBL_CORREO;
        private System.Windows.Forms.TextBox TXT_COD;
        private System.Windows.Forms.TextBox TXT_TELEFONO;
        private System.Windows.Forms.TextBox TXT_NOMBRE;
        private System.Windows.Forms.TextBox TXT_DIRECCION;
        private System.Windows.Forms.TextBox TXT_CORREO;
        private System.Windows.Forms.DataGridView DGV_PROVEEDOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.Button BTN_GUARDAR;
        private System.Windows.Forms.Button BTN_MODIFICAR;
        private System.Windows.Forms.Button BTN_ELIMINAR;
    }
}