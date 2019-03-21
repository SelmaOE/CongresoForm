namespace Tarea5
{
    partial class Consulta
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
            this.dtgGeneral = new System.Windows.Forms.DataGridView();
            this.cboAutor = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.dtgCong = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgGeneral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCong)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgGeneral
            // 
            this.dtgGeneral.BackgroundColor = System.Drawing.Color.White;
            this.dtgGeneral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgGeneral.Location = new System.Drawing.Point(31, 42);
            this.dtgGeneral.Name = "dtgGeneral";
            this.dtgGeneral.Size = new System.Drawing.Size(468, 155);
            this.dtgGeneral.TabIndex = 0;
            // 
            // cboAutor
            // 
            this.cboAutor.FormattingEnabled = true;
            this.cboAutor.Location = new System.Drawing.Point(31, 225);
            this.cboAutor.Name = "cboAutor";
            this.cboAutor.Size = new System.Drawing.Size(149, 21);
            this.cboAutor.TabIndex = 1;
            this.cboAutor.Text = "Autor:";
            this.cboAutor.SelectedIndexChanged += new System.EventHandler(this.cboAutor_SelectedIndexChanged);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(327, 225);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(172, 20);
            this.dtpFecha.TabIndex = 2;
            // 
            // dtgCong
            // 
            this.dtgCong.BackgroundColor = System.Drawing.Color.White;
            this.dtgCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCong.Location = new System.Drawing.Point(532, 42);
            this.dtgCong.Name = "dtgCong";
            this.dtgCong.Size = new System.Drawing.Size(176, 155);
            this.dtgCong.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(529, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Congresos por artículo:";
            // 
            // Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(731, 309);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgCong);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.cboAutor);
            this.Controls.Add(this.dtgGeneral);
            this.Name = "Consulta";
            this.Text = "Consulta";
            this.Load += new System.EventHandler(this.Consulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgGeneral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgGeneral;
        private System.Windows.Forms.ComboBox cboAutor;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.DataGridView dtgCong;
        private System.Windows.Forms.Label label1;
    }
}