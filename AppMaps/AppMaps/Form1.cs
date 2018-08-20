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
            GMapOverlay markers = new GMapOverlay("markers");
            
            for (int i = 0; i < colciencias.grupos.Count; i++)
            {
                gmap.SetPositionByKeywords("Colombia, " + colciencias.grupos[i].ciudad);
                GMapMarker marker = new GMarkerGoogle(
                new PointLatLng(gmap.Position.Lat, gmap.Position.Lng),
                GMarkerGoogleType.blue_pushpin);
                marker.ToolTipText = colciencias.grupos[i].codigo + "\n" + colciencias.grupos[i].nombre;
                markers.Markers.Add(marker);

            }
            gmap.Overlays.Add(markers);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
