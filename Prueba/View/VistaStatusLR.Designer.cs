namespace Prueba.View
{
    partial class VistaStatusLR
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
            this.Atras = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ArchivosCommit = new System.Windows.Forms.ListBox();
            this.CommitsLR = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(11, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(352, 31);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Estado del Local Repository";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Commits";
            // 
            // Atras
            // 
            this.Atras.BackColor = System.Drawing.SystemColors.Control;
            this.Atras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Atras.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Atras.Location = new System.Drawing.Point(211, 424);
            this.Atras.Name = "Atras";
            this.Atras.Size = new System.Drawing.Size(136, 46);
            this.Atras.TabIndex = 9;
            this.Atras.Text = "Cerrar";
            this.Atras.UseVisualStyleBackColor = false;
            this.Atras.Click += new System.EventHandler(this.Atras_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(316, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Archivos en el commit";
            // 
            // ArchivosCommit
            // 
            this.ArchivosCommit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArchivosCommit.FormattingEnabled = true;
            this.ArchivosCommit.ItemHeight = 15;
            this.ArchivosCommit.Location = new System.Drawing.Point(321, 99);
            this.ArchivosCommit.Name = "ArchivosCommit";
            this.ArchivosCommit.Size = new System.Drawing.Size(230, 319);
            this.ArchivosCommit.TabIndex = 11;
            // 
            // CommitsLR
            // 
            this.CommitsLR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommitsLR.FormattingEnabled = true;
            this.CommitsLR.ItemHeight = 15;
            this.CommitsLR.Location = new System.Drawing.Point(17, 99);
            this.CommitsLR.Name = "CommitsLR";
            this.CommitsLR.Size = new System.Drawing.Size(230, 319);
            this.CommitsLR.TabIndex = 12;
            this.CommitsLR.SelectedIndexChanged += new System.EventHandler(this.CommitsLR_SelectedIndexChanged);
            // 
            // VistaStatusLR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(565, 476);
            this.Controls.Add(this.CommitsLR);
            this.Controls.Add(this.ArchivosCommit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Atras);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label1);
            this.Name = "VistaStatusLR";
            this.Text = "VistaStatusLR";
            this.Load += new System.EventHandler(this.VistaStatusLR_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Atras;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox ArchivosCommit;
        private System.Windows.Forms.ListBox CommitsLR;
    }
}