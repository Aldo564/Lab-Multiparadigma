namespace Prueba
{
    partial class Vista1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vista1));
            this.GitInit = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.Titulo1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Titulo2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GitInit
            // 
            this.GitInit.BackColor = System.Drawing.SystemColors.Control;
            this.GitInit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GitInit.ForeColor = System.Drawing.SystemColors.Desktop;
            this.GitInit.Location = new System.Drawing.Point(536, 302);
            this.GitInit.Name = "GitInit";
            this.GitInit.Size = new System.Drawing.Size(136, 46);
            this.GitInit.TabIndex = 0;
            this.GitInit.Text = "Inicializar Repositorio";
            this.GitInit.UseVisualStyleBackColor = false;
            this.GitInit.Click += new System.EventHandler(this.GitInit_Click);
            // 
            // Salir
            // 
            this.Salir.BackColor = System.Drawing.SystemColors.Control;
            this.Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salir.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Salir.Location = new System.Drawing.Point(132, 302);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(136, 46);
            this.Salir.TabIndex = 1;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // Titulo1
            // 
            this.Titulo1.AutoSize = true;
            this.Titulo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 65F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo1.Location = new System.Drawing.Point(292, 51);
            this.Titulo1.Name = "Titulo1";
            this.Titulo1.Size = new System.Drawing.Size(496, 112);
            this.Titulo1.TabIndex = 5;
            this.Titulo1.Text = "Abstraccion";
            this.Titulo1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Titulo1.UseCompatibleTextRendering = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-49, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(335, 239);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Titulo2
            // 
            this.Titulo2.AutoSize = true;
            this.Titulo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 65F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo2.Location = new System.Drawing.Point(292, 163);
            this.Titulo2.Name = "Titulo2";
            this.Titulo2.Size = new System.Drawing.Size(154, 98);
            this.Titulo2.TabIndex = 7;
            this.Titulo2.Text = "Git";
            // 
            // Vista1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Titulo2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Titulo1);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.GitInit);
            this.Name = "Vista1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GitInit;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Label Titulo1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Titulo2;
    }
}

