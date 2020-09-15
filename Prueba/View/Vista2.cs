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
    public partial class Vista2 : Form
    {
 

        public Vista2()
        {
            InitializeComponent();
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

            Vista3 vista = new Vista3();
            vista.repo = repo;

            vista.Show();
            this.Hide();


        }

    }
}
