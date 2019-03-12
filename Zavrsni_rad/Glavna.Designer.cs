using System;

namespace Zavrsni_rad
{
    partial class Glavna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Glavna));
            this.btnOsoba = new System.Windows.Forms.Button();
            this.btnUtrka = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOsoba
            // 
            this.btnOsoba.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnOsoba.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOsoba.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOsoba.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOsoba.Image = ((System.Drawing.Image)(resources.GetObject("btnOsoba.Image")));
            this.btnOsoba.Location = new System.Drawing.Point(23, 12);
            this.btnOsoba.Name = "btnOsoba";
            this.btnOsoba.Size = new System.Drawing.Size(241, 269);
            this.btnOsoba.TabIndex = 0;
            this.btnOsoba.Text = "Pregled, uređenje i dodavanje osoba";
            this.btnOsoba.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnOsoba.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnOsoba.UseVisualStyleBackColor = false;
            this.btnOsoba.Click += new System.EventHandler(this.btnOsoba_Click);
            // 
            // btnUtrka
            // 
            this.btnUtrka.BackColor = System.Drawing.Color.LimeGreen;
            this.btnUtrka.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUtrka.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUtrka.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUtrka.Image = ((System.Drawing.Image)(resources.GetObject("btnUtrka.Image")));
            this.btnUtrka.Location = new System.Drawing.Point(295, 12);
            this.btnUtrka.Name = "btnUtrka";
            this.btnUtrka.Size = new System.Drawing.Size(233, 269);
            this.btnUtrka.TabIndex = 1;
            this.btnUtrka.Text = "Pregled, uređenje i dodavanje utrka\r\n";
            this.btnUtrka.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnUtrka.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnUtrka.UseVisualStyleBackColor = false;
            this.btnUtrka.Click += new System.EventHandler(this.btnUtrka_Click);
            // 
            // Glavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 294);
            this.Controls.Add(this.btnUtrka);
            this.Controls.Add(this.btnOsoba);
            this.KeyPreview = true;
            this.Name = "Glavna";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Glavni izbornik";
            
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Glavna_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOsoba;
        private System.Windows.Forms.Button btnUtrka;
    }
}

