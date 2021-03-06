﻿using System;

namespace Prueba.View
{
    partial class Vista3
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
            this.Add = new System.Windows.Forms.Button();
            this.Commit = new System.Windows.Forms.Button();
            this.Push = new System.Windows.Forms.Button();
            this.Pull = new System.Windows.Forms.Button();
            this.StatusWS = new System.Windows.Forms.Button();
            this.StatusI = new System.Windows.Forms.Button();
            this.StatusLR = new System.Windows.Forms.Button();
            this.StatusRR = new System.Windows.Forms.Button();
            this.LabelRepo = new System.Windows.Forms.Label();
            this.NombreRepo = new System.Windows.Forms.Label();
            this.LabelAutor = new System.Windows.Forms.Label();
            this.NombreAutor = new System.Windows.Forms.Label();
            this.Salir = new System.Windows.Forms.Button();
            this.NuevoArchivo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.SystemColors.Control;
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Add.Location = new System.Drawing.Point(125, 151);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(136, 46);
            this.Add.TabIndex = 2;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Commit
            // 
            this.Commit.BackColor = System.Drawing.SystemColors.Control;
            this.Commit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Commit.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Commit.Location = new System.Drawing.Point(328, 151);
            this.Commit.Name = "Commit";
            this.Commit.Size = new System.Drawing.Size(136, 46);
            this.Commit.TabIndex = 3;
            this.Commit.Text = "Commit";
            this.Commit.UseVisualStyleBackColor = false;
            this.Commit.Click += new System.EventHandler(this.Commit_Click);
            // 
            // Push
            // 
            this.Push.BackColor = System.Drawing.SystemColors.Control;
            this.Push.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Push.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Push.Location = new System.Drawing.Point(531, 151);
            this.Push.Name = "Push";
            this.Push.Size = new System.Drawing.Size(136, 46);
            this.Push.TabIndex = 4;
            this.Push.Text = "Push";
            this.Push.UseVisualStyleBackColor = false;
            this.Push.Click += new System.EventHandler(this.Push_Click);
            // 
            // Pull
            // 
            this.Pull.BackColor = System.Drawing.SystemColors.Control;
            this.Pull.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pull.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Pull.Location = new System.Drawing.Point(328, 339);
            this.Pull.Name = "Pull";
            this.Pull.Size = new System.Drawing.Size(136, 46);
            this.Pull.TabIndex = 5;
            this.Pull.Text = "Pull";
            this.Pull.UseVisualStyleBackColor = false;
            this.Pull.Click += new System.EventHandler(this.Pull_Click);
            // 
            // StatusWS
            // 
            this.StatusWS.BackColor = System.Drawing.SystemColors.Control;
            this.StatusWS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusWS.ForeColor = System.Drawing.SystemColors.Desktop;
            this.StatusWS.Location = new System.Drawing.Point(29, 245);
            this.StatusWS.Name = "StatusWS";
            this.StatusWS.Size = new System.Drawing.Size(136, 46);
            this.StatusWS.TabIndex = 6;
            this.StatusWS.Text = "Estado Work Space";
            this.StatusWS.UseVisualStyleBackColor = false;
            this.StatusWS.Click += new System.EventHandler(this.StatusWS_Click);
            // 
            // StatusI
            // 
            this.StatusI.BackColor = System.Drawing.SystemColors.Control;
            this.StatusI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusI.ForeColor = System.Drawing.SystemColors.Desktop;
            this.StatusI.Location = new System.Drawing.Point(232, 245);
            this.StatusI.Name = "StatusI";
            this.StatusI.Size = new System.Drawing.Size(136, 46);
            this.StatusI.TabIndex = 7;
            this.StatusI.Text = "Estado Index";
            this.StatusI.UseVisualStyleBackColor = false;
            this.StatusI.Click += new System.EventHandler(this.StatusI_Click);
            // 
            // StatusLR
            // 
            this.StatusLR.BackColor = System.Drawing.SystemColors.Control;
            this.StatusLR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLR.ForeColor = System.Drawing.SystemColors.Desktop;
            this.StatusLR.Location = new System.Drawing.Point(435, 245);
            this.StatusLR.Name = "StatusLR";
            this.StatusLR.Size = new System.Drawing.Size(136, 46);
            this.StatusLR.TabIndex = 8;
            this.StatusLR.Text = "Estado Local Repository";
            this.StatusLR.UseVisualStyleBackColor = false;
            this.StatusLR.Click += new System.EventHandler(this.StatusLR_Click);
            // 
            // StatusRR
            // 
            this.StatusRR.BackColor = System.Drawing.SystemColors.Control;
            this.StatusRR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusRR.ForeColor = System.Drawing.SystemColors.Desktop;
            this.StatusRR.Location = new System.Drawing.Point(638, 245);
            this.StatusRR.Name = "StatusRR";
            this.StatusRR.Size = new System.Drawing.Size(136, 46);
            this.StatusRR.TabIndex = 9;
            this.StatusRR.Text = "Estado Remote Repository";
            this.StatusRR.UseVisualStyleBackColor = false;
            this.StatusRR.Click += new System.EventHandler(this.StatusRR_Click);
            // 
            // LabelRepo
            // 
            this.LabelRepo.AutoSize = true;
            this.LabelRepo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRepo.Location = new System.Drawing.Point(24, 21);
            this.LabelRepo.Name = "LabelRepo";
            this.LabelRepo.Size = new System.Drawing.Size(220, 25);
            this.LabelRepo.TabIndex = 10;
            this.LabelRepo.Text = "Nombre del Repositorio:";
            // 
            // NombreRepo
            // 
            this.NombreRepo.AutoSize = true;
            this.NombreRepo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreRepo.Location = new System.Drawing.Point(250, 21);
            this.NombreRepo.Name = "NombreRepo";
            this.NombreRepo.Size = new System.Drawing.Size(0, 25);
            this.NombreRepo.TabIndex = 11;
            // 
            // LabelAutor
            // 
            this.LabelAutor.AutoSize = true;
            this.LabelAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAutor.Location = new System.Drawing.Point(24, 69);
            this.LabelAutor.Name = "LabelAutor";
            this.LabelAutor.Size = new System.Drawing.Size(167, 25);
            this.LabelAutor.TabIndex = 12;
            this.LabelAutor.Text = "Nombre del autor:";
            // 
            // NombreAutor
            // 
            this.NombreAutor.AutoSize = true;
            this.NombreAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreAutor.Location = new System.Drawing.Point(250, 69);
            this.NombreAutor.Name = "NombreAutor";
            this.NombreAutor.Size = new System.Drawing.Size(0, 25);
            this.NombreAutor.TabIndex = 13;
            // 
            // Salir
            // 
            this.Salir.BackColor = System.Drawing.SystemColors.Control;
            this.Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salir.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Salir.Location = new System.Drawing.Point(652, 12);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(136, 46);
            this.Salir.TabIndex = 14;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // NuevoArchivo
            // 
            this.NuevoArchivo.BackColor = System.Drawing.SystemColors.Control;
            this.NuevoArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevoArchivo.ForeColor = System.Drawing.SystemColors.Desktop;
            this.NuevoArchivo.Location = new System.Drawing.Point(29, 339);
            this.NuevoArchivo.Name = "NuevoArchivo";
            this.NuevoArchivo.Size = new System.Drawing.Size(136, 46);
            this.NuevoArchivo.TabIndex = 15;
            this.NuevoArchivo.Text = "Nuevo Archivo";
            this.NuevoArchivo.UseVisualStyleBackColor = false;
            this.NuevoArchivo.Click += new System.EventHandler(this.NuevoArchivo_Click);
            // 
            // Vista3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NuevoArchivo);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.NombreAutor);
            this.Controls.Add(this.LabelAutor);
            this.Controls.Add(this.NombreRepo);
            this.Controls.Add(this.LabelRepo);
            this.Controls.Add(this.StatusRR);
            this.Controls.Add(this.StatusLR);
            this.Controls.Add(this.StatusI);
            this.Controls.Add(this.StatusWS);
            this.Controls.Add(this.Pull);
            this.Controls.Add(this.Push);
            this.Controls.Add(this.Commit);
            this.Controls.Add(this.Add);
            this.Name = "Vista3";
            this.Text = "Vista3";
            this.Load += new System.EventHandler(this.Vista3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Commit;
        private System.Windows.Forms.Button Push;
        private System.Windows.Forms.Button Pull;
        private System.Windows.Forms.Button StatusWS;
        private System.Windows.Forms.Button StatusI;
        private System.Windows.Forms.Button StatusLR;
        private System.Windows.Forms.Button StatusRR;
        private System.Windows.Forms.Label LabelRepo;
        private System.Windows.Forms.Label NombreRepo;
        private System.Windows.Forms.Label LabelAutor;
        private System.Windows.Forms.Label NombreAutor;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Button NuevoArchivo;
    }
}