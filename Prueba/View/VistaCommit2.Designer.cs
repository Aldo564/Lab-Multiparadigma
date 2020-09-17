namespace Prueba.View
{
    partial class VistaCommit2
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
            this.Label1 = new System.Windows.Forms.Label();
            this.ArchivosAgregados = new System.Windows.Forms.CheckedListBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ArchivosNoAgregados = new System.Windows.Forms.CheckedListBox();
            this.Atras = new System.Windows.Forms.Button();
            this.Aceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(12, 24);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(168, 25);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Archivos en Index";
            // 
            // ArchivosAgregados
            // 
            this.ArchivosAgregados.FormattingEnabled = true;
            this.ArchivosAgregados.Location = new System.Drawing.Point(333, 93);
            this.ArchivosAgregados.Name = "ArchivosAgregados";
            this.ArchivosAgregados.Size = new System.Drawing.Size(220, 319);
            this.ArchivosAgregados.TabIndex = 7;
            this.ArchivosAgregados.SelectedIndexChanged += new System.EventHandler(this.ArchivosAgregados_SelectedIndexChanged);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(328, 65);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(189, 25);
            this.Label2.TabIndex = 6;
            this.Label2.Text = "Archivos Agregados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Archivos sin agregar";
            // 
            // ArchivosNoAgregados
            // 
            this.ArchivosNoAgregados.FormattingEnabled = true;
            this.ArchivosNoAgregados.Location = new System.Drawing.Point(17, 93);
            this.ArchivosNoAgregados.Name = "ArchivosNoAgregados";
            this.ArchivosNoAgregados.Size = new System.Drawing.Size(220, 319);
            this.ArchivosNoAgregados.TabIndex = 4;
            this.ArchivosNoAgregados.SelectedIndexChanged += new System.EventHandler(this.ArchivosNoAgregados_SelectedIndexChanged);
            // 
            // Atras
            // 
            this.Atras.BackColor = System.Drawing.SystemColors.Control;
            this.Atras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Atras.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Atras.Location = new System.Drawing.Point(17, 436);
            this.Atras.Name = "Atras";
            this.Atras.Size = new System.Drawing.Size(136, 46);
            this.Atras.TabIndex = 10;
            this.Atras.Text = "Atras";
            this.Atras.UseVisualStyleBackColor = false;
            this.Atras.Click += new System.EventHandler(this.Atras_Click);
            // 
            // Aceptar
            // 
            this.Aceptar.BackColor = System.Drawing.SystemColors.Control;
            this.Aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aceptar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Aceptar.Location = new System.Drawing.Point(417, 436);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(136, 46);
            this.Aceptar.TabIndex = 11;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.UseVisualStyleBackColor = false;
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // VistaCommit2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(577, 494);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.Atras);
            this.Controls.Add(this.ArchivosAgregados);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ArchivosNoAgregados);
            this.Controls.Add(this.Label1);
            this.Name = "VistaCommit2";
            this.Text = "VistaCommit2";
            this.Load += new System.EventHandler(this.VistaCommit2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.CheckedListBox ArchivosAgregados;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox ArchivosNoAgregados;
        private System.Windows.Forms.Button Atras;
        private System.Windows.Forms.Button Aceptar;
    }
}