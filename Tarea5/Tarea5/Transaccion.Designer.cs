namespace Tarea5
{
    partial class Transaccion
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnAlta = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHor = new System.Windows.Forms.TextBox();
            this.cboCongreso = new System.Windows.Forms.ComboBox();
            this.dateCong = new System.Windows.Forms.DateTimePicker();
            this.cboArticulo = new System.Windows.Forms.ComboBox();
            this.cboAutor = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(521, 202);
            this.dataGridView1.TabIndex = 0;
            // 
            // BtnAlta
            // 
            this.BtnAlta.Location = new System.Drawing.Point(140, 388);
            this.BtnAlta.Name = "BtnAlta";
            this.BtnAlta.Size = new System.Drawing.Size(75, 23);
            this.BtnAlta.TabIndex = 1;
            this.BtnAlta.Text = "Botoncito";
            this.BtnAlta.UseVisualStyleBackColor = true;
            this.BtnAlta.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(411, 388);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 2;
            this.btnActualizar.Text = "Botonsote";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Horario:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtHor
            // 
            this.txtHor.Location = new System.Drawing.Point(324, 341);
            this.txtHor.Name = "txtHor";
            this.txtHor.Size = new System.Drawing.Size(100, 20);
            this.txtHor.TabIndex = 12;
            this.txtHor.TextChanged += new System.EventHandler(this.txtHor_TextChanged);
            // 
            // cboCongreso
            // 
            this.cboCongreso.FormattingEnabled = true;
            this.cboCongreso.Location = new System.Drawing.Point(254, 258);
            this.cboCongreso.Name = "cboCongreso";
            this.cboCongreso.Size = new System.Drawing.Size(196, 21);
            this.cboCongreso.TabIndex = 11;
            this.cboCongreso.Text = "Congreso:";
            this.cboCongreso.SelectedIndexChanged += new System.EventHandler(this.cboCongreso_SelectedIndexChanged);
            // 
            // dateCong
            // 
            this.dateCong.Location = new System.Drawing.Point(254, 302);
            this.dateCong.Name = "dateCong";
            this.dateCong.Size = new System.Drawing.Size(196, 20);
            this.dateCong.TabIndex = 10;
            this.dateCong.ValueChanged += new System.EventHandler(this.dateCong_ValueChanged);
            // 
            // cboArticulo
            // 
            this.cboArticulo.DropDownHeight = 206;
            this.cboArticulo.FormattingEnabled = true;
            this.cboArticulo.IntegralHeight = false;
            this.cboArticulo.Location = new System.Drawing.Point(108, 301);
            this.cboArticulo.Name = "cboArticulo";
            this.cboArticulo.Size = new System.Drawing.Size(121, 21);
            this.cboArticulo.TabIndex = 9;
            this.cboArticulo.Text = "Artículo:";
            this.cboArticulo.Visible = false;
            this.cboArticulo.SelectedIndexChanged += new System.EventHandler(this.cboArticulo_SelectedIndexChanged);
            // 
            // cboAutor
            // 
            this.cboAutor.FormattingEnabled = true;
            this.cboAutor.Location = new System.Drawing.Point(108, 258);
            this.cboAutor.Name = "cboAutor";
            this.cboAutor.Size = new System.Drawing.Size(121, 21);
            this.cboAutor.TabIndex = 8;
            this.cboAutor.Text = "Autor:";
            this.cboAutor.SelectedIndexChanged += new System.EventHandler(this.cboAutor_SelectedIndexChanged);
            // 
            // Transaccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 447);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHor);
            this.Controls.Add(this.cboCongreso);
            this.Controls.Add(this.dateCong);
            this.Controls.Add(this.cboArticulo);
            this.Controls.Add(this.cboAutor);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.BtnAlta);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Transaccion";
            this.Text = "Transaccion";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnAlta;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHor;
        private System.Windows.Forms.ComboBox cboCongreso;
        private System.Windows.Forms.DateTimePicker dateCong;
        private System.Windows.Forms.ComboBox cboArticulo;
        private System.Windows.Forms.ComboBox cboAutor;
    }
}