using Prueba.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Prueba.View
{
    public partial class Vista3 : Form
    {
        private const int CP_NOCLOSE_BUTTON = 0x200;

        private Repositorio repo;

        public Vista3()
        {
            InitializeComponent();
        }

        private void Vista3_Load(object sender, EventArgs e)
        {
            NombreAutor.Text = repo.autor;
            NombreRepo.Text = repo.nombre;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        internal Repositorio Repo { get => repo; set => repo = value; }

        private void NuevoArchivo_Click(object sender, EventArgs e)
        {
            VistaNuevoArchivo archivo = new VistaNuevoArchivo();
            archivo.Show();
            archivo.Repo = this.repo;
            this.Hide();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Vista2 vista = new Vista2();
            vista.Show();
            this.Hide();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (Repo.zona.workSpace.archivos.Count == 0)
            {
                MessageBox.Show("Porfavor agrege archivos al Work Space antes de añadirlos a Index");
            }
            else
            {
                VistaAdd vista = new VistaAdd();

                vista.Repo = repo;
                vista.Show();
                this.Hide();
            }

        }

        private void Commit_Click(object sender, EventArgs e)
        {
            if (repo.zona.index.archivos.Count != 0)
            {
                VistaCommit1 vista = new VistaCommit1();
                vista.Repo = repo;

                vista.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No existen Archivos en el Index");
            }

        }

        private void Push_Click(object sender, EventArgs e)
        {
            if (repo.zona.localRepo.commits.Count != 0)
            {
                repo.zona.remoteRepo.commits.Clear();
                foreach (Commit commit in repo.zona.localRepo.commits)
                {
                    repo.zona.remoteRepo.commits.Add(commit);
                }
                repo.zona.remoteRepo.estado_actualizacion = true;

                MessageBox.Show("Proceso exitoso");
            }
            else
            {
                MessageBox.Show("No existen Commits en el Local Repository");
            }

        }

        private void Pull_Click(object sender, EventArgs e)
        {
            if (repo.zona.remoteRepo.commits.Count != 0)
            {
                List<Archivo> archivos_RR = repo.zona.remoteRepo.commits[repo.zona.remoteRepo.commits.Count - 1].archivos;
                List<Archivo> archivos_WS = repo.zona.workSpace.archivos;

                IEnumerable<Archivo> aux = archivos_RR.Union(archivos_WS);
                List<Archivo> union = aux.ToList();

                repo.zona.workSpace.archivos = union;

                MessageBox.Show("Proceso exitoso");
            }
            else
            {
                MessageBox.Show("No existen Commits en el Remote Repository");
            }

        }

        private void StatusWS_Click(object sender, EventArgs e)
        {
            VistaStatusWS vista = new VistaStatusWS();
            vista.Archivos = this.repo.zona.workSpace.archivos;
            vista.Show();
        }

        private void StatusI_Click(object sender, EventArgs e)
        {
            VistaStatusI vista = new VistaStatusI();
            vista.Archivos = this.repo.zona.index.archivos;
            vista.Show();
        }

        private void StatusLR_Click(object sender, EventArgs e)
        {
            VistaStatusLR vista = new VistaStatusLR();
            vista.Commits = this.repo.zona.localRepo.commits;
            vista.Show();
        }

        private void StatusRR_Click(object sender, EventArgs e)
        {
            VistaStatusRR vista = new VistaStatusRR();
            vista.Commits = repo.zona.remoteRepo.commits;
            vista.estado = repo.zona.remoteRepo.estado_actualizacion;

            vista.Show();
        }

    }
}
