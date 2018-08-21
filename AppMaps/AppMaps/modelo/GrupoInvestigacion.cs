using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMaps.modelo
{
    class GrupoInvestigacion
    {


        public static String[] CIUDADES = File.ReadAllLines("data/CIUDADES.txt");
        public static String[] AREA = File.ReadAllLines("data/AREAS.txt");
        public static String[] DEPARTAMENTOS = File.ReadAllLines("data/DEPARTAMENTOS.txt");
        public static String[] REGIONES = File.ReadAllLines("data/REGIONES.txt");
        public static String[] FILTROS = { "Ciudad","Nombre", "Region", "Departamento", "Area", "Codigo" };
        

        public String codigo;
        public String nombre;
        public DateTime fechaCreacion;
        public String ciudad;
        public String departamento;
        public String pais;
        public String regional;
        public String area;
        public int edad;

        public GrupoInvestigacion(string codigo, string nombre, DateTime fechaCreacion, string ciudad, string departamento, string pais, string regional, string area)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.fechaCreacion = fechaCreacion;
            this.ciudad = ciudad;
            this.departamento = departamento;
            this.pais = pais;
            this.regional = regional;
            this.area = area;
            this.edad = DateTime.Now.Year-fechaCreacion.Year;
        }

        public string ToString()
        {
            return codigo + "\t" + nombre + "\t" + fechaCreacion.Day + "/" + fechaCreacion.Month + "/" + fechaCreacion.Year + "\t" + ciudad + "\t" + departamento + "\t" + pais + "\t" + regional + "\t" + area;
        }
    }
}
