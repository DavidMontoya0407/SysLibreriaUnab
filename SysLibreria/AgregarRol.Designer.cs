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
            this.LBL_AGG_ROL = new System.Windows.Forms.Label();
            this.TXT_AGG_ROL = new System.Windows.Forms.TextBox();
            this.BTN_AGG_ROL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBL_AGG_ROL
            // 
            this.LBL_AGG_ROL.AutoSize = true;
            this.LBL_AGG_ROL.Location = new System.Drawing.Point(13, 13);
            this.LBL_AGG_ROL.Name = "LBL_AGG_ROL";
            this.LBL_AGG_ROL.Size = new System.Drawing.Size(44, 13);
            this.LBL_AGG_ROL.TabIndex = 0;
            this.LBL_AGG_ROL.Text = "Nombre";
            // 
            // TXT_AGG_ROL
            // 
            this.TXT_AGG_ROL.Location = new System.Drawing.Point(71, 11);
            this.TXT_AGG_ROL.Name = "TXT_AGG_ROL";
            this.TXT_AGG_ROL.Size = new System.Drawing.Size(228, 20);
            this.TXT_AGG_ROL.TabIndex = 1;
            // 
            // BTN_AGG_ROL
            // 
            this.BTN_AGG_ROL.Location = new System.Drawing.Point(103, 54);
            this.BTN_AGG_ROL.Name = "BTN_AGG_ROL";
            this.BTN_AGG_ROL.Size = new System.Drawing.Size(131, 34);
            this.BTN_AGG_ROL.TabIndex = 2;
            this.BTN_AGG_ROL.Text = "GUARDAR";
            this.BTN_AGG_ROL.UseVisualStyleBackColor = true;
            this.BTN_AGG_ROL.Click += new System.EventHandler(this.button1_Click);
            // 
            // AgregarRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 185);
            this.Controls.Add(this.BTN_AGG_ROL);
            this.Controls.Add(this.TXT_AGG_ROL);
            this.Controls.Add(this.LBL_AGG_ROL);
            this.Name = "AgregarRol";
            this.Text = "AgregarRol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_AGG_ROL;
        private System.Windows.Forms.TextBox TXT_AGG_ROL;
        private System.Windows.Forms.Button BTN_AGG_ROL;
    }
}