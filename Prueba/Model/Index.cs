using System;
using System.Collections.Generic;

namespace Prueba.Model
{
    class Index
    {
        public List<Archivo> archivos;
        public String nombre;
        public String mensaje;
        public String fecha;
        public Commit commit;

        public Index(List<Archivo> archivos, String nombre, String mensaje, String fecha, Commit commit)
        {
            this.archivos = archivos;
            this.nombre = nombre;
            this.mensaje = mensaje;
            this.fecha = fecha;
            this.commit = commit;
        }
    }
}
