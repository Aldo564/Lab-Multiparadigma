﻿using Prueba.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            }
            else 
            {
                repo = entrada_Datos(nombreRepo, nombreAutor);

                List<Archivo> archivos_ws = null;
                List<Archivo> archivos_i = null;
                List<Archivo> archivos_commit = null;

                List<Commit> commits_lr = null;
                List<Commit> commits_rr = null;
                List<String> strings = null;
                String vacio = "";
                Commit commit = new Commit(vacio, vacio, vacio, strings, archivos_commit);

                WorkSpace ws = new WorkSpace(archivos_ws);
                Index i = new Index(archivos_i, vacio, vacio, vacio, commit);
                LocalRepo lr = new LocalRepo(commits_lr);
                RemoteRepo rr = new RemoteRepo(commits_rr);

                Zones zona = new Zones(ws, i, lr, rr);

                repo.zona = zona;

                
            }

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