using Prueba.View;
using System;
using System.Windows.Forms;

namespace Prueba
{
    public partial class Vista1 : Form
    {
        public Vista1()
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

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GitInit_Click(object sender, EventArgs e)
        {
            Vista2 vista = new Vista2();
            vista.Show();

            this.Hide();
        }
        void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
