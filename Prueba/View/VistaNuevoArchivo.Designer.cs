namespace Prueba.View
{
    partial class VistaNuevoArchivo
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
            this.LabelNombreArchivo = new System.Windows.Forms.Label();
            this.NombreArchivo = new System.Windows.Forms.TextBox();
            this.LabelContenido = new System.Windows.Forms.Label();
            this.NombreContenido = new System.Windows.Forms.TextBox();
            this.crear = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelNombreArchivo
            // 
            this.LabelNombreArchivo.AutoSize = true;
            this.LabelNombreArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNombreArchivo.Location = new System.Drawing.Point(12, 28);
            this.LabelNombreArchivo.Name = "LabelNombreArchivo";
            this.LabelNombreArchivo.Size = new System.Drawing.Size(380, 25);
            this.LabelNombreArchivo.TabIndex = 0;
            this.LabelNombreArchivo.Text = "Ingrese nombre del archivo (sin extension)";
            // 
            // NombreArchivo
            // 
            this.NombreArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreArchivo.Location = new System.Drawing.Point(17, 56);
            this.NombreArchivo.Name = "NombreArchivo";
            this.NombreArchivo.Size = new System.Drawing.Size(375, 30);
            this.NombreArchivo.TabIndex = 1;
            // 
            // LabelContenido
            // 
            this.LabelContenido.AutoSize = true;
            this.LabelContenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelContenido.Location = new System.Drawing.Point(12, 112);
            this.LabelContenido.Name = "LabelContenido";
            this.LabelContenido.Size = new System.Drawing.Size(286, 25);
            this.LabelContenido.TabIndex = 2;
            this.LabelContenido.Text = "Ingrese el contenido del archivo";
            // 
            // NombreContenido
            // 
            this.NombreContenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreContenido.Location = new System.Drawing.Point(17, 140);
            this.NombreContenido.Multiline = true;
            this.NombreContenido.Name = "NombreContenido";
            this.NombreContenido.Size = new System.Drawing.Size(375, 380);
            this.NombreContenido.TabIndex = 3;
            // 
            // crear
            // 
            this.crear.BackColor = System.Drawing.SystemColors.Control;
            this.crear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crear.ForeColor = System.Drawing.SystemColors.Desktop;
            this.crear.Location = new System.Drawing.Point(256, 526);
            this.crear.Name = "crear";
            this.crear.Size = new System.Drawing.Size(136, 46);
            this.crear.TabIndex = 6;
            this.crear.Text = "Crear";
            this.crear.UseVisualStyleBackColor = false;
            this.crear.Click += new System.EventHandler(this.crear_Click);
            // 
            // Salir
            // 
            this.Salir.BackColor = System.Drawing.SystemColors.Control;
            this.Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salir.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Salir.Location = new System.Drawing.Point(17, 526);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(136, 46);
            this.Salir.TabIndex = 7;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // VistaNuevoArchivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(407, 582);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.crear);
            this.Controls.Add(this.NombreContenido);
            this.Controls.Add(this.LabelContenido);
            this.Controls.Add(this.NombreArchivo);
            this.Controls.Add(this.LabelNombreArchivo);
            this.Name = "VistaNuevoArchivo";
            this.Text = "VistaNuevoArchivo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelNombreArchivo;
        private System.Windows.Forms.TextBox NombreArchivo;
        private System.Windows.Forms.Label LabelContenido;
        private System.Windows.Forms.TextBox NombreContenido;
        private System.Windows.Forms.Button crear;
        private System.Windows.Forms.Button Salir;
    }
}