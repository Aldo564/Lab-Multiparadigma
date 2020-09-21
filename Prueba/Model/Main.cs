using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Prueba.Model
{
    class Main
    {

        public Repositorio repositorio;

        // Funcion que inicializara el repositorio
        // Entrada: no tiene.
        // Salida: no tiene.
        public Repositorio gitInit(String nombreRepo, String nombreAutor)
        {
            Repositorio repo = null;

            if (nombreRepo.Equals("") || nombreAutor.Equals(""))
            {
                MessageBox.Show("Porfavor complete todos los campos.");
                repo = entrada_Datos("null", "null");
            }
            else
            {
                repo = entrada_Datos(nombreRepo, nombreAutor);
            }

            List<Archivo> archivos_ws = new List<Archivo>();
            List<Archivo> archivos_i = new List<Archivo>();
            List<Archivo> archivos_commit = new List<Archivo>();

            List<Commit> commits_lr = new List<Commit>();
            List<Commit> commits_rr = new List<Commit>();
            List<String> strings = new List<String>();
            String vacio = "";
            Commit commit = new Commit(vacio, vacio, vacio, vacio, strings, archivos_commit);

            WorkSpace ws = new WorkSpace(archivos_ws);
            Index i = new Index(archivos_i, vacio, vacio, vacio, commit);
            LocalRepo lr = new LocalRepo(commits_lr);
            RemoteRepo rr = new RemoteRepo(commits_rr);

            Zones zona = new Zones(ws, i, lr, rr);

            repo.zona = zona;

            this.repositorio = repo;
            return repo;
        }

        private Repositorio entrada_Datos(String nombreRepo, String nombreAutor)
        {
            DateTime date = DateTime.Now;
            String format = "G";
            String fecha = date.ToString(format);

            Repositorio repo = new Repositorio(nombreRepo, nombreAutor, fecha);

            return repo;
        }
    }
}
