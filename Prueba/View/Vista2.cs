using Prueba.Model;
using System;
using System.Windows.Forms;

namespace Prueba.View
{
    public partial class Vista2 : Form
    {
 

        public Vista2()
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

        private void Atras_Click(object sender, EventArgs e)
        {
            Vista1 vista = new Vista1();
            vista.Show();

            this.Close();
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            Repositorio repo = main.gitInit(NombreRepo.Text, NombreAutor.Text);

            if(!(repo.nombre.Equals("null") && repo.autor.Equals("null"))) 
            {
                Vista3 vista = new Vista3();
                vista.Repo = repo;

                vista.Show();
                this.Hide();
            }


        }

    }
}
