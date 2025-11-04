namespace SysLibreria
{
    partial class Login
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
            this.LBL_USUARIO = new System.Windows.Forms.Label();
            this.TXT_USUARIO = new System.Windows.Forms.TextBox();
            this.LBL_CONTTRASEÑA = new System.Windows.Forms.Label();
            this.TXT_CONTRASEÑA = new System.Windows.Forms.TextBox();
            this.BTN_INGRESAR = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LBL_USUARIO
            // 
            this.LBL_USUARIO.AutoSize = true;
            this.LBL_USUARIO.Location = new System.Drawing.Point(12, 122);
            this.LBL_USUARIO.Name = "LBL_USUARIO";
            this.LBL_USUARIO.Size = new System.Drawing.Size(46, 13);
            this.LBL_USUARIO.TabIndex = 0;
            this.LBL_USUARIO.Text = "Usuario:";
            this.LBL_USUARIO.Click += new System.EventHandler(this.label1_Click);
            // 
            // TXT_USUARIO
            // 
            this.TXT_USUARIO.Location = new System.Drawing.Point(79, 119);
            this.TXT_USUARIO.Name = "TXT_USUARIO";
            this.TXT_USUARIO.Size = new System.Drawing.Size(193, 20);
            this.TXT_USUARIO.TabIndex = 1;
            this.TXT_USUARIO.TextChanged += new System.EventHandler(this.TXT_USUARIO_TextChanged);
            // 
            // LBL_CONTTRASEÑA
            // 
            this.LBL_CONTTRASEÑA.AutoSize = true;
            this.LBL_CONTTRASEÑA.Location = new System.Drawing.Point(12, 156);
            this.LBL_CONTTRASEÑA.Name = "LBL_CONTTRASEÑA";
            this.LBL_CONTTRASEÑA.Size = new System.Drawing.Size(64, 13);
            this.LBL_CONTTRASEÑA.TabIndex = 2;
            this.LBL_CONTTRASEÑA.Text = "Contraseña:";
            this.LBL_CONTTRASEÑA.Click += new System.EventHandler(this.LBL_CONTTRASEÑA_Click);
            // 
            // TXT_CONTRASEÑA
            // 
            this.TXT_CONTRASEÑA.Location = new System.Drawing.Point(79, 153);
            this.TXT_CONTRASEÑA.Name = "TXT_CONTRASEÑA";
            this.TXT_CONTRASEÑA.Size = new System.Drawing.Size(193, 20);
            this.TXT_CONTRASEÑA.TabIndex = 3;
            // 
            // BTN_INGRESAR
            // 
            this.BTN_INGRESAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BTN_INGRESAR.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BTN_INGRESAR.FlatAppearance.BorderSize = 70;
            this.BTN_INGRESAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.BTN_INGRESAR.Location = new System.Drawing.Point(43, 196);
            this.BTN_INGRESAR.Name = "BTN_INGRESAR";
            this.BTN_INGRESAR.Size = new System.Drawing.Size(229, 38);
            this.BTN_INGRESAR.TabIndex = 4;
            this.BTN_INGRESAR.Text = "Ingresar";
            this.BTN_INGRESAR.UseVisualStyleBackColor = true;
            this.BTN_INGRESAR.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SysLibreria.Properties.Resources.librerialevi2;
            this.pictureBox1.Location = new System.Drawing.Point(104, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 86);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(314, 291);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BTN_INGRESAR);
            this.Controls.Add(this.TXT_CONTRASEÑA);
            this.Controls.Add(this.LBL_CONTTRASEÑA);
            this.Controls.Add(this.TXT_USUARIO);
            this.Controls.Add(this.LBL_USUARIO);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_USUARIO;
        private System.Windows.Forms.TextBox TXT_USUARIO;
        private System.Windows.Forms.Label LBL_CONTTRASEÑA;
        private System.Windows.Forms.TextBox TXT_CONTRASEÑA;
        private System.Windows.Forms.Button BTN_INGRESAR;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}