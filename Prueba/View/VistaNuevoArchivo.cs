using Prueba.Model;
using System;
using System.Windows.Forms;

namespace Prueba.View
{
    public partial class VistaNuevoArchivo : Form
    {
        private Repositorio repo;

        public VistaNuevoArchivo()
        {
            InitializeComponent();
        }

        private const int CP_NOCLOSE_BUTTON = 0x200;
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

        private void Salir_Click(object sender, EventArgs e)
        {
            Vista3 vista = new Vista3();
            vista.Repo = repo;
            vista.Show();
            this.Hide();

        }

        private void crear_Click(object sender, EventArgs e)
        {
            Vista3 vista = new Vista3();

            repo = repo.CrearArchivo(repo, NombreArchivo.Text, NombreContenido.Text);

            vista.Repo = repo;

            vista.Show();
            this.Hide();
        }
    }
}
