using System;
using System.Collections.Generic;

namespace Prueba.Model
{
    class Commit
    {
        public String nombre; //Nombre del commit
        public String autor; //Nombre del autor del commit
        public String marca_Tiempo; //Fecha del commit
        public String descripcion; //Mensaje
        public List<String> cambios; //Cambios realizados entre el anterior commit y este
        public List<Archivo> archivos; //Lista con los archivos actuales

        public Commit(String nombre, String autor, String marca_Tiempo, String descripcion, List<String> cambios, List<Archivo> archivos)
        {
            this.nombre = nombre;
            this.autor = autor;
            this.marca_Tiempo = marca_Tiempo;
            this.descripcion = descripcion;
            this.cambios = cambios;
            this.archivos = archivos;
        }
    }
}
