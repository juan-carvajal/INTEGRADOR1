using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMaps.modelo
{
    class GrupoInvestigacion
    {


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
    }
}
