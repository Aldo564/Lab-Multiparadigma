namespace Prueba.View
{
    partial class Vista2
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
            this.label2 = new System.Windows.Forms.Label();
            this.NombreRepo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NombreAutor = new System.Windows.Forms.TextBox();
            this.Atras = new System.Windows.Forms.Button();
            this.Aceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Label1.Location = new System.Drawing.Point(40, 54);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(331, 31);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Ingrese los datos pedidos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(41, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del Repositorio:";
            // 
            // NombreRepo
            // 
            this.NombreRepo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreRepo.Location = new System.Drawing.Point(267, 112);
            this.NombreRepo.Name = "NombreRepo";
            this.NombreRepo.Size = new System.Drawing.Size(304, 38);
            this.NombreRepo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(41, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre del Autor:";
            // 
            // NombreAutor
            // 
            this.NombreAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreAutor.Location = new System.Drawing.Point(267, 169);
            this.NombreAutor.Name = "NombreAutor";
            this.NombreAutor.Size = new System.Drawing.Size(304, 38);
            this.NombreAutor.TabIndex = 4;
            // 
            // Atras
            // 
            this.Atras.BackColor = System.Drawing.SystemColors.Control;
            this.Atras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Atras.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Atras.Location = new System.Drawing.Point(46, 343);
            this.Atras.Name = "Atras";
            this.Atras.Size = new System.Drawing.Size(136, 46);
            this.Atras.TabIndex = 5;
            this.Atras.Text = "Atras";
            this.Atras.UseVisualStyleBackColor = false;
            this.Atras.Click += new System.EventHandler(this.Atras_Click);
            // 
            // Aceptar
            // 
            this.Aceptar.BackColor = System.Drawing.SystemColors.Control;
            this.Aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aceptar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Aceptar.Location = new System.Drawing.Point(623, 343);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(136, 46);
            this.Aceptar.TabIndex = 6;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.UseVisualStyleBackColor = false;
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // Vista2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.Atras);
            this.Controls.Add(this.NombreAutor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NombreRepo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label1);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "Vista2";
            this.Text = "Vista2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NombreRepo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NombreAutor;
        private System.Windows.Forms.Button Atras;
        private System.Windows.Forms.Button Aceptar;
    }
}