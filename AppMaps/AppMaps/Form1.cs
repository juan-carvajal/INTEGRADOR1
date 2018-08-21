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
            this.ubicarPin(listView1.SelectedItems[0].Text);
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
            var top10 = values.OrderByDescending(i => i.Value)/*.Take(20)*/.ToList();
            listView2.Items.Clear();
            for (int i = 0; i < top10.Count; i++)
            {
                ListViewItem lvi = new ListViewItem(top10[i].Key + "");
                lvi.SubItems.Add(top10[i].Value + "");
                lvi.SubItems.Add((top10[i].Value/(double) count).ToString("P4"));
                listView2.Items.Add(lvi);
            }
        }


    }
}
