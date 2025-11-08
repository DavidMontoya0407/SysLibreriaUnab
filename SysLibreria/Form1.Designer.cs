namespace SysLibreria
{
    partial class FormRol
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LBL_ROL = new System.Windows.Forms.Label();
            this.TXT_ROL = new System.Windows.Forms.TextBox();
            this.DGV_ROLES = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTN_AGG_ROL = new System.Windows.Forms.Button();
            this.BTN_ELIMINAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ROLES)).BeginInit();
            this.SuspendLayout();
            // 
            // LBL_ROL
            // 
            this.LBL_ROL.AutoSize = true;
            this.LBL_ROL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_ROL.Location = new System.Drawing.Point(44, 37);
            this.LBL_ROL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_ROL.Name = "LBL_ROL";
            this.LBL_ROL.Size = new System.Drawing.Size(47, 18);
            this.LBL_ROL.TabIndex = 0;
            this.LBL_ROL.Text = "Roles";
            // 
            // TXT_ROL
            // 
            this.TXT_ROL.Location = new System.Drawing.Point(97, 33);
            this.TXT_ROL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT_ROL.Name = "TXT_ROL";
            this.TXT_ROL.Size = new System.Drawing.Size(316, 22);
            this.TXT_ROL.TabIndex = 1;
            this.TXT_ROL.TextChanged += new System.EventHandler(this.TXT_ROL_TextChanged);
            // 
            // DGV_ROLES
            // 
            this.DGV_ROLES.AllowUserToAddRows = false;
            this.DGV_ROLES.AllowUserToDeleteRows = false;
            this.DGV_ROLES.AllowUserToOrderColumns = true;
            this.DGV_ROLES.BackgroundColor = System.Drawing.Color.White;
            this.DGV_ROLES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_ROLES.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre});
            this.DGV_ROLES.Location = new System.Drawing.Point(57, 169);
            this.DGV_ROLES.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DGV_ROLES.Name = "DGV_ROLES";
            this.DGV_ROLES.ReadOnly = true;
            this.DGV_ROLES.RowHeadersWidth = 51;
            this.DGV_ROLES.Size = new System.Drawing.Size(952, 182);
            this.DGV_ROLES.TabIndex = 2;
            this.DGV_ROLES.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_ROLES_CellContentClick);
            this.DGV_ROLES.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_ROLES_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Codigo";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 570;
            // 
            // BTN_AGG_ROL
            // 
            this.BTN_AGG_ROL.BackColor = System.Drawing.Color.RoyalBlue;
            this.BTN_AGG_ROL.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_AGG_ROL.ForeColor = System.Drawing.Color.White;
            this.BTN_AGG_ROL.Location = new System.Drawing.Point(423, 30);
            this.BTN_AGG_ROL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTN_AGG_ROL.Name = "BTN_AGG_ROL";
            this.BTN_AGG_ROL.Size = new System.Drawing.Size(169, 31);
            this.BTN_AGG_ROL.TabIndex = 4;
            this.BTN_AGG_ROL.Text = "AGREGAR";
            this.BTN_AGG_ROL.UseVisualStyleBackColor = false;
            this.BTN_AGG_ROL.Click += new System.EventHandler(this.BTN_AGG_ROL_Click);
            // 
            // BTN_ELIMINAR
            // 
            this.BTN_ELIMINAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BTN_ELIMINAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_ELIMINAR.ForeColor = System.Drawing.Color.White;
            this.BTN_ELIMINAR.Location = new System.Drawing.Point(600, 30);
            this.BTN_ELIMINAR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTN_ELIMINAR.Name = "BTN_ELIMINAR";
            this.BTN_ELIMINAR.Size = new System.Drawing.Size(169, 31);
            this.BTN_ELIMINAR.TabIndex = 5;
            this.BTN_ELIMINAR.Text = "ELIMINAR";
            this.BTN_ELIMINAR.UseVisualStyleBackColor = false;
            this.BTN_ELIMINAR.Click += new System.EventHandler(this.BTN_ELIMINAR_Click);
            // 
            // FormRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.BTN_ELIMINAR);
            this.Controls.Add(this.BTN_AGG_ROL);
            this.Controls.Add(this.DGV_ROLES);
            this.Controls.Add(this.TXT_ROL);
            this.Controls.Add(this.LBL_ROL);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormRol";
            this.Text = "Roles";
            this.Load += new System.EventHandler(this.FormRol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ROLES)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_ROL;
        private System.Windows.Forms.TextBox TXT_ROL;
        private System.Windows.Forms.DataGridView DGV_ROLES;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.Button BTN_AGG_ROL;
        private System.Windows.Forms.Button BTN_ELIMINAR;
    }
}

