namespace SysLibreria
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.Gp_Menu = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CbProductos = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.CB_MENU = new System.Windows.Forms.ComboBox();
            this.Gp_Menu.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Gp_Menu
            // 
            this.Gp_Menu.BackColor = System.Drawing.Color.LavenderBlush;
            this.Gp_Menu.Controls.Add(this.groupBox2);
            this.Gp_Menu.Controls.Add(this.groupBox1);
            this.Gp_Menu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Gp_Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gp_Menu.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Gp_Menu.Location = new System.Drawing.Point(1, 2);
            this.Gp_Menu.Margin = new System.Windows.Forms.Padding(1, 4, 4, 4);
            this.Gp_Menu.Name = "Gp_Menu";
            this.Gp_Menu.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Gp_Menu.Size = new System.Drawing.Size(808, 427);
            this.Gp_Menu.TabIndex = 0;
            this.Gp_Menu.TabStop = false;
            this.Gp_Menu.Text = "MENÚ";
            this.Gp_Menu.Enter += new System.EventHandler(this.Gp_Menu_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.CbProductos);
            this.groupBox2.Location = new System.Drawing.Point(7, 175);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(639, 150);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 44);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // CbProductos
            // 
            this.CbProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbProductos.FormattingEnabled = true;
            this.CbProductos.Location = new System.Drawing.Point(101, 70);
            this.CbProductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CbProductos.Name = "CbProductos";
            this.CbProductos.Size = new System.Drawing.Size(199, 24);
            this.CbProductos.TabIndex = 2;
            this.CbProductos.Text = "---Inventario de Productos---";
            this.CbProductos.SelectedIndexChanged += new System.EventHandler(this.CbProductos_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.CB_MENU);
            this.groupBox1.Location = new System.Drawing.Point(7, 36);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(639, 133);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(5, 34);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(72, 73);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // CB_MENU
            // 
            this.CB_MENU.CausesValidation = false;
            this.CB_MENU.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.CB_MENU.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_MENU.FormattingEnabled = true;
            this.CB_MENU.Items.AddRange(new object[] {
            "ROLES",
            "USUARIOS",
            "CLIENTES",
            "FACTURA"});
            this.CB_MENU.Location = new System.Drawing.Point(103, 50);
            this.CB_MENU.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CB_MENU.Name = "CB_MENU";
            this.CB_MENU.Size = new System.Drawing.Size(197, 24);
            this.CB_MENU.TabIndex = 0;
            this.CB_MENU.Text = "--Control de personal--";
            this.CB_MENU.UseWaitCursor = true;
            this.CB_MENU.SelectedIndexChanged += new System.EventHandler(this.CB_MENU_SelectedIndexChanged);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(812, 432);
            this.Controls.Add(this.Gp_Menu);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.Gp_Menu.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Gp_Menu;
        private System.Windows.Forms.ComboBox CB_MENU;
        private System.Windows.Forms.ComboBox CbProductos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}