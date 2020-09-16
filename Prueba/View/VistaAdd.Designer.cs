namespace Prueba.View
{
    partial class VistaAdd
    {

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ArchivosNoAgregados = new System.Windows.Forms.CheckedListBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.ArchivosAgregados = new System.Windows.Forms.CheckedListBox();
            this.Aceptar = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ArchivosNoAgregados
            // 
            this.ArchivosNoAgregados.FormattingEnabled = true;
            this.ArchivosNoAgregados.Location = new System.Drawing.Point(12, 98);
            this.ArchivosNoAgregados.Name = "ArchivosNoAgregados";
            this.ArchivosNoAgregados.Size = new System.Drawing.Size(220, 319);
            this.ArchivosNoAgregados.TabIndex = 0;
            this.ArchivosNoAgregados.SelectedIndexChanged += new System.EventHandler(this.ArchivosNoAgregados_SelectedIndexChanged);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(7, 55);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(190, 25);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Archivos sin agregar";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(323, 55);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(189, 25);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "Archivos Agregados";
            // 
            // ArchivosAgregados
            // 
            this.ArchivosAgregados.FormattingEnabled = true;
            this.ArchivosAgregados.Location = new System.Drawing.Point(328, 98);
            this.ArchivosAgregados.Name = "ArchivosAgregados";
            this.ArchivosAgregados.Size = new System.Drawing.Size(220, 319);
            this.ArchivosAgregados.TabIndex = 3;
            this.ArchivosAgregados.SelectedIndexChanged += new System.EventHandler(this.ArchivosAgregados_SelectedIndexChanged);
            // 
            // Aceptar
            // 
            this.Aceptar.BackColor = System.Drawing.SystemColors.Control;
            this.Aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aceptar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Aceptar.Location = new System.Drawing.Point(412, 436);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(136, 46);
            this.Aceptar.TabIndex = 8;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.UseVisualStyleBackColor = false;
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // Salir
            // 
            this.Salir.BackColor = System.Drawing.SystemColors.Control;
            this.Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salir.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Salir.Location = new System.Drawing.Point(12, 436);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(136, 46);
            this.Salir.TabIndex = 9;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // VistaAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(560, 494);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.ArchivosAgregados);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.ArchivosNoAgregados);
            this.Name = "VistaAdd";
            this.Text = "VistaAdd";
            this.Load += new System.EventHandler(this.VistaAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox ArchivosNoAgregados;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.CheckedListBox ArchivosAgregados;
        private System.Windows.Forms.Button Aceptar;
        private System.Windows.Forms.Button Salir;
    }
}