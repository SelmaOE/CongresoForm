namespace Tarea5 {
    partial class Agregar {
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
            this.cboAutor = new System.Windows.Forms.ComboBox();
            this.cboArticulo = new System.Windows.Forms.ComboBox();
            this.dateCong = new System.Windows.Forms.DateTimePicker();
            this.cboCongreso = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtHor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboAutor
            // 
            this.cboAutor.FormattingEnabled = true;
            this.cboAutor.Location = new System.Drawing.Point(12, 12);
            this.cboAutor.Name = "cboAutor";
            this.cboAutor.Size = new System.Drawing.Size(121, 21);
            this.cboAutor.TabIndex = 0;
            this.cboAutor.Text = "Autor:";
            this.cboAutor.SelectedIndexChanged += new System.EventHandler(this.cboAutor_SelectedIndexChanged);
            // 
            // cboArticulo
            // 
            this.cboArticulo.DropDownHeight = 206;
            this.cboArticulo.FormattingEnabled = true;
            this.cboArticulo.IntegralHeight = false;
            this.cboArticulo.Location = new System.Drawing.Point(12, 55);
            this.cboArticulo.Name = "cboArticulo";
            this.cboArticulo.Size = new System.Drawing.Size(121, 21);
            this.cboArticulo.TabIndex = 1;
            this.cboArticulo.Text = "Artículo:";
            this.cboArticulo.Visible = false;
            // 
            // dateCong
            // 
            this.dateCong.Location = new System.Drawing.Point(158, 56);
            this.dateCong.Name = "dateCong";
            this.dateCong.Size = new System.Drawing.Size(196, 20);
            this.dateCong.TabIndex = 2;
            // 
            // cboCongreso
            // 
            this.cboCongreso.FormattingEnabled = true;
            this.cboCongreso.Location = new System.Drawing.Point(158, 12);
            this.cboCongreso.Name = "cboCongreso";
            this.cboCongreso.Size = new System.Drawing.Size(196, 21);
            this.cboCongreso.TabIndex = 3;
            this.cboCongreso.Text = "Congreso:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(137, 128);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtHor
            // 
            this.txtHor.Location = new System.Drawing.Point(228, 95);
            this.txtHor.Name = "txtHor";
            this.txtHor.Size = new System.Drawing.Size(100, 20);
            this.txtHor.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 6;
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Horario:";
            // 
            // Agregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 179);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHor);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cboCongreso);
            this.Controls.Add(this.dateCong);
            this.Controls.Add(this.cboArticulo);
            this.Controls.Add(this.cboAutor);
            this.Name = "Agregar";
            this.Text = "Agregar";
            this.Load += new System.EventHandler(this.Agregar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboAutor;
        private System.Windows.Forms.ComboBox cboArticulo;
        private System.Windows.Forms.DateTimePicker dateCong;
        private System.Windows.Forms.ComboBox cboCongreso;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtHor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}