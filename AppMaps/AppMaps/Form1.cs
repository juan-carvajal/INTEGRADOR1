using AppMaps.modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;

namespace AppMaps
{

    public partial class AppGMaps : Form
    {

        private Colciencias colciencias;
        GMapOverlay markers;

        public AppGMaps()
        {
            colciencias = new Colciencias();
            InitializeComponent();
        }

        private void TabMapa_Click(object sender, EventArgs e)
        {

        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {
            gmap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            this.cargarMarcadores();
            gmap.Position = new GMap.NET.PointLatLng(4.703568, -74.161406);
            gmap.Zoom = 5;

        }

        private void cargarMarcadores()
        {
            markers = new GMapOverlay("markers");
            Random r = new Random();
            double radio = 0.1;
            
            for (int i = 0; i < colciencias.grupos.Count; i++)
            {
                gmap.SetPositionByKeywords("Colombia, " + colciencias.grupos[i].ciudad);
                double lat = gmap.Position.Lat-(radio)+(r.NextDouble()*radio*2);
                double cateto = Math.Sqrt(Math.Pow(radio, 2) - Math.Pow(lat-gmap.Position.Lat, 2));
                double lng = gmap.Position.Lng - cateto + (r.NextDouble() * cateto*2);
                GMapMarker marker = new GMarkerGoogle(
                new PointLatLng(lat,lng),
                GMarkerGoogleType.blue_pushpin);
                marker.ToolTipText = colciencias.grupos[i].codigo + "\n" + colciencias.grupos[i].nombre;
                marker.Tag = colciencias.grupos[i].codigo;
                markers.Markers.Add(marker);

            }
            gmap.Overlays.Add(markers);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }




        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString().Equals("Nombre"))
            {
                comboBox3.Enabled = false;
                listView1.Items.Clear();
                listView1.Items.AddRange(colciencias.castToListItem(colciencias.gruposPorNombre()));
            }
            else if (comboBox1.SelectedItem.ToString().Equals("Ciudad"))
            {
                comboBox3.Enabled = true;
                comboBox3.Items.Clear();
                comboBox3.Items.AddRange(GrupoInvestigacion.CIUDADES);
                comboBox3.SelectedIndex = 0;

            }
            else if (comboBox1.SelectedItem.ToString().Equals("Departamento"))
            {
                comboBox3.Enabled = true;
                comboBox3.Items.Clear();
                comboBox3.Items.AddRange(GrupoInvestigacion.DEPARTAMENTOS);
                comboBox3.SelectedIndex = 0;
            }
            else if (comboBox1.SelectedItem.ToString().Equals("Región"))
            {
                comboBox3.Enabled = true;
                comboBox3.Items.Clear();
                comboBox3.Items.AddRange(GrupoInvestigacion.REGIONES);
                comboBox3.SelectedIndex = 0;
            }else if(comboBox1.SelectedItem.ToString().Equals("Área Investigación"))
            {
                comboBox3.Enabled = true;
                comboBox3.Items.Clear();
                comboBox3.Items.AddRange(GrupoInvestigacion.AREA);
                comboBox3.SelectedIndex = 0;
            }
            else
            {
                comboBox3.Enabled = false;
                listView1.Items.Clear();
                listView1.Items.AddRange(colciencias.castToListItem(colciencias.gruposPorCodigo()));
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString().Equals("Ciudad"))
            {
                listView1.Items.Clear();
                listView1.Items.AddRange(colciencias.castToListItem(colciencias.gruposPorCiudad(comboBox3.SelectedItem.ToString())));
            }else if (comboBox1.SelectedItem.ToString().Equals("Departamento"))
            {
                listView1.Items.Clear();
                listView1.Items.AddRange(colciencias.castToListItem(colciencias.gruposPorDepartamento(comboBox3.SelectedItem.ToString())));
            }
            else if (comboBox1.SelectedItem.ToString().Equals("Región"))
            {
                listView1.Items.Clear();
                listView1.Items.AddRange(colciencias.castToListItem(colciencias.gruposPorRegion(comboBox3.SelectedItem.ToString())));
            }
            else if (comboBox1.SelectedItem.ToString().Equals("Área Investigación"))
            {
                listView1.Items.Clear();
                listView1.Items.AddRange(colciencias.castToListItem(colciencias.gruposPorArea(comboBox3.SelectedItem.ToString())));
            }
        }

        private void Buscador_Click(object sender, EventArgs e)
        {

        }




