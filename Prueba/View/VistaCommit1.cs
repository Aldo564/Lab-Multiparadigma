using Prueba.Model;
using System;
using System.Windows.Forms;

namespace Prueba.View
{
    public partial class VistaCommit1 : Form
    {

        private Repositorio repo;

        public VistaCommit1()
        {
            InitializeComponent();
        }

        internal Repositorio Repo { get => repo; set => repo = value; }

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

        private void Atras_Click(object sender, EventArgs e)
        {
            Vista3 vista = new Vista3();
            vista.Repo = repo;

            vista.Show();
            this.Hide();
        }

        private void Siguiente_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(NombreCommit.Text) || String.IsNullOrEmpty(AutorCommit.Text) || String.IsNullOrEmpty(DescCommit.Text))
            {
                MessageBox.Show("Rellene todos los campos para poder continuar");
            }
            else 
            {
                VistaCommit2 vista = new VistaCommit2();
                vista.Repo = repo;
                vista.nombre = NombreCommit.Text;
                vista.autor = AutorCommit.Text;
                vista.desc = DescCommit.Text;

                vista.Show();
                this.Hide();
            }
        }
    }
}
