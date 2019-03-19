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
            this.reslabel = new System.Windows.Forms.Label();
            this.cboOrg2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addorgBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Congreso en los que ha participado";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(182, 126);
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
            this.cboOrg.Location = new System.Drawing.Point(98, 43);
            this.cboOrg.Name = "cboOrg";
            this.cboOrg.Size = new System.Drawing.Size(203, 21);
            this.cboOrg.TabIndex = 2;
            this.cboOrg.Text = "Nombre de la Organización:";
            // 
            // reslabel
            // 
            this.reslabel.AutoSize = true;
            this.reslabel.Location = new System.Drawing.Point(95, 185);
            this.reslabel.Name = "reslabel";
            this.reslabel.Size = new System.Drawing.Size(0, 13);
            this.reslabel.TabIndex = 3;
            this.reslabel.Visible = false;
            // 
            // cboOrg2
            // 
            this.cboOrg2.FormattingEnabled = true;
            this.cboOrg2.Location = new System.Drawing.Point(98, 99);
            this.cboOrg2.Name = "cboOrg2";
            this.cboOrg2.Size = new System.Drawing.Size(203, 21);
            this.cboOrg2.TabIndex = 4;
            this.cboOrg2.Text = "Nombre de la Organización:";
            this.cboOrg2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Organización 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Organización 2";
            this.label2.Visible = false;
            // 
            // addorgBtn
            // 
            this.addorgBtn.Location = new System.Drawing.Point(98, 70);
            this.addorgBtn.Name = "addorgBtn";
            this.addorgBtn.Size = new System.Drawing.Size(133, 23);
            this.addorgBtn.TabIndex = 7;
            this.addorgBtn.Text = "Agregar organización";
            this.addorgBtn.UseVisualStyleBackColor = true;
            this.addorgBtn.Click += new System.EventHandler(this.addorgBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "----------------------";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(233, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "----------------------";
            // 
            // FuncYProc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(324, 205);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addorgBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboOrg2);
            this.Controls.Add(this.reslabel);
            this.Controls.Add(this.cboOrg);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "FuncYProc";
            this.Text = "Funciones y Procedimientos de la BD";
            this.Load += new System.EventHandler(this.FuncYProc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cboOrg;
        private System.Windows.Forms.Label reslabel;
        private System.Windows.Forms.ComboBox cboOrg2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addorgBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}