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
    public partial class VistaAdd : Form
    {
        private Repositorio repo;

        public VistaAdd()
        {
            InitializeComponent();
        }

        internal Repositorio Repo { get => repo; set => repo = value; }

        private void VistaAdd_Load(object sender, EventArgs e)
        {
            foreach (Archivo elemento in this.repo.zona.workSpace.archivos)
            {
                ArchivosNoAgregados.Items.Add(elemento.nombre, false);
            }
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
