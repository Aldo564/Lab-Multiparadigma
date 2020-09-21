using System;
using System.Collections.Generic;

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
        // Entrada: repo de tipo Repositorio y un List de tipo Object.
        // Salida: El repo de tipo Repositorio actualizado.
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


        // Funcion que crea un nuevo archivo tipo Archivo y lo agrega a Work Space.
        // Entrada: repo de tipo Repositorio, dos String (nombre y contenido).
        // Salida: El repo de tipo Repositorio actualizado.
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


        // Función que genera un commit desde Index a Local Repository con los archivos en Index y el mensaje pedido.
        // Entrada: repo de tipo Repositorio, tres String (nombre, autor y desc) y un List de tipo Object.
        // Salida: El repo de tipo Repositorio actualizado.
        internal Repositorio gitCommit(Repositorio repo, string nombre, string autor, string desc, List<object> items)
        {
            List<Archivo> archivos = rescatar_Archivos(repo, items);

            //List<String> cambios = ver_Cambios(repo, archivos);
            List<String> cambios = new List<string>();

            Commit commit = new Commit(nombre, autor, fecha, desc, cambios, archivos);

            repo.zona.index.commit = commit;
            repo.zona.index.archivos.Clear();

            repo.zona.localRepo.commits.Add(commit);
            repo.zona.remoteRepo.estado_actualizacion = false;

            return repo;
        }

        // Funcion que compara los archivos de Local Repository e Index para verificar los cambios entre el commmit entrante y el ultimo en Local Repository
        // Entrada: repo de tipo Repositorio y un List de tipo Archivo
        // Salida: Un List de tipo String con los cambios entre los archivos de los Commits.

        // La represetanción de la lista cambios, será un List de tipo String donde se pondra una comparación del ultimo commit de
        // Local Repository con este.
        // Se usara un prefijo antes de cada nombre de archivo para saber que sucedio con el:
        //      + para indicar que se agregó este archivo.
        //      - para indicar que se eliminó este archivo.
        //      ~ para indicar que se modificó este archivo.
        //      = para indicar que no hubo cambios en este archivo.
        private List<string> ver_Cambios(Repositorio repo, List<Archivo> archivos)
        {
            String aux;
            String agregar = "+";
            String eliminar = "-";
            String modificar = "~";
            String igual = "=";

            List<String> cambios = new List<string>();

            List<Archivo> copia_Archivos_Index = repo.zona.index.commit.archivos;
            

            if (repo.zona.localRepo.commits.Count == 0) 
            {
                foreach(Archivo archivo in copia_Archivos_Index) 
                {
                    aux = "\0"; // reset para que no exista basura dentro.
                    aux = agregar + archivo.nombre;
                    cambios.Add(aux);
                }

                return cambios;
            }
            else 
            {
                Commit ultimo_Commit_LocalRepo = repo.zona.localRepo.commits[repo.zona.localRepo.commits.Count - 1];
                List<Archivo> copia_Archivos_LocalRepo = ultimo_Commit_LocalRepo.archivos;

                List<Archivo> archivos_Comunes = new List<Archivo>();

                List<int> indices_Index = new List<int>();
                List<int> indices_LocalRepo = new List<int>();

                int i = 0;  // Para Index
                int k;  // Para Local Repository

                // Busco las coincidencias en ambas listas y guardo los archivos que coinciden
                foreach (Archivo archivoI in copia_Archivos_Index) 
                {
                    k = 0;
                    foreach (Archivo archivoLR in copia_Archivos_LocalRepo)
                    {
                        if (archivoI.nombre.Equals(archivoLR.nombre)) 
                        {
                            archivos_Comunes.Add(archivoI);
                            archivos_Comunes.Add(archivoLR);

                            indices_Index.Add(i);
                            indices_LocalRepo.Add(k);
                        }
                        k++;
                    }
                    i++;
                }

                // Elimino las coincidencias de ambas listas
                for (int v = 0; v < indices_Index.Count; v++)
                {
                    copia_Archivos_Index.RemoveAt(indices_Index[v]);
                    copia_Archivos_LocalRepo.RemoveAt(indices_LocalRepo[v]);
                }

                // Se compara el contenido de los archivos con el mismo nombre y se agrega el prefijo correspondiente a igual o modificado
                for (int v = 0; v < (archivos_Comunes.Count / 2); v+=2)
                {
                    if (archivos_Comunes[v].nombre.Equals(archivos_Comunes[v+1].nombre)) 
                    {
                        if (archivos_Comunes[v].contenido.Equals(archivos_Comunes[v + 1].contenido)) 
                        {
                            aux = "\0";
                            aux = igual + archivos_Comunes[v].nombre;
                            cambios.Add(aux);
                        }
                        else 
                        {
                            aux = "\0";
                            aux = modificar + archivos_Comunes[v].nombre;
                            cambios.Add(aux);
                        }
                    }
                }

                // Sabiendo que se eliminaron las instancias repetidas de cada lista (copia_Archivos_Index y copia_Archivos_Index)
                // podemos saber que los archivos nuevos son los que quedan en copia_Archivos_Index y los archivos eliminados son los
                // que quedan en copia_Archivos_LocalRepo

                foreach (Archivo archivo in copia_Archivos_Index) 
                {
                    aux = "\0";
                    aux = agregar + archivo.nombre;
                    cambios.Add(aux);
                }

                foreach (Archivo archivo in copia_Archivos_LocalRepo)
                {
                    aux = "\0";
                    aux = eliminar + archivo.nombre;
                    cambios.Add(aux);
                }

            }

            return cambios;
        }


        // Funcion que busca los archivos correspondientes a los Items entregados en el Index.
        // Entrada: repo de tipo Repositorio y un List de tipo Object.
        // Salida: Un List de tipo Archivo con los archivos que coinciden.
        private List<Archivo> rescatar_Archivos(Repositorio repo, List<object> items)
        {
            List<Archivo> archivos = new List<Archivo>();

            foreach (Object item in items)
            {
                foreach (Archivo archivo in repo.zona.index.archivos)
                {
                    if (archivo.nombre.Equals(item.ToString()))
                    {
                        archivos.Add(archivo);
                    }
                }
            }

            return archivos;
        }
    }
}
