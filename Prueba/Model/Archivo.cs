using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Model
{
    class Archivo
    {
        public String nombre;
        public String fecha;
        public String contenido;

        public Archivo(String nombre, String fecha, String contenido)
        {
            this.nombre = nombre;
            this.fecha = fecha;
            this.contenido = contenido;
        }
    }
}
