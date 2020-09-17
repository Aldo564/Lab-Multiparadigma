namespace Prueba.View
{
    partial class VistaCommit1
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
            this.NombreCommit = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.AutorCommit = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.DescCommit = new System.Windows.Forms.TextBox();
            this.Atras = new System.Windows.Forms.Button();
            this.Siguiente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(12, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(190, 25);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Nombre del Commit:";
            // 
            // NombreCommit
            // 
            this.NombreCommit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreCommit.Location = new System.Drawing.Point(208, 6);
            this.NombreCommit.Name = "NombreCommit";
            this.NombreCommit.Size = new System.Drawing.Size(287, 30);
            this.NombreCommit.TabIndex = 1;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(12, 45);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(168, 25);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "Autor del Commit:";
            // 
            // AutorCommit
            // 
            this.AutorCommit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutorCommit.Location = new System.Drawing.Point(208, 45);
            this.AutorCommit.Name = "AutorCommit";
            this.AutorCommit.Size = new System.Drawing.Size(287, 30);
            this.AutorCommit.TabIndex = 3;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(12, 85);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(344, 25);
            this.Label3.TabIndex = 4;
            this.Label3.Text = "Ingrese una descripcion de su Commit";
            // 
            // DescCommit
            // 
            this.DescCommit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescCommit.Location = new System.Drawing.Point(17, 113);
            this.DescCommit.Multiline = true;
            this.DescCommit.Name = "DescCommit";
            this.DescCommit.Size = new System.Drawing.Size(478, 339);
            this.DescCommit.TabIndex = 5;
            // 
            // Atras
            // 
            this.Atras.BackColor = System.Drawing.SystemColors.Control;
            this.Atras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Atras.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Atras.Location = new System.Drawing.Point(17, 461);
            this.Atras.Name = "Atras";
            this.Atras.Size = new System.Drawing.Size(136, 46);
            this.Atras.TabIndex = 10;
            this.Atras.Text = "Atras";
            this.Atras.UseVisualStyleBackColor = false;
            this.Atras.Click += new System.EventHandler(this.Atras_Click);
            // 
            // Siguiente
            // 
            this.Siguiente.BackColor = System.Drawing.SystemColors.Control;
            this.Siguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Siguiente.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Siguiente.Location = new System.Drawing.Point(359, 461);
            this.Siguiente.Name = "Siguiente";
            this.Siguiente.Size = new System.Drawing.Size(136, 46);
            this.Siguiente.TabIndex = 11;
            this.Siguiente.Text = "Siguiente";
            this.Siguiente.UseVisualStyleBackColor = false;
            this.Siguiente.Click += new System.EventHandler(this.Siguiente_Click);
            // 
            // VistaCommit1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(512, 519);
            this.Controls.Add(this.Siguiente);
            this.Controls.Add(this.Atras);
            this.Controls.Add(this.DescCommit);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.AutorCommit);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.NombreCommit);
            this.Controls.Add(this.Label1);
            this.Name = "VistaCommit1";
            this.Text = "VistaCommit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TextBox NombreCommit;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.TextBox AutorCommit;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.TextBox DescCommit;
        private System.Windows.Forms.Button Atras;
        private System.Windows.Forms.Button Siguiente;
    }
}