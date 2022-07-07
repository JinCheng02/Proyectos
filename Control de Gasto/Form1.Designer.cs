namespace Control_de_Gasto
{
    partial class Form1
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
            this.buttConcepto = new System.Windows.Forms.Button();
            this.comboConcepto = new System.Windows.Forms.ComboBox();
            this.Fecha = new System.Windows.Forms.Label();
            this.groupIngreso = new System.Windows.Forms.GroupBox();
            this.comboCategoria = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateCreada = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.textCantidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttCategoria = new System.Windows.Forms.Button();
            this.buttAgregar = new System.Windows.Forms.Button();
            this.dgvRecords = new System.Windows.Forms.DataGridView();
            this.groupIngreso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // buttConcepto
            // 
            this.buttConcepto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttConcepto.Location = new System.Drawing.Point(264, 86);
            this.buttConcepto.Name = "buttConcepto";
            this.buttConcepto.Size = new System.Drawing.Size(58, 23);
            this.buttConcepto.TabIndex = 0;
            this.buttConcepto.Text = "clic";
            this.buttConcepto.UseVisualStyleBackColor = true;
            this.buttConcepto.Click += new System.EventHandler(this.buttConcepto_Click);
            // 
            // comboConcepto
            // 
            this.comboConcepto.FormattingEnabled = true;
            this.comboConcepto.Location = new System.Drawing.Point(21, 88);
            this.comboConcepto.Name = "comboConcepto";
            this.comboConcepto.Size = new System.Drawing.Size(237, 21);
            this.comboConcepto.TabIndex = 1;
            this.comboConcepto.Click += new System.EventHandler(this.comboConcepto_Click);
            // 
            // Fecha
            // 
            this.Fecha.AutoSize = true;
            this.Fecha.Location = new System.Drawing.Point(18, 28);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(37, 13);
            this.Fecha.TabIndex = 2;
            this.Fecha.Text = "Fecha";
            // 
            // groupIngreso
            // 
            this.groupIngreso.Controls.Add(this.buttAgregar);
            this.groupIngreso.Controls.Add(this.buttCategoria);
            this.groupIngreso.Controls.Add(this.comboCategoria);
            this.groupIngreso.Controls.Add(this.buttConcepto);
            this.groupIngreso.Controls.Add(this.label3);
            this.groupIngreso.Controls.Add(this.dateCreada);
            this.groupIngreso.Controls.Add(this.comboConcepto);
            this.groupIngreso.Controls.Add(this.label2);
            this.groupIngreso.Controls.Add(this.textCantidad);
            this.groupIngreso.Controls.Add(this.label1);
            this.groupIngreso.Controls.Add(this.Fecha);
            this.groupIngreso.Location = new System.Drawing.Point(12, 12);
            this.groupIngreso.Name = "groupIngreso";
            this.groupIngreso.Size = new System.Drawing.Size(756, 214);
            this.groupIngreso.TabIndex = 4;
            this.groupIngreso.TabStop = false;
            this.groupIngreso.Text = "Ingreso - Egreso";
            // 
            // comboCategoria
            // 
            this.comboCategoria.FormattingEnabled = true;
            this.comboCategoria.Location = new System.Drawing.Point(21, 130);
            this.comboCategoria.Name = "comboCategoria";
            this.comboCategoria.Size = new System.Drawing.Size(237, 21);
            this.comboCategoria.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Categoria";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dateCreada
            // 
            this.dateCreada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateCreada.Location = new System.Drawing.Point(21, 44);
            this.dateCreada.Name = "dateCreada";
            this.dateCreada.Size = new System.Drawing.Size(237, 20);
            this.dateCreada.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cantidad";
            // 
            // textCantidad
            // 
            this.textCantidad.Location = new System.Drawing.Point(21, 173);
            this.textCantidad.Name = "textCantidad";
            this.textCantidad.Size = new System.Drawing.Size(121, 20);
            this.textCantidad.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Concepto";
            // 
            // buttCategoria
            // 
            this.buttCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttCategoria.Location = new System.Drawing.Point(264, 128);
            this.buttCategoria.Name = "buttCategoria";
            this.buttCategoria.Size = new System.Drawing.Size(58, 23);
            this.buttCategoria.TabIndex = 11;
            this.buttCategoria.Text = "clic";
            this.buttCategoria.UseVisualStyleBackColor = true;
            this.buttCategoria.Click += new System.EventHandler(this.buttCategoria_Click);
            // 
            // buttAgregar
            // 
            this.buttAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttAgregar.Location = new System.Drawing.Point(148, 170);
            this.buttAgregar.Name = "buttAgregar";
            this.buttAgregar.Size = new System.Drawing.Size(58, 23);
            this.buttAgregar.TabIndex = 12;
            this.buttAgregar.Text = "Agregar";
            this.buttAgregar.UseVisualStyleBackColor = true;
            this.buttAgregar.Click += new System.EventHandler(this.buttAgregar_Click);
            // 
            // dgvRecords
            // 
            this.dgvRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecords.Location = new System.Drawing.Point(12, 232);
            this.dgvRecords.Name = "dgvRecords";
            this.dgvRecords.Size = new System.Drawing.Size(756, 277);
            this.dgvRecords.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 521);
            this.Controls.Add(this.dgvRecords);
            this.Controls.Add(this.groupIngreso);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupIngreso.ResumeLayout(false);
            this.groupIngreso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecords)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttConcepto;
        private System.Windows.Forms.ComboBox comboConcepto;
        private System.Windows.Forms.Label Fecha;
        private System.Windows.Forms.GroupBox groupIngreso;
        private System.Windows.Forms.ComboBox comboCategoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateCreada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textCantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttAgregar;
        private System.Windows.Forms.Button buttCategoria;
        private System.Windows.Forms.DataGridView dgvRecords;
    }
}

