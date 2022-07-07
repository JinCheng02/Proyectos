namespace CRUD___CEDULA_FORM
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
            this.DGV = new System.Windows.Forms.DataGridView();
            this.buttNuevo = new System.Windows.Forms.Button();
            this.buttGuardar = new System.Windows.Forms.Button();
            this.buttCancelar = new System.Windows.Forms.Button();
            this.GBCEDULA = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.boxPicture = new System.Windows.Forms.TextBox();
            this.buttIngresar = new System.Windows.Forms.Button();
            this.boxExpira = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.boxOcupacion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.boxNombre = new System.Windows.Forms.TextBox();
            this.boxEstado = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.boxSangre = new System.Windows.Forms.ComboBox();
            this.boxNacionalidad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttFem = new System.Windows.Forms.RadioButton();
            this.buttMas = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.dateNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.boxNacimiento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Picture = new System.Windows.Forms.PictureBox();
            this.boxMatricula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.GBCEDULA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV
            // 
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Location = new System.Drawing.Point(419, 12);
            this.DGV.Name = "DGV";
            this.DGV.Size = new System.Drawing.Size(369, 457);
            this.DGV.TabIndex = 0;
            // 
            // buttNuevo
            // 
            this.buttNuevo.ForeColor = System.Drawing.Color.Green;
            this.buttNuevo.Location = new System.Drawing.Point(12, 410);
            this.buttNuevo.Name = "buttNuevo";
            this.buttNuevo.Size = new System.Drawing.Size(75, 59);
            this.buttNuevo.TabIndex = 1;
            this.buttNuevo.Text = "Nuevo";
            this.buttNuevo.UseVisualStyleBackColor = true;
            this.buttNuevo.Click += new System.EventHandler(this.buttNuevo_Click);
            // 
            // buttGuardar
            // 
            this.buttGuardar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttGuardar.Location = new System.Drawing.Point(93, 410);
            this.buttGuardar.Name = "buttGuardar";
            this.buttGuardar.Size = new System.Drawing.Size(75, 59);
            this.buttGuardar.TabIndex = 2;
            this.buttGuardar.Text = "Guardar";
            this.buttGuardar.UseVisualStyleBackColor = true;
            this.buttGuardar.Click += new System.EventHandler(this.buttGuardar_Click);
            // 
            // buttCancelar
            // 
            this.buttCancelar.ForeColor = System.Drawing.Color.Crimson;
            this.buttCancelar.Location = new System.Drawing.Point(335, 410);
            this.buttCancelar.Name = "buttCancelar";
            this.buttCancelar.Size = new System.Drawing.Size(75, 59);
            this.buttCancelar.TabIndex = 3;
            this.buttCancelar.Text = "Cancelar";
            this.buttCancelar.UseVisualStyleBackColor = true;
            this.buttCancelar.Click += new System.EventHandler(this.buttCancelar_Click);
            // 
            // GBCEDULA
            // 
            this.GBCEDULA.Controls.Add(this.label11);
            this.GBCEDULA.Controls.Add(this.boxPicture);
            this.GBCEDULA.Controls.Add(this.buttIngresar);
            this.GBCEDULA.Controls.Add(this.boxExpira);
            this.GBCEDULA.Controls.Add(this.label10);
            this.GBCEDULA.Controls.Add(this.boxOcupacion);
            this.GBCEDULA.Controls.Add(this.label9);
            this.GBCEDULA.Controls.Add(this.boxNombre);
            this.GBCEDULA.Controls.Add(this.boxEstado);
            this.GBCEDULA.Controls.Add(this.label8);
            this.GBCEDULA.Controls.Add(this.label7);
            this.GBCEDULA.Controls.Add(this.boxSangre);
            this.GBCEDULA.Controls.Add(this.boxNacionalidad);
            this.GBCEDULA.Controls.Add(this.label6);
            this.GBCEDULA.Controls.Add(this.buttFem);
            this.GBCEDULA.Controls.Add(this.buttMas);
            this.GBCEDULA.Controls.Add(this.label5);
            this.GBCEDULA.Controls.Add(this.dateNacimiento);
            this.GBCEDULA.Controls.Add(this.label4);
            this.GBCEDULA.Controls.Add(this.boxNacimiento);
            this.GBCEDULA.Controls.Add(this.label3);
            this.GBCEDULA.Controls.Add(this.label2);
            this.GBCEDULA.Controls.Add(this.Picture);
            this.GBCEDULA.Controls.Add(this.boxMatricula);
            this.GBCEDULA.Controls.Add(this.label1);
            this.GBCEDULA.Enabled = false;
            this.GBCEDULA.Location = new System.Drawing.Point(12, 12);
            this.GBCEDULA.Name = "GBCEDULA";
            this.GBCEDULA.Size = new System.Drawing.Size(398, 392);
            this.GBCEDULA.TabIndex = 4;
            this.GBCEDULA.TabStop = false;
            this.GBCEDULA.Text = "Cedula de Identidad";
            this.GBCEDULA.Enter += new System.EventHandler(this.GBCEDULA_Enter);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 267);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Nombre:";
            // 
            // boxPicture
            // 
            this.boxPicture.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.boxPicture.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.boxPicture.Enabled = false;
            this.boxPicture.Location = new System.Drawing.Point(11, 207);
            this.boxPicture.Name = "boxPicture";
            this.boxPicture.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.boxPicture.Size = new System.Drawing.Size(119, 13);
            this.boxPicture.TabIndex = 23;
            // 
            // buttIngresar
            // 
            this.buttIngresar.Location = new System.Drawing.Point(11, 227);
            this.buttIngresar.Name = "buttIngresar";
            this.buttIngresar.Size = new System.Drawing.Size(119, 37);
            this.buttIngresar.TabIndex = 22;
            this.buttIngresar.Text = "Ingresa su Foto Personal";
            this.buttIngresar.UseVisualStyleBackColor = true;
            this.buttIngresar.Click += new System.EventHandler(this.buttIngresar_Click);
            // 
            // boxExpira
            // 
            this.boxExpira.Enabled = false;
            this.boxExpira.Location = new System.Drawing.Point(139, 362);
            this.boxExpira.Name = "boxExpira";
            this.boxExpira.Size = new System.Drawing.Size(253, 20);
            this.boxExpira.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(139, 346);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Fecha de Expiración:";
            // 
            // boxOcupacion
            // 
            this.boxOcupacion.Location = new System.Drawing.Point(139, 323);
            this.boxOcupacion.Name = "boxOcupacion";
            this.boxOcupacion.Size = new System.Drawing.Size(253, 20);
            this.boxOcupacion.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(136, 307);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Ocupación:";
            // 
            // boxNombre
            // 
            this.boxNombre.Location = new System.Drawing.Point(11, 283);
            this.boxNombre.Multiline = true;
            this.boxNombre.Name = "boxNombre";
            this.boxNombre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.boxNombre.Size = new System.Drawing.Size(119, 32);
            this.boxNombre.TabIndex = 8;
            this.boxNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // boxEstado
            // 
            this.boxEstado.FormattingEnabled = true;
            this.boxEstado.Items.AddRange(new object[] {
            "Soltero",
            "Casado",
            "Divorciado",
            "Separación en proceso judicial",
            "Viudo",
            "Concubinato"});
            this.boxEstado.Location = new System.Drawing.Point(139, 283);
            this.boxEstado.Name = "boxEstado";
            this.boxEstado.Size = new System.Drawing.Size(253, 21);
            this.boxEstado.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(136, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Estado Civil:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(136, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Sangre:";
            // 
            // boxSangre
            // 
            this.boxSangre.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.boxSangre.FormattingEnabled = true;
            this.boxSangre.Items.AddRange(new object[] {
            "Tipo A",
            "Tipo B",
            "Tipo AB",
            "Tipo O",
            "No se sabe"});
            this.boxSangre.Location = new System.Drawing.Point(139, 243);
            this.boxSangre.Name = "boxSangre";
            this.boxSangre.Size = new System.Drawing.Size(253, 21);
            this.boxSangre.TabIndex = 2;
            // 
            // boxNacionalidad
            // 
            this.boxNacionalidad.Location = new System.Drawing.Point(139, 180);
            this.boxNacionalidad.Name = "boxNacionalidad";
            this.boxNacionalidad.Size = new System.Drawing.Size(253, 20);
            this.boxNacionalidad.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(136, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Sexo: ";
            // 
            // buttFem
            // 
            this.buttFem.AutoSize = true;
            this.buttFem.Location = new System.Drawing.Point(270, 207);
            this.buttFem.Name = "buttFem";
            this.buttFem.Size = new System.Drawing.Size(71, 17);
            this.buttFem.TabIndex = 5;
            this.buttFem.TabStop = true;
            this.buttFem.Text = "Femenino";
            this.buttFem.UseVisualStyleBackColor = true;
            // 
            // buttMas
            // 
            this.buttMas.AutoSize = true;
            this.buttMas.Location = new System.Drawing.Point(179, 207);
            this.buttMas.Name = "buttMas";
            this.buttMas.Size = new System.Drawing.Size(73, 17);
            this.buttMas.TabIndex = 4;
            this.buttMas.TabStop = true;
            this.buttMas.Text = "Masculino";
            this.buttMas.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(136, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nacionalidad:";
            // 
            // dateNacimiento
            // 
            this.dateNacimiento.Location = new System.Drawing.Point(139, 141);
            this.dateNacimiento.Name = "dateNacimiento";
            this.dateNacimiento.Size = new System.Drawing.Size(253, 20);
            this.dateNacimiento.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Fecha de Nacimiento:";
            // 
            // boxNacimiento
            // 
            this.boxNacimiento.Location = new System.Drawing.Point(139, 102);
            this.boxNacimiento.Name = "boxNacimiento";
            this.boxNacimiento.Size = new System.Drawing.Size(253, 20);
            this.boxNacimiento.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Lugar de Nacimiento(Ciudad, País):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Numero de cedula:";
            // 
            // Picture
            // 
            this.Picture.Location = new System.Drawing.Point(11, 61);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(119, 161);
            this.Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picture.TabIndex = 6;
            this.Picture.TabStop = false;
            // 
            // boxMatricula
            // 
            this.boxMatricula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.boxMatricula.Enabled = false;
            this.boxMatricula.Location = new System.Drawing.Point(239, 61);
            this.boxMatricula.Name = "boxMatricula";
            this.boxMatricula.Size = new System.Drawing.Size(153, 13);
            this.boxMatricula.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "CEDULA DE IDENTIDAD";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 481);
            this.Controls.Add(this.GBCEDULA);
            this.Controls.Add(this.buttCancelar);
            this.Controls.Add(this.buttGuardar);
            this.Controls.Add(this.buttNuevo);
            this.Controls.Add(this.DGV);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.GBCEDULA.ResumeLayout(false);
            this.GBCEDULA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Button buttNuevo;
        private System.Windows.Forms.Button buttGuardar;
        private System.Windows.Forms.Button buttCancelar;
        private System.Windows.Forms.GroupBox GBCEDULA;
        private System.Windows.Forms.TextBox boxNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Picture;
        private System.Windows.Forms.TextBox boxMatricula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox boxSangre;
        private System.Windows.Forms.DateTimePicker dateNacimiento;
        private System.Windows.Forms.RadioButton buttMas;
        private System.Windows.Forms.RadioButton buttFem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox boxNacionalidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox boxNacimiento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox boxExpira;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox boxOcupacion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox boxEstado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttIngresar;
        private System.Windows.Forms.TextBox boxPicture;
        private System.Windows.Forms.Label label11;
    }
}

