using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Identidad
{
    public partial class Form1 : Form
    {
        List<Personal>Personas = new List<Personal>();

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void boxLugar_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            DateTime Tiempo = DateTime.Now.AddYears(10);
            boxExpiracion.Text = Convert.ToString(Tiempo);
            
            Guid Id = Guid.NewGuid();
            boxID.Text = Convert.ToString(Id);

            buttonCrear.Enabled = false;
            buttonCancelar.Enabled = true;
            buttonGuardar.Enabled = true;
            ButtIngresar.Enabled = true;
            groupID.Enabled = true;
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Save()
        {
            var persona = new Personal
            {
                Id = boxID.Text,
                NombreCompleto = boxNombre.Text,
                Lugar_de_Nacimiento = boxLugar.Text,
                Sexo = ButtM.Checked ? "Masculino" : "Femenino",
                Fecha_de_Nacimiento = dateBorn.Value,
                Sangre = boxSangre.Text,
                Nacionalidad = boxNacionalidad.Text,
                Estado_Civil = comboEstado.Text,
                Ocupacion = boxOcupacion.Text,
                FechaCreada = DateTime.Now,
                Fecha_de_Expiracion = boxExpiracion.Text,
                Picture = textPicture.Text,
            };

            Personas.Add(persona);

            MessageBox.Show("Dato personal agregado");


            EmptyControls();

            buttonCrear.Enabled = true;
            buttonCancelar.Enabled = false;
            buttonGuardar.Enabled = false;
            ButtIngresar.Enabled = false;
            groupID.Enabled = false;

            GetPersonal();
            
        }

        private void GetPersonal()
        {
            dgbCuadro.DataSource = null;
            dgbCuadro.DataSource = Personas;
        }

        private void EmptyControls()
        {
            textPicture.Text = String.Empty;
            Picture.Image = null;
            dateBorn.Value = DateTime.Now;

            foreach (Control c in groupID.Controls)
            {
                if(c is TextBox)
                {
                    c.Text = string.Empty;
                }

            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            EmptyControls();
        }

        private void ButtIngresar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Picture.Image = new Bitmap(openFileDialog.FileName);

                textPicture.Text = openFileDialog.FileName;
            }

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dateBorn_ValueChanged(object sender, EventArgs e)
        {
            int edad = DateTime.Now.Year - dateBorn.Value.Year;

            this.BackColor = edad >= 18 ? Color.Ivory : Color.Azure;
        }
    }

    public class Personal
    {
        public string Id { get; set; }
        public string NombreCompleto { get; set; }
        public string Lugar_de_Nacimiento { get; set; }
        public string Sexo { get; set; }
        public DateTime Fecha_de_Nacimiento { get; set; }
        public string Sangre { get; set; }
        public string Nacionalidad { get; set; }
        public string Estado_Civil { get; set; }
        public string Ocupacion { get; set; }
        public DateTime FechaCreada { get; set; }
        public string Fecha_de_Expiracion { get; set; }
        public string Picture { get; set; }

    }
}
