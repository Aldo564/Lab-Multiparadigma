using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Model
{
    class Repositorio
    {

        public String nombre;
        public String autor;
        public String fecha;
        public Zones zona;

        // Función constructora de Repositorio.
        public Repositorio(String nombre, String autor, String fecha)
        {
            this.nombre = nombre;
            this.autor = autor;
            this.fecha = fecha;
        }

        // Función que añade un archivo (o varios) desde el Work Space al Index.
        // Entrada: no tiene.
        // Salida: no tiene.
        internal void gitAdd(Repositorio repo)
        {
            
        }
    }
}
