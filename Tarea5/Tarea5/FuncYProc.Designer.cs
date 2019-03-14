namespace Tarea5 {
    partial class FuncYProc {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cboOrg = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Congreso en los que ha participado";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(182, 105);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 42);
            this.button2.TabIndex = 1;
            this.button2.Text = "Comparación entre organizaciones";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cboOrg
            // 
            this.cboOrg.FormattingEnabled = true;
            this.cboOrg.Location = new System.Drawing.Point(24, 64);
            this.cboOrg.Name = "cboOrg";
            this.cboOrg.Size = new System.Drawing.Size(277, 21);
            this.cboOrg.TabIndex = 2;
            // 
            // FuncYProc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(324, 205);
            this.Controls.Add(this.cboOrg);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "FuncYProc";
            this.Text = "Funciones y Procedimientos de la BD";
            this.Load += new System.EventHandler(this.FuncYProc_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cboOrg;
    }
}