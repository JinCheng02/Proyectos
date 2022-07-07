namespace Control_de_Gasto
{
    partial class FormConcept
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
            this.groupConcepto = new System.Windows.Forms.GroupBox();
            this.lblFechaCreada = new System.Windows.Forms.Label();
            this.checkVisible = new System.Windows.Forms.CheckBox();
            this.Descripcion = new System.Windows.Forms.Label();
            this.textDescripcion = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textMatricula = new System.Windows.Forms.TextBox();
            this.buttCancelar = new System.Windows.Forms.Button();
            this.buttGuardar = new System.Windows.Forms.Button();
            this.buttCrear = new System.Windows.Forms.Button();
            this.dgvConcepto = new System.Windows.Forms.DataGridView();
            this.groupConcepto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConcepto)).BeginInit();
            this.SuspendLayout();
            // 
            // groupConcepto
            // 
            this.groupConcepto.Controls.Add(this.lblFechaCreada);
            this.groupConcepto.Controls.Add(this.checkVisible);
            this.groupConcepto.Controls.Add(this.Descripcion);
            this.groupConcepto.Controls.Add(this.textDescripcion);
            this.groupConcepto.Controls.Add(this.Nombre);
            this.groupConcepto.Controls.Add(this.textNombre);
            this.groupConcepto.Controls.Add(this.label1);
            this.groupConcepto.Controls.Add(this.textMatricula);
            this.groupConcepto.Enabled = false;
            this.groupConcepto.Location = new System.Drawing.Point(12, 12);
            this.groupConcepto.Name = "groupConcepto";
            this.groupConcepto.Size = new System.Drawing.Size(297, 303);
            this.groupConcepto.TabIndex = 0;
            this.groupConcepto.TabStop = false;
            this.groupConcepto.Text = "Gestión de Concepto";
            this.groupConcepto.Enter += new System.EventHandler(this.groupConcepto_Enter);
            // 
            // lblFechaCreada
            // 
            this.lblFechaCreada.AutoSize = true;
            this.lblFechaCreada.Location = new System.Drawing.Point(298, 261);
            this.lblFechaCreada.Name = "lblFechaCreada";
            this.lblFechaCreada.Size = new System.Drawing.Size(10, 13);
            this.lblFechaCreada.TabIndex = 7;
            this.lblFechaCreada.Text = "-";
            this.lblFechaCreada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkVisible
            // 
            this.checkVisible.AutoSize = true;
            this.checkVisible.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkVisible.Location = new System.Drawing.Point(13, 280);
            this.checkVisible.Name = "checkVisible";
            this.checkVisible.Size = new System.Drawing.Size(105, 17);
            this.checkVisible.TabIndex = 6;
            this.checkVisible.Text = "Visible al Público";
            this.checkVisible.UseVisualStyleBackColor = true;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSize = true;
            this.Descripcion.Location = new System.Drawing.Point(10, 110);
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(66, 13);
            this.Descripcion.TabIndex = 5;
            this.Descripcion.Text = "Descripción:";
            // 
            // textDescripcion
            // 
            this.textDescripcion.BackColor = System.Drawing.Color.White;
            this.textDescripcion.Location = new System.Drawing.Point(9, 126);
            this.textDescripcion.Multiline = true;
            this.textDescripcion.Name = "textDescripcion";
            this.textDescripcion.Size = new System.Drawing.Size(276, 148);
            this.textDescripcion.TabIndex = 4;
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(10, 71);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(47, 13);
            this.Nombre.TabIndex = 3;
            this.Nombre.Text = "Nombre:";
            // 
            // textNombre
            // 
            this.textNombre.BackColor = System.Drawing.Color.White;
            this.textNombre.Location = new System.Drawing.Point(9, 87);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(276, 20);
            this.textNombre.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(230, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Matrícula:";
            // 
            // textMatricula
            // 
            this.textMatricula.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textMatricula.Enabled = false;
            this.textMatricula.Location = new System.Drawing.Point(190, 44);
            this.textMatricula.Name = "textMatricula";
            this.textMatricula.Size = new System.Drawing.Size(95, 20);
            this.textMatricula.TabIndex = 0;
            this.textMatricula.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttCancelar
            // 
            this.buttCancelar.BackColor = System.Drawing.Color.Maroon;
            this.buttCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttCancelar.Enabled = false;
            this.buttCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttCancelar.ForeColor = System.Drawing.Color.White;
            this.buttCancelar.Location = new System.Drawing.Point(202, 321);
            this.buttCancelar.Name = "buttCancelar";
            this.buttCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttCancelar.TabIndex = 10;
            this.buttCancelar.Text = "Cancelar";
            this.buttCancelar.UseVisualStyleBackColor = false;
            // 
            // buttGuardar
            // 
            this.buttGuardar.BackColor = System.Drawing.Color.SeaGreen;
            this.buttGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttGuardar.Enabled = false;
            this.buttGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttGuardar.ForeColor = System.Drawing.Color.White;
            this.buttGuardar.Location = new System.Drawing.Point(121, 321);
            this.buttGuardar.Name = "buttGuardar";
            this.buttGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttGuardar.TabIndex = 9;
            this.buttGuardar.Text = "Guardar";
            this.buttGuardar.UseVisualStyleBackColor = false;
            this.buttGuardar.Click += new System.EventHandler(this.buttGuardar_Click);
            // 
            // buttCrear
            // 
            this.buttCrear.BackColor = System.Drawing.Color.SteelBlue;
            this.buttCrear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttCrear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttCrear.ForeColor = System.Drawing.Color.White;
            this.buttCrear.Location = new System.Drawing.Point(40, 321);
            this.buttCrear.Name = "buttCrear";
            this.buttCrear.Size = new System.Drawing.Size(75, 23);
            this.buttCrear.TabIndex = 8;
            this.buttCrear.Text = "Crear";
            this.buttCrear.UseVisualStyleBackColor = false;
            this.buttCrear.Click += new System.EventHandler(this.buttCrear_Click);
            // 
            // dgvConcepto
            // 
            this.dgvConcepto.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvConcepto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvConcepto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConcepto.Location = new System.Drawing.Point(315, 12);
            this.dgvConcepto.Name = "dgvConcepto";
            this.dgvConcepto.Size = new System.Drawing.Size(473, 332);
            this.dgvConcepto.TabIndex = 1;
            // 
            // FormConcept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 410);
            this.Controls.Add(this.buttCancelar);
            this.Controls.Add(this.dgvConcepto);
            this.Controls.Add(this.buttGuardar);
            this.Controls.Add(this.buttCrear);
            this.Controls.Add(this.groupConcepto);
            this.Name = "FormConcept";
            this.Text = "Concepto";
            this.groupConcepto.ResumeLayout(false);
            this.groupConcepto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConcepto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupConcepto;
        private System.Windows.Forms.Label lblFechaCreada;
        private System.Windows.Forms.CheckBox checkVisible;
        private System.Windows.Forms.Label Descripcion;
        private System.Windows.Forms.TextBox textDescripcion;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textMatricula;
        private System.Windows.Forms.Button buttCancelar;
        private System.Windows.Forms.Button buttGuardar;
        private System.Windows.Forms.Button buttCrear;
        private System.Windows.Forms.DataGridView dgvConcepto;
    }
}