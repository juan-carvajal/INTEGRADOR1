using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppMaps.modelo
{
    class Colciencias
    {

        public List<GrupoInvestigacion> grupos;



        public List<GrupoInvestigacion> gruposPorNombre()
        {
            return grupos.Select(i => i).OrderBy(i => i.nombre).ToList();
        }


        public List<GrupoInvestigacion> gruposPorCodigo()
        {
            return grupos.Select(i => i).OrderBy(i => i.codigo).ToList();
        }

        public List<GrupoInvestigacion> gruposPorCiudad(String city)
        {
            return grupos.Select(i => i).Where(i=> i.ciudad.Equals(city)).OrderBy(i => i.codigo).ToList();
        }

        public List<GrupoInvestigacion> gruposPorDepartamento(String dpto)
        {
            return grupos.Select(i => i).Where(i => i.departamento.Equals(dpto)).OrderBy(i => i.codigo).ToList();
        }


        public List<GrupoInvestigacion> gruposPorArea(String a)
        {
            return grupos.Select(i => i).Where(i => i.area.Equals(a)).OrderBy(i => i.codigo).ToList();
        }

        public List<GrupoInvestigacion> gruposPorRegion(String reg)
        {
            return grupos.Select(i => i).Where(i => i.regional.Equals(reg)).OrderBy(i => i.codigo).ToList();
        }


        public ListViewItem[] castToListItem(List<GrupoInvestigacion> lista)
        {
            return lista.Select(i => { ListViewItem lvi = new ListViewItem(i.codigo); lvi.SubItems.Add(i.nombre); lvi.SubItems.Add(i.ciudad + "-" + i.departamento); return lvi; }).ToArray();
        }




        public Colciencias()
        {
            grupos = new List<GrupoInvestigacion>();

            String folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Colciencias-GruposInvestigacion");
            String articulos = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Colciencias-GruposInvestigacion","ARTICULOS.txt");
            String gruposData = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Colciencias-GruposInvestigacion","GRUPOS.txt");
            if (Directory.Exists(folder))
            {
                if(File.Exists(articulos) && File.Exists(gruposData))
                {

                }else
                {
                    File.Copy("data/ARTICULOS.txt", articulos);
                    File.Copy("data/GRUPOS.txt", gruposData);
                }
            }else
            {
                Directory.CreateDirectory(folder);
                //File.Create(articulos).Close();
                //File.Create(gruposData).Close();
                File.Copy("data/ARTICULOS.txt", articulos);
                File.Copy("data/GRUPOS.txt", gruposData);

            }
            //StreamWriter sw = new StreamWriter();

            String[] lineas = File.ReadAllLines(gruposData);
            foreach (String line in lineas)
            {
                if (line[0] != '*')
                {
                    var info = line.Split('\t');
                    //Console.WriteLine(info[0]);
                    String []fecha = info[2].Split('/');
                    //Console.WriteLine(fecha[0]);
                    int dia = Int32.Parse(fecha[0]);
                    int mes = Int32.Parse(fecha[1]);
                    int año = Int32.Parse(fecha[2]);
                    grupos.Add(new GrupoInvestigacion(info[0], info[1], new DateTime(año, mes, dia), info[3], info[4], info[5], info[6], info[7]));
                }
            }
        }
    }
}
