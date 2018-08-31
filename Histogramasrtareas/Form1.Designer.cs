namespace Histogramasrtareas
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btnImagen = new System.Windows.Forms.Button();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.btnGris = new System.Windows.Forms.Button();
            this.imageBox2 = new Emgu.CV.UI.ImageBox();
            this.btnHistAzul = new System.Windows.Forms.Button();
            this.histogramBox1 = new Emgu.CV.UI.HistogramBox();
            this.histogramBox2 = new Emgu.CV.UI.HistogramBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.histogramBox3 = new Emgu.CV.UI.HistogramBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImagen
            // 
            this.btnImagen.Location = new System.Drawing.Point(30, 13);
            this.btnImagen.Name = "btnImagen";
            this.btnImagen.Size = new System.Drawing.Size(75, 23);
            this.btnImagen.TabIndex = 0;
            this.btnImagen.Text = "CargarImagen";
            this.btnImagen.UseVisualStyleBackColor = true;
            this.btnImagen.Click += new System.EventHandler(this.button1_Click);
            // 
            // imageBox1
            // 
            this.imageBox1.Location = new System.Drawing.Point(13, 43);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(341, 206);
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // btnGris
            // 
            this.btnGris.Location = new System.Drawing.Point(499, 14);
            this.btnGris.Name = "btnGris";
            this.btnGris.Size = new System.Drawing.Size(75, 23);
            this.btnGris.TabIndex = 3;
            this.btnGris.Text = "Gris";
            this.btnGris.UseVisualStyleBackColor = true;
            this.btnGris.Click += new System.EventHandler(this.btnGris_Click);
            // 
            // imageBox2
            // 
            this.imageBox2.Location = new System.Drawing.Point(361, 43);
            this.imageBox2.Name = "imageBox2";
            this.imageBox2.Size = new System.Drawing.Size(353, 206);
            this.imageBox2.TabIndex = 2;
            this.imageBox2.TabStop = false;
            // 
            // btnHistAzul
            // 
            this.btnHistAzul.Location = new System.Drawing.Point(129, 267);
            this.btnHistAzul.Name = "btnHistAzul";
            this.btnHistAzul.Size = new System.Drawing.Size(96, 23);
            this.btnHistAzul.TabIndex = 4;
            this.btnHistAzul.Text = "HistogramaAzul";
            this.btnHistAzul.UseVisualStyleBackColor = true;
            this.btnHistAzul.Click += new System.EventHandler(this.btnHistAzul_Click);
            // 
            // histogramBox1
            // 
            this.histogramBox1.Location = new System.Drawing.Point(13, 307);
            this.histogramBox1.Name = "histogramBox1";
            this.histogramBox1.Size = new System.Drawing.Size(356, 230);
            this.histogramBox1.TabIndex = 5;
            // 
            // histogramBox2
            // 
            this.histogramBox2.Location = new System.Drawing.Point(375, 307);
            this.histogramBox2.Name = "histogramBox2";
            this.histogramBox2.Size = new System.Drawing.Size(339, 230);
            this.histogramBox2.TabIndex = 6;
            this.histogramBox2.Load += new System.EventHandler(this.histogramBox2_Load);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(499, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "HistogramaVerde";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(311, 554);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "HistogramaRojo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // histogramBox3
            // 
            this.histogramBox3.Location = new System.Drawing.Point(98, 597);
            this.histogramBox3.Name = "histogramBox3";
            this.histogramBox3.Size = new System.Drawing.Size(562, 230);
            this.histogramBox3.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 851);
            this.Controls.Add(this.histogramBox3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.histogramBox2);
            this.Controls.Add(this.histogramBox1);
            this.Controls.Add(this.btnHistAzul);
            this.Controls.Add(this.imageBox2);
            this.Controls.Add(this.btnGris);
            this.Controls.Add(this.imageBox1);
            this.Controls.Add(this.btnImagen);
            this.Name = "Form1";
            this.Text = "HistogramaTreas";
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnImagen;
        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.Button btnGris;
        private Emgu.CV.UI.ImageBox imageBox2;
        private System.Windows.Forms.Button btnHistAzul;
        private Emgu.CV.UI.HistogramBox histogramBox1;
        private Emgu.CV.UI.HistogramBox histogramBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Emgu.CV.UI.HistogramBox histogramBox3;
    }
}

