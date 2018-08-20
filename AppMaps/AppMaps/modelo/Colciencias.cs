using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMaps.modelo
{
    class Colciencias
    {

        public List<GrupoInvestigacion> grupos;



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
                    var info = line.Split('-');
                    Console.WriteLine(info[0]);
                    String []fecha = info[2].Split('/');
                
                    int dia = Int32.Parse(fecha[0]);
                    int mes = Int32.Parse(fecha[1]);
                    int año = Int32.Parse(fecha[2]);
                    grupos.Add(new GrupoInvestigacion(info[0], info[1], new DateTime(año, mes, dia), info[3], info[4], info[5], info[6], info[7]));
                }
            }
        }
    }
}
