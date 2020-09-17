﻿using Prueba.Model;
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
    public partial class VistaStatusI : Form
    {

        private List<Archivo> archivos = new List<Archivo>();

        public VistaStatusI()
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

        internal List<Archivo> Archivos { get => archivos; set => archivos = value; }

        private void VistaStatusI_Load(object sender, EventArgs e)
        {
            foreach (Archivo element in archivos)
            {
                ArchivosI.Items.Add(element.nombre);
            }
        }

        private void Atras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}