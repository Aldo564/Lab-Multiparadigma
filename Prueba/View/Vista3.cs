using Prueba.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            VistaAdd vista = new VistaAdd();

            if (Repo.zona.workSpace.archivos.Count == 0) 
            {
                MessageBox.Show("Porfavor agrege archivos al Work Space antes de añadirlos a Index");
            }
            else
            {
                
                vista.Repo = repo;
                vista.Show();
                this.Hide();
            }
            
        }

        private void Commit_Click(object sender, EventArgs e)
        {
            VistaCommit1 vista = new VistaCommit1();
            vista.Repo = repo;

            vista.Show();
            this.Hide();
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

        private void Push_Click(object sender, EventArgs e)
        {
            repo.zona.remoteRepo.commits = repo.zona.localRepo.commits;
            repo.zona.remoteRepo.estado_actualizacion = true;
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
