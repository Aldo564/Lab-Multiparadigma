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
    public partial class VistaStatusRR : Form
    {

        private List<Commit> commits = new List<Commit>();
        public Boolean estado = false;

        public VistaStatusRR()
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

        internal List<Commit> Commits { get => commits; set => commits = value; }

        private void VistaStatusRR_Load(object sender, EventArgs e)
        {
            foreach (Commit element in Commits)
            {
                CommitsRR.Items.Add(element.nombre);
            }

            if (estado) 
            {
                Estado.Text = "Actualizado";
            }
            else 
            {
                Estado.Text = "No Actualizado";
            }

        }

        private void Atras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CommitsRR_SelectedIndexChanged(object sender, EventArgs e)
        {
            Object item_Marcado = CommitsRR.SelectedItem;

            if (item_Marcado != null)
            {
                List<Object> items = new List<Object>();
                foreach (Object item in ArchivosCommit.Items)
                {
                    items.Add(item);
                }

                foreach (Object item in items)
                {
                    ArchivosCommit.Items.Remove(item);
                }

                foreach (Commit commit in Commits)
                {
                    if (commit.nombre.Equals(item_Marcado.ToString()))
                    {
                        foreach (Archivo archivo in commit.archivos)
                        {
                            ArchivosCommit.Items.Add(archivo.nombre);
                        }
                    }
                }
            }
        }
    }
}
