using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        internal Repositorio gitAdd(Repositorio repo, List<Object> items)
        {
            foreach(Object item in items)
            {
                foreach (Archivo archivo in repo.zona.workSpace.archivos) 
                {
                    if (archivo.nombre.Equals(item.ToString()))
                    {
                        repo.zona.index.archivos.Add(archivo);
                    }
                }
            }

            return repo;
        }

        internal Repositorio CrearArchivo(Repositorio repo, String nombre, String contenido)
        {
            DateTime date = DateTime.Now;
            String format = "G";
            String fecha = date.ToString(format);

            String nombreFinal = nombre + ".txt";

            Archivo archivo = new Archivo(nombreFinal, fecha, contenido);

            repo.zona.workSpace.archivos.Add(archivo);

            return repo;
        }
    }
}
