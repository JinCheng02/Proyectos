using Control_de_Gasto.Modelo;
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

namespace Control_de_Gasto
{
    public partial class FormConcept : Form
    {
        public bool Agregando { get; set; }

        public FormConcept()
        {
            InitializeComponent();
            ObtenerRecord();


        }

        private void groupConcepto_Enter(object sender, EventArgs e)
        {

        }


        private void buttCrear_Click(object sender, EventArgs e)
        {
            groupConcepto.Enabled = true;
            buttCrear.Enabled = false;
            buttCancelar.Enabled = true;
            buttGuardar.Enabled = true;
            ObtenerRecord();

        }


        private void VaciarFormulario()
        {
            textMatricula.Text = string.Empty;
            textNombre.Text = string.Empty;
            textDescripcion.Text = string.Empty;
            checkVisible.Checked = false;
        }

        private void buttGuardar_Click(object sender, EventArgs e)
        {
            Guardar(GetTextMatricula());
        }

        private TextBox GetTextMatricula()
        {
            return textMatricula;
        }

        private void Guardar(TextBox textMatricula)
        {
            var json = string.Empty;
            var ConceptoList = new List<concepto>();
            var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\conceptos.json";

            if (File.Exists(pathFile))
            {
                json = File.ReadAllText(pathFile, Encoding.UTF8);
                ConceptoList = JsonConvert.DeserializeObject<List<concepto>>(json);
            }

            

            var conceptos = new concepto();

            if (Agregando)
            {
                conceptos = new concepto
                {
                    Matricula = int.Parse(textMatricula.Text),
                    Nombre = textNombre.Text,
                    Descripcion = textDescripcion.Text,
                    EsVisible = checkVisible.Checked,
                    FechaCreada = DateTime.Now,

                };
            }
            else
            {
                var Maricula = int.Parse(textMatricula.Text);
                conceptos = ConceptoList.FirstOrDefault(x => x.Matricula == Maricula);
                if (conceptos != null)
                {
                    ConceptoList.Remove(conceptos);
                    
                    conceptos.Nombre = textNombre.Text;
                    conceptos.Descripcion = textDescripcion.Text;
                    conceptos.EsVisible = checkVisible.Checked;
                    conceptos.FechaModificada = DateTime.Now;
                }
            }

            ConceptoList.Add(conceptos);
            json= JsonConvert.SerializeObject(ConceptoList);

            var FW = new StreamWriter(pathFile, false, Encoding.UTF8);
            FW.Write(json);
            FW.Close();
            MessageBox.Show("Registro Almacenado","INTEC",MessageBoxButtons.OK, MessageBoxIcon.Information);

            groupConcepto.Enabled = false;
            buttCrear.Enabled = true;
            buttCancelar.Enabled = false;
            buttGuardar.Enabled = false;

            VaciarFormulario();

            ObtenerRecord();
        }

        private void ObtenerRecord()
        {
            var ConceptoList = new List<concepto>();
            var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\concept.json";

            if (File.Exists(pathFile))
            {
                var json = File.ReadAllText(pathFile,Encoding.UTF8);
                ConceptoList = JsonConvert.DeserializeObject<List<concepto>>(json);

                textMatricula.Text = (ConceptoList.Count + 1).ToString();
                dgvConcepto.DataSource = ConceptoList;
            }
        }
    }
}
