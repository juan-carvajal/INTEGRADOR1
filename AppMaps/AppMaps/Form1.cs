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
                listView1.Items.Clear();
                listView1.Items.AddRange(colciencias.castToListItem(colciencias.gruposPorNombre()));
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
