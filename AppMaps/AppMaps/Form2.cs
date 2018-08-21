using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppMaps.modelo;

namespace AppMaps
{
    internal partial class Form2 : Form
    {


        Colciencias colciencias;
        public Form2(Colciencias c)
        {
            colciencias = c;
            InitializeComponent();
            comboBox1.Items.AddRange(GrupoInvestigacion.CIUDADES);
            comboBox2.Items.AddRange(GrupoInvestigacion.DEPARTAMENTOS);
            comboBox4.Items.AddRange(GrupoInvestigacion.REGIONES);
            comboBox5.Items.AddRange(GrupoInvestigacion.AREA);
            String[] paises = { "Colombia" };
            comboBox3.Items.AddRange(paises);
            comboBox3.SelectedIndex = 0;
            comboBox3.Enabled = false;
        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
    }
}
