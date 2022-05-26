namespace Identidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.Picture = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.textNombre = new System.Windows.Forms.Label();
            this.boxNombre = new System.Windows.Forms.TextBox();
            this.groupID = new System.Windows.Forms.GroupBox();
            this.comboEstado = new System.Windows.Forms.ComboBox();
            this.textPicture = new System.Windows.Forms.TextBox();
            this.ButtIngresar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.boxID = new System.Windows.Forms.TextBox();
            this.boxExpiracion = new System.Windows.Forms.TextBox();
            this.ButtF = new System.Windows.Forms.RadioButton();
            this.ButtM = new System.Windows.Forms.RadioButton();
            this.dateBorn = new System.Windows.Forms.DateTimePicker();
            this.textExpiracion = new System.Windows.Forms.Label();
            this.boxEstado = new System.Windows.Forms.TextBox();
            this.textEstado = new System.Windows.Forms.Label();
            this.boxSangre = new System.Windows.Forms.TextBox();
            this.textSangre = new System.Windows.Forms.Label();
            this.textSexo = new System.Windows.Forms.Label();
            this.boxOcupacion = new System.Windows.Forms.TextBox();
            this.textOcupacion = new System.Windows.Forms.Label();
            this.boxNacionalidad = new System.Windows.Forms.TextBox();
            this.textNacionalidad = new System.Windows.Forms.Label();
            this.textFecha = new System.Windows.Forms.Label();
            this.boxLugar = new System.Windows.Forms.TextBox();
            this.textLugar = new System.Windows.Forms.Label();
            this.buttonCrear = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.dgbCuadro = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.groupID.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgbCuadro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nunito Sans ExtraBold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(202, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "CÉDULA DE IDENTIDAD";
            // 
            // Picture
            // 
            this.Picture.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Picture.Location = new System.Drawing.Point(9, 22);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(122, 154);
            this.Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picture.TabIndex = 1;
            this.Picture.TabStop = false;
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(21, 9);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(49, 48);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 2;
            this.logo.TabStop = false;
            // 
            // textNombre
            // 
            this.textNombre.AutoSize = true;
            this.textNombre.Font = new System.Drawing.Font("Nunito Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombre.Location = new System.Drawing.Point(145, 18);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(96, 15);
            this.textNombre.TabIndex = 3;
            this.textNombre.Text = "Nombre Completo";
            this.textNombre.Click += new System.EventHandler(this.label2_Click);
            // 
            // boxNombre
            // 
            this.boxNombre.Location = new System.Drawing.Point(148, 36);
            this.boxNombre.Name = "boxNombre";
            this.boxNombre.Size = new System.Drawing.Size(211, 23);
            this.boxNombre.TabIndex = 4;
            // 
            // groupID
            // 
            this.groupID.Controls.Add(this.comboEstado);
            this.groupID.Controls.Add(this.textPicture);
            this.groupID.Controls.Add(this.ButtIngresar);
            this.groupID.Controls.Add(this.label2);
            this.groupID.Controls.Add(this.boxID);
            this.groupID.Controls.Add(this.boxExpiracion);
            this.groupID.Controls.Add(this.ButtF);
            this.groupID.Controls.Add(this.ButtM);
            this.groupID.Controls.Add(this.dateBorn);
            this.groupID.Controls.Add(this.textExpiracion);
            this.groupID.Controls.Add(this.boxEstado);
            this.groupID.Controls.Add(this.boxNombre);
            this.groupID.Controls.Add(this.textEstado);
            this.groupID.Controls.Add(this.textNombre);
            this.groupID.Controls.Add(this.boxSangre);
            this.groupID.Controls.Add(this.textSangre);
            this.groupID.Controls.Add(this.Picture);
            this.groupID.Controls.Add(this.textSexo);
            this.groupID.Controls.Add(this.boxOcupacion);
            this.groupID.Controls.Add(this.textOcupacion);
            this.groupID.Controls.Add(this.boxNacionalidad);
            this.groupID.Controls.Add(this.textNacionalidad);
            this.groupID.Controls.Add(this.textFecha);
            this.groupID.Controls.Add(this.boxLugar);
            this.groupID.Controls.Add(this.textLugar);
            this.groupID.Enabled = false;
            this.groupID.Font = new System.Drawing.Font("Nunito Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupID.Location = new System.Drawing.Point(12, 63);
            this.groupID.Name = "groupID";
            this.groupID.Size = new System.Drawing.Size(550, 248);
            this.groupID.TabIndex = 5;
            this.groupID.TabStop = false;
            this.groupID.Text = "Datos Personales";
            // 
            // comboEstado
            // 
            this.comboEstado.FormattingEnabled = true;
            this.comboEstado.Items.AddRange(new object[] {
            "Soltero",
            "Casado",
            "Divorciado",
            "Separación en proceso judicial",
            "Viudo",
            "Concubinato"});
            this.comboEstado.Location = new System.Drawing.Point(369, 164);
            this.comboEstado.Name = "comboEstado";
            this.comboEstado.Size = new System.Drawing.Size(165, 23);
            this.comboEstado.TabIndex = 33;
            // 
            // textPicture
            // 
            this.textPicture.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.textPicture.Enabled = false;
            this.textPicture.Location = new System.Drawing.Point(9, 153);
            this.textPicture.Name = "textPicture";
            this.textPicture.Size = new System.Drawing.Size(122, 23);
            this.textPicture.TabIndex = 32;
            this.textPicture.Visible = false;
            // 
            // ButtIngresar
            // 
            this.ButtIngresar.Location = new System.Drawing.Point(9, 185);
            this.ButtIngresar.Name = "ButtIngresar";
            this.ButtIngresar.Size = new System.Drawing.Size(122, 23);
            this.ButtIngresar.TabIndex = 31;
            this.ButtIngresar.Text = "Ingresar una Foto";
            this.ButtIngresar.UseVisualStyleBackColor = true;
            this.ButtIngresar.Click += new System.EventHandler(this.ButtIngresar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nunito Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(365, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 15);
            this.label2.TabIndex = 30;
            this.label2.Text = "ID";
            // 
            // boxID
            // 
            this.boxID.Enabled = false;
            this.boxID.Location = new System.Drawing.Point(368, 36);
            this.boxID.Name = "boxID";
            this.boxID.Size = new System.Drawing.Size(176, 23);
            this.boxID.TabIndex = 29;
            // 
            // boxExpiracion
            // 
            this.boxExpiracion.Enabled = false;
            this.boxExpiracion.Location = new System.Drawing.Point(368, 209);
            this.boxExpiracion.Name = "boxExpiracion";
            this.boxExpiracion.Size = new System.Drawing.Size(166, 23);
            this.boxExpiracion.TabIndex = 28;
            // 
            // ButtF
            // 
            this.ButtF.AutoSize = true;
            this.ButtF.Location = new System.Drawing.Point(461, 82);
            this.ButtF.Name = "ButtF";
            this.ButtF.Size = new System.Drawing.Size(73, 19);
            this.ButtF.TabIndex = 24;
            this.ButtF.TabStop = true;
            this.ButtF.Text = "Femenino";
            this.ButtF.UseVisualStyleBackColor = true;
            // 
            // ButtM
            // 
            this.ButtM.AutoSize = true;
            this.ButtM.Location = new System.Drawing.Point(369, 82);
            this.ButtM.Name = "ButtM";
            this.ButtM.Size = new System.Drawing.Size(74, 19);
            this.ButtM.TabIndex = 23;
            this.ButtM.TabStop = true;
            this.ButtM.Text = "Masculino";
            this.ButtM.UseVisualStyleBackColor = true;
            // 
            // dateBorn
            // 
            this.dateBorn.Location = new System.Drawing.Point(148, 120);
            this.dateBorn.Name = "dateBorn";
            this.dateBorn.Size = new System.Drawing.Size(211, 23);
            this.dateBorn.TabIndex = 22;
            this.dateBorn.ValueChanged += new System.EventHandler(this.dateBorn_ValueChanged);
            // 
            // textExpiracion
            // 
            this.textExpiracion.AutoSize = true;
            this.textExpiracion.Font = new System.Drawing.Font("Nunito Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textExpiracion.Location = new System.Drawing.Point(366, 193);
            this.textExpiracion.Name = "textExpiracion";
            this.textExpiracion.Size = new System.Drawing.Size(105, 15);
            this.textExpiracion.TabIndex = 20;
            this.textExpiracion.Text = "Fecha de Expiración";
            // 
            // boxEstado
            // 
            this.boxEstado.Location = new System.Drawing.Point(369, 162);
            this.boxEstado.Name = "boxEstado";
            this.boxEstado.Size = new System.Drawing.Size(166, 23);
            this.boxEstado.TabIndex = 19;
            // 
            // textEstado
            // 
            this.textEstado.AutoSize = true;
            this.textEstado.Font = new System.Drawing.Font("Nunito Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEstado.Location = new System.Drawing.Point(366, 146);
            this.textEstado.Name = "textEstado";
            this.textEstado.Size = new System.Drawing.Size(65, 15);
            this.textEstado.TabIndex = 18;
            this.textEstado.Text = "Estado Civil";
            // 
            // boxSangre
            // 
            this.boxSangre.Location = new System.Drawing.Point(368, 120);
            this.boxSangre.Name = "boxSangre";
            this.boxSangre.Size = new System.Drawing.Size(166, 23);
            this.boxSangre.TabIndex = 17;
            // 
            // textSangre
            // 
            this.textSangre.AutoSize = true;
            this.textSangre.Font = new System.Drawing.Font("Nunito Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSangre.Location = new System.Drawing.Point(365, 104);
            this.textSangre.Name = "textSangre";
            this.textSangre.Size = new System.Drawing.Size(42, 15);
            this.textSangre.TabIndex = 16;
            this.textSangre.Text = "Sangre";
            // 
            // textSexo
            // 
            this.textSexo.AutoSize = true;
            this.textSexo.Font = new System.Drawing.Font("Nunito Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSexo.Location = new System.Drawing.Point(366, 64);
            this.textSexo.Name = "textSexo";
            this.textSexo.Size = new System.Drawing.Size(32, 15);
            this.textSexo.TabIndex = 14;
            this.textSexo.Text = "Sexo";
            // 
            // boxOcupacion
            // 
            this.boxOcupacion.Location = new System.Drawing.Point(148, 209);
            this.boxOcupacion.Name = "boxOcupacion";
            this.boxOcupacion.Size = new System.Drawing.Size(211, 23);
            this.boxOcupacion.TabIndex = 13;
            // 
            // textOcupacion
            // 
            this.textOcupacion.AutoSize = true;
            this.textOcupacion.Font = new System.Drawing.Font("Nunito Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textOcupacion.Location = new System.Drawing.Point(145, 193);
            this.textOcupacion.Name = "textOcupacion";
            this.textOcupacion.Size = new System.Drawing.Size(58, 15);
            this.textOcupacion.TabIndex = 12;
            this.textOcupacion.Text = "Ocupación";
            // 
            // boxNacionalidad
            // 
            this.boxNacionalidad.Location = new System.Drawing.Point(148, 162);
            this.boxNacionalidad.Name = "boxNacionalidad";
            this.boxNacionalidad.Size = new System.Drawing.Size(211, 23);
            this.boxNacionalidad.TabIndex = 11;
            // 
            // textNacionalidad
            // 
            this.textNacionalidad.AutoSize = true;
            this.textNacionalidad.Font = new System.Drawing.Font("Nunito Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNacionalidad.Location = new System.Drawing.Point(145, 146);
            this.textNacionalidad.Name = "textNacionalidad";
            this.textNacionalidad.Size = new System.Drawing.Size(71, 15);
            this.textNacionalidad.TabIndex = 10;
            this.textNacionalidad.Text = "Nacionalidad";
            // 
            // textFecha
            // 
            this.textFecha.AutoSize = true;
            this.textFecha.Font = new System.Drawing.Font("Nunito Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFecha.Location = new System.Drawing.Point(145, 104);
            this.textFecha.Name = "textFecha";
            this.textFecha.Size = new System.Drawing.Size(110, 15);
            this.textFecha.TabIndex = 8;
            this.textFecha.Text = "Fecha de Nacimiento";
            // 
            // boxLugar
            // 
            this.boxLugar.Location = new System.Drawing.Point(148, 78);
            this.boxLugar.Name = "boxLugar";
            this.boxLugar.Size = new System.Drawing.Size(211, 23);
            this.boxLugar.TabIndex = 7;
            this.boxLugar.TextChanged += new System.EventHandler(this.boxLugar_TextChanged);
            // 
            // textLugar
            // 
            this.textLugar.AutoSize = true;
            this.textLugar.Font = new System.Drawing.Font("Nunito Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLugar.Location = new System.Drawing.Point(145, 62);
            this.textLugar.Name = "textLugar";
            this.textLugar.Size = new System.Drawing.Size(109, 15);
            this.textLugar.TabIndex = 6;
            this.textLugar.Text = "Lugar de Nacimiento";
            // 
            // buttonCrear
            // 
            this.buttonCrear.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonCrear.Font = new System.Drawing.Font("Nunito Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCrear.Location = new System.Drawing.Point(12, 317);
            this.buttonCrear.Name = "buttonCrear";
            this.buttonCrear.Size = new System.Drawing.Size(164, 37);
            this.buttonCrear.TabIndex = 6;
            this.buttonCrear.Text = "CREAR";
            this.buttonCrear.UseVisualStyleBackColor = false;
            this.buttonCrear.Click += new System.EventHandler(this.buttonCrear_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.BackColor = System.Drawing.Color.LightBlue;
            this.buttonGuardar.Enabled = false;
            this.buttonGuardar.Font = new System.Drawing.Font("Nunito Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar.Location = new System.Drawing.Point(207, 317);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(164, 37);
            this.buttonGuardar.TabIndex = 7;
            this.buttonGuardar.Text = "GUARDAR";
            this.buttonGuardar.UseVisualStyleBackColor = false;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.LightCoral;
            this.buttonCancelar.Enabled = false;
            this.buttonCancelar.Font = new System.Drawing.Font("Nunito Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Location = new System.Drawing.Point(398, 317);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(164, 37);
            this.buttonCancelar.TabIndex = 8;
            this.buttonCancelar.Text = "CANCELAR";
            this.buttonCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // dgbCuadro
            // 
            this.dgbCuadro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbCuadro.Location = new System.Drawing.Point(12, 374);
            this.dgbCuadro.Name = "dgbCuadro";
            this.dgbCuadro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgbCuadro.Size = new System.Drawing.Size(550, 147);
            this.dgbCuadro.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nunito Sans", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(164, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(279, 26);
            this.label3.TabIndex = 10;
            this.label3.Text = "JUNTA CENTRAL ELECTORAL";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(513, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(578, 533);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgbCuadro);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.buttonCrear);
            this.Controls.Add(this.groupID);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Sistema de Identidad";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.groupID.ResumeLayout(false);
            this.groupID.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgbCuadro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Picture;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label textNombre;
        private System.Windows.Forms.TextBox boxNombre;
        private System.Windows.Forms.GroupBox groupID;
        private System.Windows.Forms.Label textLugar;
        private System.Windows.Forms.TextBox boxLugar;
        private System.Windows.Forms.DateTimePicker dateBorn;
        private System.Windows.Forms.Label textExpiracion;
        private System.Windows.Forms.TextBox boxEstado;
        private System.Windows.Forms.Label textEstado;
        private System.Windows.Forms.TextBox boxSangre;
        private System.Windows.Forms.Label textSangre;
        private System.Windows.Forms.Label textSexo;
        private System.Windows.Forms.TextBox boxOcupacion;
        private System.Windows.Forms.Label textOcupacion;
        private System.Windows.Forms.TextBox boxNacionalidad;
        private System.Windows.Forms.Label textNacionalidad;
        private System.Windows.Forms.Label textFecha;
        private System.Windows.Forms.RadioButton ButtM;
        private System.Windows.Forms.RadioButton ButtF;
        private System.Windows.Forms.Button buttonCrear;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.DataGridView dgbCuadro;
        private System.Windows.Forms.TextBox boxExpiracion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox boxID;
        private System.Windows.Forms.Button ButtIngresar;
        private System.Windows.Forms.TextBox textPicture;
        private System.Windows.Forms.ComboBox comboEstado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

