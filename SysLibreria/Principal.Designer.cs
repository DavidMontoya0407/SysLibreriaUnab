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
            this.Gp_Menu = new System.Windows.Forms.GroupBox();
            this.CB_MENU = new System.Windows.Forms.ComboBox();
            this.Gp_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gp_Menu
            // 
            this.Gp_Menu.Controls.Add(this.CB_MENU);
            this.Gp_Menu.Location = new System.Drawing.Point(7, 6);
            this.Gp_Menu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Gp_Menu.Name = "Gp_Menu";
            this.Gp_Menu.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Gp_Menu.Size = new System.Drawing.Size(1045, 54);
            this.Gp_Menu.TabIndex = 0;
            this.Gp_Menu.TabStop = false;
            this.Gp_Menu.Text = "Menú";
            // 
            // CB_MENU
            // 
            this.CB_MENU.CausesValidation = false;
            this.CB_MENU.FormattingEnabled = true;
            this.CB_MENU.Items.AddRange(new object[] {
            "ROLES",
            "USUARIOS",
            "CLIENTES"});
            this.CB_MENU.Location = new System.Drawing.Point(63, 17);
            this.CB_MENU.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CB_MENU.Name = "CB_MENU";
            this.CB_MENU.Size = new System.Drawing.Size(167, 24);
            this.CB_MENU.TabIndex = 0;
            this.CB_MENU.Text = "--Control de personal--";
            this.CB_MENU.UseWaitCursor = true;
            this.CB_MENU.SelectedIndexChanged += new System.EventHandler(this.CB_MENU_SelectedIndexChanged);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.Gp_Menu);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.Gp_Menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Gp_Menu;
        private System.Windows.Forms.ComboBox CB_MENU;
    }
}