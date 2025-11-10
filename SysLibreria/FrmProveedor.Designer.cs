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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PROVEEDOR)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBL_COD
            // 
            this.LBL_COD.AutoSize = true;
            this.LBL_COD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_COD.Location = new System.Drawing.Point(18, 49);
            this.LBL_COD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_COD.Name = "LBL_COD";
            this.LBL_COD.Size = new System.Drawing.Size(36, 18);
            this.LBL_COD.TabIndex = 0;
            this.LBL_COD.Text = "Cod";
            // 
            // LBL_TELEFONO
            // 
            this.LBL_TELEFONO.AutoSize = true;
            this.LBL_TELEFONO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_TELEFONO.Location = new System.Drawing.Point(18, 122);
            this.LBL_TELEFONO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_TELEFONO.Name = "LBL_TELEFONO";
            this.LBL_TELEFONO.Size = new System.Drawing.Size(66, 18);
            this.LBL_TELEFONO.TabIndex = 1;
            this.LBL_TELEFONO.Text = "Telefono";
            // 
            // LBL_NOMBRE
            // 
            this.LBL_NOMBRE.AutoSize = true;
            this.LBL_NOMBRE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_NOMBRE.Location = new System.Drawing.Point(243, 45);
            this.LBL_NOMBRE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_NOMBRE.Name = "LBL_NOMBRE";
            this.LBL_NOMBRE.Size = new System.Drawing.Size(62, 18);
            this.LBL_NOMBRE.TabIndex = 2;
            this.LBL_NOMBRE.Text = "Nombre";
            this.LBL_NOMBRE.Click += new System.EventHandler(this.LBL_NOMBRE_Click);
            // 
            // LBL_DIRECCION
            // 
            this.LBL_DIRECCION.AutoSize = true;
            this.LBL_DIRECCION.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_DIRECCION.Location = new System.Drawing.Point(243, 122);
            this.LBL_DIRECCION.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_DIRECCION.Name = "LBL_DIRECCION";
            this.LBL_DIRECCION.Size = new System.Drawing.Size(71, 18);
            this.LBL_DIRECCION.TabIndex = 3;
            this.LBL_DIRECCION.Text = "Direccion";
            // 
            // LBL_CORREO
            // 
            this.LBL_CORREO.AutoSize = true;
            this.LBL_CORREO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_CORREO.Location = new System.Drawing.Point(576, 45);
            this.LBL_CORREO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_CORREO.Name = "LBL_CORREO";
            this.LBL_CORREO.Size = new System.Drawing.Size(55, 18);
            this.LBL_CORREO.TabIndex = 4;
            this.LBL_CORREO.Text = "Correo";
            // 
            // TXT_COD
            // 
            this.TXT_COD.Location = new System.Drawing.Point(84, 45);
            this.TXT_COD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT_COD.Name = "TXT_COD";
            this.TXT_COD.ReadOnly = true;
            this.TXT_COD.Size = new System.Drawing.Size(132, 22);
            this.TXT_COD.TabIndex = 5;
            // 
            // TXT_TELEFONO
            // 
            this.TXT_TELEFONO.Location = new System.Drawing.Point(84, 118);
            this.TXT_TELEFONO.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT_TELEFONO.Name = "TXT_TELEFONO";
            this.TXT_TELEFONO.Size = new System.Drawing.Size(132, 22);
            this.TXT_TELEFONO.TabIndex = 6;
            // 
            // TXT_NOMBRE
            // 
            this.TXT_NOMBRE.Location = new System.Drawing.Point(310, 37);
            this.TXT_NOMBRE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT_NOMBRE.Name = "TXT_NOMBRE";
            this.TXT_NOMBRE.Size = new System.Drawing.Size(257, 22);
            this.TXT_NOMBRE.TabIndex = 7;
            // 
            // TXT_DIRECCION
            // 
            this.TXT_DIRECCION.Location = new System.Drawing.Point(310, 118);
            this.TXT_DIRECCION.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT_DIRECCION.Name = "TXT_DIRECCION";
            this.TXT_DIRECCION.Size = new System.Drawing.Size(257, 22);
            this.TXT_DIRECCION.TabIndex = 8;
            // 
            // TXT_CORREO
            // 
            this.TXT_CORREO.Location = new System.Drawing.Point(659, 37);
            this.TXT_CORREO.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT_CORREO.Name = "TXT_CORREO";
            this.TXT_CORREO.Size = new System.Drawing.Size(257, 22);
            this.TXT_CORREO.TabIndex = 9;
            // 
            // DGV_PROVEEDOR
            // 
            this.DGV_PROVEEDOR.AllowUserToAddRows = false;
            this.DGV_PROVEEDOR.AllowUserToDeleteRows = false;
            this.DGV_PROVEEDOR.BackgroundColor = System.Drawing.Color.White;
            this.DGV_PROVEEDOR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_PROVEEDOR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cod,
            this.Nombre,
            this.Telefono,
            this.Direccion,
            this.Correo});
            this.DGV_PROVEEDOR.Location = new System.Drawing.Point(13, 231);
            this.DGV_PROVEEDOR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DGV_PROVEEDOR.Name = "DGV_PROVEEDOR";
            this.DGV_PROVEEDOR.ReadOnly = true;
            this.DGV_PROVEEDOR.RowHeadersWidth = 51;
            this.DGV_PROVEEDOR.Size = new System.Drawing.Size(1008, 276);
            this.DGV_PROVEEDOR.TabIndex = 10;
            this.DGV_PROVEEDOR.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_PROVEEDOR_CellDoubleClick);
            // 
            // Cod
            // 
            this.Cod.HeaderText = "Cod";
            this.Cod.MinimumWidth = 6;
            this.Cod.Name = "Cod";
            this.Cod.ReadOnly = true;
            this.Cod.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 125;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.MinimumWidth = 6;
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            this.Telefono.Width = 125;
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.MinimumWidth = 6;
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            this.Direccion.Width = 125;
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.MinimumWidth = 6;
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            this.Correo.Width = 125;
            // 
            // BTN_GUARDAR
            // 
            this.BTN_GUARDAR.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BTN_GUARDAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_GUARDAR.ForeColor = System.Drawing.Color.White;
            this.BTN_GUARDAR.Location = new System.Drawing.Point(63, 163);
            this.BTN_GUARDAR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTN_GUARDAR.Name = "BTN_GUARDAR";
            this.BTN_GUARDAR.Size = new System.Drawing.Size(184, 26);
            this.BTN_GUARDAR.TabIndex = 11;
            this.BTN_GUARDAR.Text = "Agregar";
            this.BTN_GUARDAR.UseVisualStyleBackColor = false;
            this.BTN_GUARDAR.Click += new System.EventHandler(this.BTN_GUARDAR_Click_1);
            // 
            // BTN_MODIFICAR
            // 
            this.BTN_MODIFICAR.BackColor = System.Drawing.Color.SeaGreen;
            this.BTN_MODIFICAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_MODIFICAR.ForeColor = System.Drawing.Color.White;
            this.BTN_MODIFICAR.Location = new System.Drawing.Point(282, 163);
            this.BTN_MODIFICAR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTN_MODIFICAR.Name = "BTN_MODIFICAR";
            this.BTN_MODIFICAR.Size = new System.Drawing.Size(184, 26);
            this.BTN_MODIFICAR.TabIndex = 12;
            this.BTN_MODIFICAR.Text = "Modificar";
            this.BTN_MODIFICAR.UseVisualStyleBackColor = false;
            this.BTN_MODIFICAR.Click += new System.EventHandler(this.BTN_MODIFICAR_Click);
            // 
            // BTN_ELIMINAR
            // 
            this.BTN_ELIMINAR.BackColor = System.Drawing.Color.Crimson;
            this.BTN_ELIMINAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_ELIMINAR.ForeColor = System.Drawing.Color.White;
            this.BTN_ELIMINAR.Location = new System.Drawing.Point(773, 163);
            this.BTN_ELIMINAR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTN_ELIMINAR.Name = "BTN_ELIMINAR";
            this.BTN_ELIMINAR.Size = new System.Drawing.Size(184, 26);
            this.BTN_ELIMINAR.TabIndex = 13;
            this.BTN_ELIMINAR.Text = "Eliminar";
            this.BTN_ELIMINAR.UseVisualStyleBackColor = false;
            this.BTN_ELIMINAR.Click += new System.EventHandler(this.BTN_ELIMINAR_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LavenderBlush;
            this.groupBox1.Controls.Add(this.BTN_ELIMINAR);
            this.groupBox1.Controls.Add(this.BTN_MODIFICAR);
            this.groupBox1.Controls.Add(this.BTN_GUARDAR);
            this.groupBox1.Controls.Add(this.TXT_CORREO);
            this.groupBox1.Controls.Add(this.TXT_DIRECCION);
            this.groupBox1.Controls.Add(this.TXT_NOMBRE);
            this.groupBox1.Controls.Add(this.TXT_TELEFONO);
            this.groupBox1.Controls.Add(this.TXT_COD);
            this.groupBox1.Controls.Add(this.LBL_CORREO);
            this.groupBox1.Controls.Add(this.LBL_DIRECCION);
            this.groupBox1.Controls.Add(this.LBL_NOMBRE);
            this.groupBox1.Controls.Add(this.LBL_TELEFONO);
            this.groupBox1.Controls.Add(this.LBL_COD);
            this.groupBox1.Location = new System.Drawing.Point(13, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1008, 204);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // FrmProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1025, 513);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DGV_PROVEEDOR);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmProveedor";
            this.Text = "FrmProveedor";
            this.Load += new System.EventHandler(this.FrmProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PROVEEDOR)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.GroupBox groupBox1;
    }
}