        private void ubicar_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.ubicarPin(listView1.SelectedItems[0].Text);
            }
            catch
            {
                MessageBox.Show("No hay ningún elemento seleccionado");
            }
            
        }

        private void ubicarPin(String codigo)
        {
            Boolean encontrado = false;
            int cont = 0;
            while (!encontrado)
            {
                if (markers.Markers[cont].Tag.Equals(codigo))
                {
                    gmap.Position = markers.Markers[cont].Position;
                    gmap.Zoom = 15;
                    tabControl1.SelectTab(0);
                    gmap.Refresh();
                    encontrado = true;
                }
                else
                {
                    if (cont >= markers.Markers.Count)
                    {
                        MessageBox.Show("El marcador no ha sido encontrado");
                        encontrado = true;
                    }
                    cont++;
                }
            }
        }

        private void cambiarColorArticulos(KeyValuePair<int,int> par)
        {
            GMapOverlay selec = new GMapOverlay("selec");
            gmap.Overlays.Clear();
            this.cargarMarcadores();
            int uno = par.Key;
            int dos = par.Value;


            List<String> elegidos=new List<string>();

            StreamReader sr = new StreamReader("data/ARTICULOS.txt");
            String linea = sr.ReadLine();

            while (linea != null)
            {
                String[] splt = linea.Trim().Split(':');
                String cod = splt[0];
                String[] arts = splt[1].Trim().Split(' ');

                Boolean artuno = false;
                Boolean artdos = false;
                int contuno = 0;
                int contdos = 0;
                while (!artuno && contuno < arts.Length)
                {
                    //Console.WriteLine(arts[contuno]);
                    if (int.Parse(arts[contuno]) == uno)
                    {
                        artuno = true;
                    }
                    contuno++;
                }
                while (artuno&&!artdos&&contdos<arts.Length)
                {
                    if(int.Parse(arts[contdos]) == dos)
                    {
                        artdos = true;

                    }
                    contdos++;
                }
                if (artuno && artdos)
                {
                    elegidos.Add(cod);
                }
                linea = sr.ReadLine();
            }
            sr.Close();
            
            for (int i = 0; i < elegidos.Count; i++)
            {
                Boolean encontrado = false;
                int cont = 0;
                try
                {
                    while (!encontrado&&cont<markers.Markers.Count)
                    {
                        if (markers.Markers[cont].Tag.Equals(elegidos[i]))
                        {
                            GMapMarker nuevo = new GMarkerGoogle(markers.Markers[cont].Position, GMarkerGoogleType.red_pushpin);
                            nuevo.Tag = markers.Markers[cont].Tag;
                            nuevo.ToolTipText = markers.Markers[cont].ToolTipText;
                            selec.Markers.Add(nuevo);
                            encontrado = true;
                            
                        }
                        cont++;
                        
                    }
                }

                catch    
                {
                    System.Console.WriteLine(elegidos[i] + " no encontrado");
                }
                
            }
            gmap.Position = new GMap.NET.PointLatLng(4.703568, -74.161406);
            gmap.Zoom = 5;
            gmap.Overlays.Add(selec);
            gmap.Refresh();
            tabControl1.SelectTab(0);
            


        }




        private void calcular_Click(object sender, EventArgs e)
        {
            String[] lineas = File.ReadAllLines("data/ARTICULOS.txt");
            Dictionary<String, int> values = new Dictionary<String, int>();



                int count = 0;
            for (int i = 0; i < lineas.Length; i++)
            {

                string[] articulos = lineas[i].Trim().Split(':')[1].Split(' ');
                for (int j = 0; j < articulos.Length; j++)
                {
                    for(int x=j+1; x<articulos.Length; x++)
                    {
                        if (values.ContainsKey(articulos[j] + "-" + articulos[x]))
                        {
                            values[articulos[j] + "-" + articulos[x]]++;
                            count++;
                        }
                        else
                        {
                            if (values.ContainsKey(articulos[x] + "-" + articulos[j]))
                            {
                                values[articulos[x] + "-" + articulos[j]]++;
                                count++;
                            }
                            else
                            {
                                values.Add(articulos[j] + "-"+ articulos[x], 1);
                                count++;
                            }
                        }
                    }
                }
            }
            Console.Write(count);
            var top10 = values.OrderByDescending(i => i.Value).Take(10).ToList();
            listView2.Items.Clear();
            for (int i = 0; i < top10.Count; i++)
            {
                ListViewItem lvi = new ListViewItem(top10[i].Key + "");
                lvi.SubItems.Add(top10[i].Value + "");
                lvi.SubItems.Add((top10[i].Value/(double) count).ToString("P4"));
                listView2.Items.Add(lvi);
            }

            Dictionary<String, double> grafico = new Dictionary<string, double>();
            double acumulador = 0;
            for(int i=0; i<top10.Count; i++)
            {
                acumulador += (top10[i].Value / (double)count);
                grafico.Add(top10[i].Key, (top10[i].Value));
            }
            //grafico.Add("Otros", 1-acumulador);
            chart2.Enabled = true;
            chart2.Series[0].Points.Clear();
            chart2.ChartAreas.FirstOrDefault().AxisX.Interval = 1;
            chart2.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            chart2.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
            int count2 = 0;
            Random rand = new Random();
            foreach (string x in grafico.Keys)
            {
                chart2.Series[0].Points.AddXY(x, grafico[x]);
                int r = rand.Next(0, 255);
                int g = rand.Next(0, 255);
                int b = rand.Next(0, 255);
                chart2.Series[0].Points[count2].Color = Color.FromArgb(255,r,g, b);
                    count2++;
            }
        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

            String parS=listView2.SelectedItems[0].Text;
            int p1 = Int32.Parse(parS.Split('-')[0]);
            int p2 = Int32.Parse(parS.Split('-')[1]);
            KeyValuePair<int, int> par = new KeyValuePair<int, int>(p1,p2);


            cambiarColorArticulos(par);
            }
            catch
            {
                MessageBox.Show("Se debe seleccionar una opcion.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form2(colciencias);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dictionary<String, int> grafico = new Dictionary<string, int>();
            if (comboBox2.SelectedItem.ToString().Equals("Area"))
            {
                string[] x = GrupoInvestigacion.AREA;

                foreach (string item in x)
                {
                    Console.WriteLine(item);
                    grafico.Add(item, colciencias.gruposPorArea(item).Count);
                }


                chart1.Series[0].Points.Clear();
                chart1.ChartAreas.FirstOrDefault().AxisX.Interval = 1;
                chart1.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
                chart1.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
                int count2 = 0;
                Random rand = new Random();
                foreach (string y in grafico.Keys)
                {
                    chart1.Series[0].Points.AddXY(y, grafico[y]);
                    int r = rand.Next(0, 255);
                    int g = rand.Next(0, 255);
                    int b = rand.Next(0, 255);
                    chart1.Series[0].Points[count2].Color = Color.FromArgb(255, r, g, b);
                    count2++;
                }

            }
            else if (comboBox2.SelectedItem.ToString().Equals("Departamento"))
            {
                string[] x = GrupoInvestigacion.DEPARTAMENTOS;

                foreach (string item in x)
                {
                    grafico.Add(item, colciencias.gruposPorDepartamento(item).Count);
                }


                chart1.Series[0].Points.Clear();
                chart1.ChartAreas.FirstOrDefault().AxisX.Interval = 1;
                chart1.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
                chart1.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
                int count2 = 0;
                Random rand = new Random();
                foreach (string y in grafico.Keys)
                {
                    chart1.Series[0].Points.AddXY(y, grafico[y]);
                    int r = rand.Next(0, 255);
                    int g = rand.Next(0, 255);
                    int b = rand.Next(0, 255);
                    chart1.Series[0].Points[count2].Color = Color.FromArgb(255, r, g, b);
                    count2++;
                }
            }
            else if (comboBox2.SelectedItem.ToString().Equals("Región"))
            {
                string[] x = GrupoInvestigacion.REGIONES;

                foreach (string item in x)
                {
                    grafico.Add(item, colciencias.gruposPorRegion(item).Count);
                }


                chart1.Series[0].Points.Clear();
                chart1.ChartAreas.FirstOrDefault().AxisX.Interval = 1;
                chart1.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
                chart1.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
                int count2 = 0;
                Random rand = new Random();
                foreach (string y in grafico.Keys)
                {
                    chart1.Series[0].Points.AddXY(y, grafico[y]);
                    int r = rand.Next(0, 255);
                    int g = rand.Next(0, 255);
                    int b = rand.Next(0, 255);
                    chart1.Series[0].Points[count2].Color = Color.FromArgb(255, r, g, b);
                    count2++;
                }

            }
          /*  else if (comboBox2.SelectedItem.ToString().Equals("Área Investigación"))
            {
                chart1.Series.Clear();
                chart1.Series.Clear();
                
                
               
                String[] series = GrupoInvestigacion.AREA;
                List<int> puntos = new List<int>();
                foreach (string x in series)
                {


                    puntos.Add(colciencias.gruposPorArea(x).Count());

                }

                for (int i = 0; i < series.Length; i++)
                {
                    serie = chart1.Series.Add(series[i]);
                    serie.Label = puntos[i].ToString();
                    serie.Points.Add(puntos[i]);

                }


            }
            */
           
            else
            {
                chart1.Series.Clear();
                MessageBox.Show("Seleccione un campo");
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
