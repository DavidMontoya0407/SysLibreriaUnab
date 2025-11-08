namespace SysLibreria
{
    partial class AgregarRol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarRol));
            this.LBL_AGG_ROL = new System.Windows.Forms.Label();
            this.TXT_AGG_ROL = new System.Windows.Forms.TextBox();
            this.BTN_AGG_ROL = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LBL_AGG_ROL
            // 
            this.LBL_AGG_ROL.AutoSize = true;
            this.LBL_AGG_ROL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_AGG_ROL.Location = new System.Drawing.Point(160, 56);
            this.LBL_AGG_ROL.Name = "LBL_AGG_ROL";
            this.LBL_AGG_ROL.Size = new System.Drawing.Size(78, 22);
            this.LBL_AGG_ROL.TabIndex = 0;
            this.LBL_AGG_ROL.Text = "Nombre:";
            // 
            // TXT_AGG_ROL
            // 
            this.TXT_AGG_ROL.Location = new System.Drawing.Point(53, 82);
            this.TXT_AGG_ROL.Margin = new System.Windows.Forms.Padding(10, 4, 3, 4);
            this.TXT_AGG_ROL.MinimumSize = new System.Drawing.Size(200, 40);
            this.TXT_AGG_ROL.Name = "TXT_AGG_ROL";
            this.TXT_AGG_ROL.Size = new System.Drawing.Size(300, 40);
            this.TXT_AGG_ROL.TabIndex = 1;
            this.TXT_AGG_ROL.TextChanged += new System.EventHandler(this.TXT_AGG_ROL_TextChanged);
            // 
            // BTN_AGG_ROL
            // 
            this.BTN_AGG_ROL.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BTN_AGG_ROL.FlatAppearance.BorderSize = 2;
            this.BTN_AGG_ROL.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_AGG_ROL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_AGG_ROL.ForeColor = System.Drawing.Color.White;
            this.BTN_AGG_ROL.Location = new System.Drawing.Point(119, 166);
            this.BTN_AGG_ROL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTN_AGG_ROL.Name = "BTN_AGG_ROL";
            this.BTN_AGG_ROL.Size = new System.Drawing.Size(157, 43);
            this.BTN_AGG_ROL.TabIndex = 2;
            this.BTN_AGG_ROL.Text = "GUARDAR";
            this.BTN_AGG_ROL.UseVisualStyleBackColor = false;
            this.BTN_AGG_ROL.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LavenderBlush;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.BTN_AGG_ROL);
            this.groupBox1.Controls.Add(this.LBL_AGG_ROL);
            this.groupBox1.Controls.Add(this.TXT_AGG_ROL);
            this.groupBox1.Location = new System.Drawing.Point(6, 46);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 4, 7, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 6, 4);
            this.groupBox1.Size = new System.Drawing.Size(380, 231);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 41);
            this.panel1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(163, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "ROL";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(164, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // AgregarRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(394, 282);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AgregarRol";
            this.Text = "AgregarRol";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LBL_AGG_ROL;
        private System.Windows.Forms.TextBox TXT_AGG_ROL;
        private System.Windows.Forms.Button BTN_AGG_ROL;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}