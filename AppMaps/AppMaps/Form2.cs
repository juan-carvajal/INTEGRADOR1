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
using System.IO;

namespace AppMaps
{
    internal partial class Form2 : Form
    {


        Colciencias colciencias;
        public Form2(Colciencias c)
        {
            colciencias = c;
            InitializeComponent();
            ciudad.Items.AddRange(GrupoInvestigacion.CIUDADES);
            dpto.Items.AddRange(GrupoInvestigacion.DEPARTAMENTOS);
            region.Items.AddRange(GrupoInvestigacion.REGIONES);
            area.Items.AddRange(GrupoInvestigacion.AREA);
            String[] paises = { "Colombia" };
            pais.Items.AddRange(paises);
            pais.SelectedIndex = 0;
            pais.Enabled = false;
            this.Visible = true;
        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GrupoInvestigacion gi = new GrupoInvestigacion(codigo.Text, nombre.Text, fecha.SelectionStart, ciudad.Text, dpto.Text, pais.Text, region.Text, area.Text);
            colciencias.grupos.Add(gi);
            String grabar = "\r\n"+gi.ToString();
            String path =Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Colciencias-GruposInvestigacion", "GRUPOS.txt");
            if (File.Exists(path))
            {
                File.AppendAllText(path, grabar);

            }
            else
            {
                MessageBox.Show("No se ha encontrado el archivo de datos, reinicie la aplicacion.");
            }
            this.Dispose();
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
