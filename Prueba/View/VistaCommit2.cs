using Prueba.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Prueba.View
{
    public partial class VistaCommit2 : Form
    {
        private Repositorio repo;
        public String nombre;
        public String autor;
        public String desc;

        public VistaCommit2()
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

        private void VistaCommit2_Load(object sender, EventArgs e)
        {
            foreach (Archivo elemento in Repo.zona.index.archivos)
            {
                ArchivosNoAgregados.Items.Add(elemento.nombre, false);
            }
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
            if (ArchivosAgregados.Items.Count == 0)
            {
                MessageBox.Show("Debe agregar como minimo un archivo para generar un Commit");
            }
            else
            {
                List<Object> items = new List<Object>();
                foreach (Object item in ArchivosAgregados.Items)
                {
                    items.Add(item);
                }

                repo = repo.gitCommit(repo, nombre, autor, desc, items);

                Vista3 vista = new Vista3();
                vista.Repo = repo;

                vista.Show();
                this.Hide();
            }
        }

        private void Atras_Click(object sender, EventArgs e)
        {
            VistaCommit1 vista = new VistaCommit1();
            vista.Repo = repo;

            vista.Show();
            this.Hide();
        }
    }
}
