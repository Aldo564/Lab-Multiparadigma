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

        private void NuevoArchivo_Click(object sender, EventArgs e)
        {
            VistaNuevoArchivo archivo = new VistaNuevoArchivo();
            archivo.Show();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Vista2 vista = new Vista2();
            vista.Show();
            this.Hide();
        }

        
    }
}
