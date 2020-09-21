using Prueba.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Prueba.View
{
    public partial class VistaAdd : Form
    {
        private Repositorio repo;

        private const int CP_NOCLOSE_BUTTON = 0x200;

        public VistaAdd()
        {
            InitializeComponent();
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

        private void VistaAdd_Load(object sender, EventArgs e)
        {
            foreach (Archivo elemento in Repo.zona.workSpace.archivos)
            {
                ArchivosNoAgregados.Items.Add(elemento.nombre, false);
            }
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Vista3 vista = new Vista3();
            vista.Repo = repo;

            vista.Show();
            this.Close();
        }

        private void ArchivosNoAgregados_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = 0;
            List<Object> items = new List<Object>();
            foreach (Object item in ArchivosNoAgregados.Items)
            {
                if (ArchivosNoAgregados.GetItemChecked(i))
                {
                    ArchivosAgregados.Items.Add(item, true);
                    items.Add(item);
                    //ArchivosNoAgregados.Items.Remove(item);
                }
                i++;
            }

            foreach (Object item in items)
            {
                ArchivosNoAgregados.Items.Remove(item);
            }
        }

        private void ArchivosAgregados_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = 0;
            List<Object> items = new List<Object>();
            foreach (Object item in ArchivosAgregados.Items)
            {
                if (!(ArchivosAgregados.GetItemChecked(i)))
                {
                    ArchivosNoAgregados.Items.Add(item, false);
                    items.Add(item);
                    //ArchivosAgregados.Items.Remove(item);
                }
                i++;
            }

            foreach (Object item in items)
            {
                ArchivosAgregados.Items.Remove(item);
            }
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            List<Object> items = new List<Object>();
            foreach (Object item in ArchivosAgregados.Items)
            {
                items.Add(item);
            }

            repo = repo.gitAdd(repo, items);

            Vista3 vista = new Vista3();
            vista.Repo = repo;

            vista.Show();
            this.Hide();
        }
    }
}
