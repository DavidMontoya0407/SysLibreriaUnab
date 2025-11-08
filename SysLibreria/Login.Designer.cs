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
            this.LBL_USUARIO.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LBL_USUARIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_USUARIO.Location = new System.Drawing.Point(30, 146);
            this.LBL_USUARIO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_USUARIO.Name = "LBL_USUARIO";
            this.LBL_USUARIO.Size = new System.Drawing.Size(64, 18);
            this.LBL_USUARIO.TabIndex = 0;
            this.LBL_USUARIO.Text = "Usuario:";
            this.LBL_USUARIO.Click += new System.EventHandler(this.label1_Click);
            // 
            // TXT_USUARIO
            // 
            this.TXT_USUARIO.Location = new System.Drawing.Point(33, 168);
            this.TXT_USUARIO.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_USUARIO.Name = "TXT_USUARIO";
            this.TXT_USUARIO.Size = new System.Drawing.Size(256, 22);
            this.TXT_USUARIO.TabIndex = 1;
            this.TXT_USUARIO.TextChanged += new System.EventHandler(this.TXT_USUARIO_TextChanged);
            // 
            // LBL_CONTTRASEÑA
            // 
            this.LBL_CONTTRASEÑA.AutoSize = true;
            this.LBL_CONTTRASEÑA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LBL_CONTTRASEÑA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_CONTTRASEÑA.Location = new System.Drawing.Point(30, 203);
            this.LBL_CONTTRASEÑA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_CONTTRASEÑA.Name = "LBL_CONTTRASEÑA";
            this.LBL_CONTTRASEÑA.Size = new System.Drawing.Size(89, 18);
            this.LBL_CONTTRASEÑA.TabIndex = 2;
            this.LBL_CONTTRASEÑA.Text = "Contraseña:";
            this.LBL_CONTTRASEÑA.Click += new System.EventHandler(this.LBL_CONTTRASEÑA_Click);
            // 
            // TXT_CONTRASEÑA
            // 
            this.TXT_CONTRASEÑA.Location = new System.Drawing.Point(33, 225);
            this.TXT_CONTRASEÑA.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_CONTRASEÑA.Name = "TXT_CONTRASEÑA";
            this.TXT_CONTRASEÑA.Size = new System.Drawing.Size(256, 22);
            this.TXT_CONTRASEÑA.TabIndex = 3;
            // 
            // BTN_INGRESAR
            // 
            this.BTN_INGRESAR.BackColor = System.Drawing.Color.Yellow;
            this.BTN_INGRESAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BTN_INGRESAR.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BTN_INGRESAR.FlatAppearance.BorderSize = 70;
            this.BTN_INGRESAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.BTN_INGRESAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_INGRESAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_INGRESAR.ForeColor = System.Drawing.Color.White;
            this.BTN_INGRESAR.Location = new System.Drawing.Point(33, 287);
            this.BTN_INGRESAR.Margin = new System.Windows.Forms.Padding(0);
            this.BTN_INGRESAR.Name = "BTN_INGRESAR";
            this.BTN_INGRESAR.Size = new System.Drawing.Size(256, 33);
            this.BTN_INGRESAR.TabIndex = 4;
            this.BTN_INGRESAR.Text = "Ingresar";
            this.BTN_INGRESAR.UseVisualStyleBackColor = false;
            this.BTN_INGRESAR.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::SysLibreria.Properties.Resources.librerialevi2;
            this.pictureBox1.Location = new System.Drawing.Point(92, 24);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 106);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(326, 358);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BTN_INGRESAR);
            this.Controls.Add(this.TXT_CONTRASEÑA);
            this.Controls.Add(this.LBL_CONTTRASEÑA);
            this.Controls.Add(this.TXT_USUARIO);
            this.Controls.Add(this.LBL_USUARIO);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
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