using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD___CEDULA_FORM
{
    public partial class Form1 : Form
    {
        public bool Agregando { get; set; } = true;

        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void GBCEDULA_Enter(object sender, EventArgs e)
        {

        }

        private void buttNuevo_Click(object sender, EventArgs e)
        {
            DateTime Tiempo = DateTime.Now.AddYears(10);
            boxExpira.Text = Convert.ToString(Tiempo);

            Guid Matricula = Guid.NewGuid();
            boxMatricula.Text = Convert.ToString(Matricula);

            buttNuevo.Enabled = false;
            buttCancelar.Enabled = true;
            buttGuardar.Enabled = true;
            buttIngresar.Enabled = true;
            GBCEDULA.Enabled = true;
        }

        private void buttGuardar_Click(object sender, EventArgs e)
        {
            Save();

        }

        private void buttCancelar_Click(object sender, EventArgs e)
        {
            Borrar();
        }

        private void Save()
        {

            var json = string.Empty;
            var ConceptoList = new List<Usuario>();
            var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\conceptos.json";

            if (File.Exists(pathFile))
            {
                json = File.ReadAllText(pathFile, Encoding.UTF8);
                ConceptoList = JsonConvert.DeserializeObject<List<Usuario>>(json);
            }

            var usuaruiexist = ConceptoList.Count(x => x.Nombre_Completo.ToString().ToLower().Trim() == boxNombre.Text.ToLower().Trim());
            
            if (usuaruiexist > 0)
            {
                MessageBox.Show("El usuario ya existe", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            var persona = new Usuario();
            if (Agregando) 
            {
                persona = new Usuario
                {
                Matricula = boxMatricula.Text,
                Nombre_Completo = boxNombre.Text,
                Lugar_de_Nacimiento = boxNacimiento.Text,
                Sexo = buttMas.Checked ? "Masculino" : "Femenino",
                Fecha_de_Nacimiento = dateNacimiento.Value,
                Tipo_Sangre = boxSangre.Text,
                Nacionalidad = boxNacionalidad.Text,
                Estado_Civil = boxEstado.Text,
                Ocupacion = boxOcupacion.Text,
                Fecha_Creada = DateTime.Now,
                Fecha_de_Expiracion = boxExpira.Text,
                Picture = Picture.Text,
                };
            }
            

            ConceptoList.Add(persona);

            json = JsonConvert.SerializeObject(ConceptoList);
            var FW = new StreamWriter(pathFile, false, Encoding.UTF8);
            
            FW.Write(json);
            
            FW.Close();
            
            MessageBox.Show("Datos guardado","INTEC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
            buttNuevo.Enabled = true;
            buttCancelar.Enabled = false;
            buttGuardar.Enabled = false;
            buttIngresar.Enabled = false;
            GBCEDULA.Enabled = false;

            Borrar();
            ObtenerUsuario();

        }

        private void Borrar()
        {
            Picture.Text = String.Empty;
            Picture.Image = null;
            dateNacimiento.Value = DateTime.Now;

            foreach (Control x in GBCEDULA.Controls)
            {
                if (x is TextBox)
                {
                    x.Text = string.Empty;
                }
                
            }
            
        }

        private void ObtenerUsuario()
        {
            var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\concept.json";
            var ConceptoList = new List<Usuario>();

            if (File.Exists(pathFile))
            {
                var json = File.ReadAllText(pathFile, Encoding.UTF8);
                ConceptoList = JsonConvert.DeserializeObject<List<Usuario>>(json);

            }
            
            DGV.DataSource = ConceptoList;

        }

        private void buttIngresar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Picture.Image = new Bitmap(openFileDialog.FileName);

                boxPicture.Text = openFileDialog.FileName;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
    public class Usuario
    {
        public string Matricula { get; set; }
        public string Nombre_Completo { get; set; }
        public string Lugar_de_Nacimiento { get; set; }
        public string Sexo { get; set; }
        public DateTime Fecha_de_Nacimiento { get; set; }
        public string Tipo_Sangre { get; set; }
        public string Nacionalidad { get; set; }
        public string Estado_Civil { get; set; }
        public string Ocupacion { get; set; }
        public DateTime Fecha_Creada { get; set; }
        public string Fecha_de_Expiracion { get; set; }
        public string Picture { get; set; }

    }
}
