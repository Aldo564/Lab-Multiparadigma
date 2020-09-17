namespace Prueba.View
{
    partial class VistaStatusRR
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
            this.CommitsRR = new System.Windows.Forms.ListBox();
            this.ArchivosCommit = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Atras = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Estado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CommitsRR
            // 
            this.CommitsRR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommitsRR.FormattingEnabled = true;
            this.CommitsRR.ItemHeight = 15;
            this.CommitsRR.Location = new System.Drawing.Point(14, 125);
            this.CommitsRR.Name = "CommitsRR";
            this.CommitsRR.Size = new System.Drawing.Size(230, 319);
            this.CommitsRR.TabIndex = 18;
            this.CommitsRR.SelectedIndexChanged += new System.EventHandler(this.CommitsRR_SelectedIndexChanged);
            // 
            // ArchivosCommit
            // 
            this.ArchivosCommit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArchivosCommit.FormattingEnabled = true;
            this.ArchivosCommit.ItemHeight = 15;
            this.ArchivosCommit.Location = new System.Drawing.Point(318, 125);
            this.ArchivosCommit.Name = "ArchivosCommit";
            this.ArchivosCommit.Size = new System.Drawing.Size(230, 319);
            this.ArchivosCommit.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(313, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Archivos en el commit";
            // 
            // Atras
            // 
            this.Atras.BackColor = System.Drawing.SystemColors.Control;
            this.Atras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Atras.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Atras.Location = new System.Drawing.Point(208, 450);
            this.Atras.Name = "Atras";
            this.Atras.Size = new System.Drawing.Size(136, 46);
            this.Atras.TabIndex = 15;
            this.Atras.Text = "Cerrar";
            this.Atras.UseVisualStyleBackColor = false;
            this.Atras.Click += new System.EventHandler(this.Atras_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Commits";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(9, 14);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(382, 31);
            this.Label1.TabIndex = 13;
            this.Label1.Text = "Estado del Remote Repository";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Estado:";
            // 
            // Estado
            // 
            this.Estado.AutoSize = true;
            this.Estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Estado.Location = new System.Drawing.Point(97, 45);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(0, 25);
            this.Estado.TabIndex = 20;
            // 
            // VistaStatusRR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(560, 502);
            this.Controls.Add(this.Estado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CommitsRR);
            this.Controls.Add(this.ArchivosCommit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Atras);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label1);
            this.Name = "VistaStatusRR";
            this.Text = "VistaStatusRR";
            this.Load += new System.EventHandler(this.VistaStatusRR_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox CommitsRR;
        private System.Windows.Forms.ListBox ArchivosCommit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Atras;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Estado;
    }
}