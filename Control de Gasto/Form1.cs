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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttConcepto_Click(object sender, EventArgs e)
        {
            var OpenForm = new FormConcept();
            OpenForm.Show();
        }

        private void buttCategoria_Click(object sender, EventArgs e)
        {
            var OpenForm = new FormCategory();
            OpenForm.Show();
        }

        private void buttAgregar_Click(object sender, EventArgs e)
        {

        }

        private void comboConcepto_Click(object sender, EventArgs e)
        {
            
        }

        
    }
}
