namespace SysLibreria
{
    partial class DGV_USUARIO
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
            this.LBL_COD_ROL = new System.Windows.Forms.Label();
            this.COD_ROL = new System.Windows.Forms.TextBox();
            this.NOM_ROL = new System.Windows.Forms.TextBox();
            this.BTN_ROL = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LBL_NOM_USUARIO = new System.Windows.Forms.Label();
            this.TXT_NOMBRE = new System.Windows.Forms.TextBox();
            this.LBL_APELLIDO = new System.Windows.Forms.Label();
            this.TXT_APELLIDOS = new System.Windows.Forms.TextBox();
            this.LBL_USER = new System.Windows.Forms.Label();
            this.TXT_USER = new System.Windows.Forms.TextBox();
            this.LBL_CONTRAEÑA = new System.Windows.Forms.Label();
            this.TXT_CONTRASEÑA = new System.Windows.Forms.TextBox();
            this.CB_ESTADO = new System.Windows.Forms.ComboBox();
            this.LBL_ESTADO = new System.Windows.Forms.Label();
            this.BTN_AGREGAR = new System.Windows.Forms.Button();
            this.BTN_ELIMINAR = new System.Windows.Forms.Button();
            this.LBL_USUARIO = new System.Windows.Forms.Label();
            this.TXT_CO_USER = new System.Windows.Forms.TextBox();
            this.BTN_MODIFICAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // LBL_COD_ROL
            // 
            this.LBL_COD_ROL.AutoSize = true;
            this.LBL_COD_ROL.Location = new System.Drawing.Point(87, 43);
            this.LBL_COD_ROL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_COD_ROL.Name = "LBL_COD_ROL";
            this.LBL_COD_ROL.Size = new System.Drawing.Size(28, 16);
            this.LBL_COD_ROL.TabIndex = 0;
            this.LBL_COD_ROL.Text = "Rol";
            // 
            // COD_ROL
            // 
            this.COD_ROL.Location = new System.Drawing.Point(151, 39);
            this.COD_ROL.Margin = new System.Windows.Forms.Padding(4);
            this.COD_ROL.Name = "COD_ROL";
            this.COD_ROL.ReadOnly = true;
            this.COD_ROL.Size = new System.Drawing.Size(85, 22);
            this.COD_ROL.TabIndex = 1;
            this.COD_ROL.TextChanged += new System.EventHandler(this.COD_ROL_TextChanged);
            // 
            // NOM_ROL
            // 
            this.NOM_ROL.Location = new System.Drawing.Point(245, 39);
            this.NOM_ROL.Margin = new System.Windows.Forms.Padding(4);
            this.NOM_ROL.Name = "NOM_ROL";
            this.NOM_ROL.ReadOnly = true;
            this.NOM_ROL.Size = new System.Drawing.Size(285, 22);
            this.NOM_ROL.TabIndex = 2;
            this.NOM_ROL.TextChanged += new System.EventHandler(this.NOM_ROL_TextChanged);
            // 
            // BTN_ROL
            // 
            this.BTN_ROL.Location = new System.Drawing.Point(540, 31);
            this.BTN_ROL.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_ROL.Name = "BTN_ROL";
            this.BTN_ROL.Size = new System.Drawing.Size(159, 33);
            this.BTN_ROL.TabIndex = 3;
            this.BTN_ROL.Text = "BUSCAR";
            this.BTN_ROL.UseVisualStyleBackColor = true;
            this.BTN_ROL.Click += new System.EventHandler(this.BTN_ROL_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Apellido,
            this.Rol,
            this.IdRol,
            this.Estado});
            this.dataGridView1.Location = new System.Drawing.Point(69, 292);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(991, 213);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellDoubleClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "Codigo";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 150;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 150;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.MinimumWidth = 6;
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            this.Apellido.Width = 150;
            // 
            // Rol
            // 
            this.Rol.HeaderText = "Rol";
            this.Rol.MinimumWidth = 6;
            this.Rol.Name = "Rol";
            this.Rol.ReadOnly = true;
            this.Rol.Width = 150;
            // 
            // IdRol
            // 
            this.IdRol.HeaderText = "IdRol";
            this.IdRol.MinimumWidth = 6;
            this.IdRol.Name = "IdRol";
            this.IdRol.ReadOnly = true;
            this.IdRol.Visible = false;
            this.IdRol.Width = 125;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 125;
            // 
            // LBL_NOM_USUARIO
            // 
            this.LBL_NOM_USUARIO.AutoSize = true;
            this.LBL_NOM_USUARIO.Location = new System.Drawing.Point(87, 94);
            this.LBL_NOM_USUARIO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_NOM_USUARIO.Name = "LBL_NOM_USUARIO";
            this.LBL_NOM_USUARIO.Size = new System.Drawing.Size(63, 16);
            this.LBL_NOM_USUARIO.TabIndex = 5;
            this.LBL_NOM_USUARIO.Text = "Nombres";
            this.LBL_NOM_USUARIO.Click += new System.EventHandler(this.label1_Click);
            // 
            // TXT_NOMBRE
            // 
            this.TXT_NOMBRE.Location = new System.Drawing.Point(151, 90);
            this.TXT_NOMBRE.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_NOMBRE.Name = "TXT_NOMBRE";
            this.TXT_NOMBRE.Size = new System.Drawing.Size(380, 22);
            this.TXT_NOMBRE.TabIndex = 6;
            // 
            // LBL_APELLIDO
            // 
            this.LBL_APELLIDO.AutoSize = true;
            this.LBL_APELLIDO.Location = new System.Drawing.Point(87, 139);
            this.LBL_APELLIDO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_APELLIDO.Name = "LBL_APELLIDO";
            this.LBL_APELLIDO.Size = new System.Drawing.Size(64, 16);
            this.LBL_APELLIDO.TabIndex = 7;
            this.LBL_APELLIDO.Text = "Apellidos";
            // 
            // TXT_APELLIDOS
            // 
            this.TXT_APELLIDOS.Location = new System.Drawing.Point(151, 135);
            this.TXT_APELLIDOS.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_APELLIDOS.Name = "TXT_APELLIDOS";
            this.TXT_APELLIDOS.Size = new System.Drawing.Size(380, 22);
            this.TXT_APELLIDOS.TabIndex = 8;
            // 
            // LBL_USER
            // 
            this.LBL_USER.AutoSize = true;
            this.LBL_USER.Location = new System.Drawing.Point(576, 90);
            this.LBL_USER.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_USER.Name = "LBL_USER";
            this.LBL_USER.Size = new System.Drawing.Size(54, 16);
            this.LBL_USER.TabIndex = 9;
            this.LBL_USER.Text = "Usuario";
            this.LBL_USER.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // TXT_USER
            // 
            this.TXT_USER.Location = new System.Drawing.Point(641, 86);
            this.TXT_USER.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_USER.Name = "TXT_USER";
            this.TXT_USER.Size = new System.Drawing.Size(380, 22);
            this.TXT_USER.TabIndex = 10;
            this.TXT_USER.TextChanged += new System.EventHandler(this.TXT_USER_TextChanged);
            // 
            // LBL_CONTRAEÑA
            // 
            this.LBL_CONTRAEÑA.AutoSize = true;
            this.LBL_CONTRAEÑA.Location = new System.Drawing.Point(552, 144);
            this.LBL_CONTRAEÑA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_CONTRAEÑA.Name = "LBL_CONTRAEÑA";
            this.LBL_CONTRAEÑA.Size = new System.Drawing.Size(76, 16);
            this.LBL_CONTRAEÑA.TabIndex = 11;
            this.LBL_CONTRAEÑA.Text = "Contraseña";
            this.LBL_CONTRAEÑA.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // TXT_CONTRASEÑA
            // 
            this.TXT_CONTRASEÑA.Location = new System.Drawing.Point(641, 139);
            this.TXT_CONTRASEÑA.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_CONTRASEÑA.Name = "TXT_CONTRASEÑA";
            this.TXT_CONTRASEÑA.Size = new System.Drawing.Size(380, 22);
            this.TXT_CONTRASEÑA.TabIndex = 12;
            // 
            // CB_ESTADO
            // 
            this.CB_ESTADO.FormattingEnabled = true;
            this.CB_ESTADO.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.CB_ESTADO.Location = new System.Drawing.Point(151, 190);
            this.CB_ESTADO.Margin = new System.Windows.Forms.Padding(4);
            this.CB_ESTADO.Name = "CB_ESTADO";
            this.CB_ESTADO.Size = new System.Drawing.Size(172, 24);
            this.CB_ESTADO.TabIndex = 13;
            this.CB_ESTADO.Text = "--Selecione el estado--";
            // 
            // LBL_ESTADO
            // 
            this.LBL_ESTADO.AutoSize = true;
            this.LBL_ESTADO.Location = new System.Drawing.Point(87, 193);
            this.LBL_ESTADO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_ESTADO.Name = "LBL_ESTADO";
            this.LBL_ESTADO.Size = new System.Drawing.Size(50, 16);
            this.LBL_ESTADO.TabIndex = 14;
            this.LBL_ESTADO.Text = "Estado";
            // 
            // BTN_AGREGAR
            // 
            this.BTN_AGREGAR.Location = new System.Drawing.Point(373, 185);
            this.BTN_AGREGAR.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_AGREGAR.Name = "BTN_AGREGAR";
            this.BTN_AGREGAR.Size = new System.Drawing.Size(159, 33);
            this.BTN_AGREGAR.TabIndex = 15;
            this.BTN_AGREGAR.Text = "AGREGAR";
            this.BTN_AGREGAR.UseVisualStyleBackColor = true;
            this.BTN_AGREGAR.Click += new System.EventHandler(this.BTN_AGREGAR_Click);
            // 
            // BTN_ELIMINAR
            // 
            this.BTN_ELIMINAR.Location = new System.Drawing.Point(707, 185);
            this.BTN_ELIMINAR.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_ELIMINAR.Name = "BTN_ELIMINAR";
            this.BTN_ELIMINAR.Size = new System.Drawing.Size(159, 33);
            this.BTN_ELIMINAR.TabIndex = 16;
            this.BTN_ELIMINAR.Text = "ELIMINAR";
            this.BTN_ELIMINAR.UseVisualStyleBackColor = true;
            this.BTN_ELIMINAR.Click += new System.EventHandler(this.BTN_ELIMINAR_Click);
            // 
            // LBL_USUARIO
            // 
            this.LBL_USUARIO.AutoSize = true;
            this.LBL_USUARIO.Location = new System.Drawing.Point(721, 43);
            this.LBL_USUARIO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_USUARIO.Name = "LBL_USUARIO";
            this.LBL_USUARIO.Size = new System.Drawing.Size(82, 16);
            this.LBL_USUARIO.TabIndex = 17;
            this.LBL_USUARIO.Text = "Cod Usuario";
            // 
            // TXT_CO_USER
            // 
            this.TXT_CO_USER.Location = new System.Drawing.Point(816, 39);
            this.TXT_CO_USER.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_CO_USER.Name = "TXT_CO_USER";
            this.TXT_CO_USER.ReadOnly = true;
            this.TXT_CO_USER.Size = new System.Drawing.Size(85, 22);
            this.TXT_CO_USER.TabIndex = 18;
            // 
            // BTN_MODIFICAR
            // 
            this.BTN_MODIFICAR.Location = new System.Drawing.Point(540, 185);
            this.BTN_MODIFICAR.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_MODIFICAR.Name = "BTN_MODIFICAR";
            this.BTN_MODIFICAR.Size = new System.Drawing.Size(159, 33);
            this.BTN_MODIFICAR.TabIndex = 19;
            this.BTN_MODIFICAR.Text = "MODIFICAR";
            this.BTN_MODIFICAR.UseVisualStyleBackColor = true;
            this.BTN_MODIFICAR.Click += new System.EventHandler(this.BTN_MODIFICAR_Click);
            // 
            // DGV_USUARIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1165, 554);
            this.Controls.Add(this.BTN_MODIFICAR);
            this.Controls.Add(this.TXT_CO_USER);
            this.Controls.Add(this.LBL_USUARIO);
            this.Controls.Add(this.BTN_ELIMINAR);
            this.Controls.Add(this.BTN_AGREGAR);
            this.Controls.Add(this.LBL_ESTADO);
            this.Controls.Add(this.CB_ESTADO);
            this.Controls.Add(this.TXT_CONTRASEÑA);
            this.Controls.Add(this.LBL_CONTRAEÑA);
            this.Controls.Add(this.TXT_USER);
            this.Controls.Add(this.LBL_USER);
            this.Controls.Add(this.TXT_APELLIDOS);
            this.Controls.Add(this.LBL_APELLIDO);
            this.Controls.Add(this.TXT_NOMBRE);
            this.Controls.Add(this.LBL_NOM_USUARIO);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BTN_ROL);
            this.Controls.Add(this.NOM_ROL);
            this.Controls.Add(this.COD_ROL);
            this.Controls.Add(this.LBL_COD_ROL);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DGV_USUARIO";
            this.Text = "MttoUsuario";
            this.Load += new System.EventHandler(this.MttoUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_COD_ROL;
        private System.Windows.Forms.Button BTN_ROL;
        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.TextBox COD_ROL;
        public System.Windows.Forms.TextBox NOM_ROL;
        private System.Windows.Forms.Label LBL_NOM_USUARIO;
        public System.Windows.Forms.TextBox TXT_NOMBRE;
        private System.Windows.Forms.Label LBL_APELLIDO;
        public System.Windows.Forms.TextBox TXT_APELLIDOS;
        private System.Windows.Forms.Label LBL_USER;
        public System.Windows.Forms.TextBox TXT_USER;
        private System.Windows.Forms.Label LBL_CONTRAEÑA;
        public System.Windows.Forms.TextBox TXT_CONTRASEÑA;
        private System.Windows.Forms.ComboBox CB_ESTADO;
        private System.Windows.Forms.Label LBL_ESTADO;
        private System.Windows.Forms.Button BTN_AGREGAR;
        private System.Windows.Forms.Button BTN_ELIMINAR;
        private System.Windows.Forms.Label LBL_USUARIO;
        public System.Windows.Forms.TextBox TXT_CO_USER;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.Button BTN_MODIFICAR;
    }
}