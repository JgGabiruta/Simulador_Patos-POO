namespace Simulador_Patos_POO
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Anterior = new System.Windows.Forms.Button();
            this.Proximo = new System.Windows.Forms.Button();
            this.habilidade1 = new System.Windows.Forms.Label();
            this.habilidade2 = new System.Windows.Forms.Label();
            this.display_Pato = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.habilidade3 = new System.Windows.Forms.Label();
            this.Escolhe_Pato = new System.Windows.Forms.Button();
            this.ImagemPato = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImagemPato)).BeginInit();
            this.SuspendLayout();
            // 
            // Anterior
            // 
            this.Anterior.Location = new System.Drawing.Point(26, 286);
            this.Anterior.Name = "Anterior";
            this.Anterior.Size = new System.Drawing.Size(78, 35);
            this.Anterior.TabIndex = 0;
            this.Anterior.Text = "Anterior";
            this.Anterior.UseVisualStyleBackColor = true;
            this.Anterior.Click += new System.EventHandler(this.Anterior_Click);
            // 
            // Proximo
            // 
            this.Proximo.Location = new System.Drawing.Point(164, 286);
            this.Proximo.Name = "Proximo";
            this.Proximo.Size = new System.Drawing.Size(94, 35);
            this.Proximo.TabIndex = 1;
            this.Proximo.Text = "Proximo";
            this.Proximo.UseVisualStyleBackColor = true;
            this.Proximo.Click += new System.EventHandler(this.Proximo_Click);
            // 
            // habilidade1
            // 
            this.habilidade1.AutoSize = true;
            this.habilidade1.Location = new System.Drawing.Point(69, 142);
            this.habilidade1.Name = "habilidade1";
            this.habilidade1.Size = new System.Drawing.Size(98, 20);
            this.habilidade1.TabIndex = 3;
            this.habilidade1.Text = "Habilidade-1";
            this.habilidade1.Click += new System.EventHandler(this.habilidade1_Click);
            // 
            // habilidade2
            // 
            this.habilidade2.AutoSize = true;
            this.habilidade2.Location = new System.Drawing.Point(69, 176);
            this.habilidade2.Name = "habilidade2";
            this.habilidade2.Size = new System.Drawing.Size(98, 20);
            this.habilidade2.TabIndex = 4;
            this.habilidade2.Text = "Habilidade-2";
            // 
            // display_Pato
            // 
            this.display_Pato.AutoSize = true;
            this.display_Pato.Location = new System.Drawing.Point(69, 107);
            this.display_Pato.Name = "display_Pato";
            this.display_Pato.Size = new System.Drawing.Size(51, 20);
            this.display_Pato.TabIndex = 5;
            this.display_Pato.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Escolha o pato";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // habilidade3
            // 
            this.habilidade3.AutoSize = true;
            this.habilidade3.Location = new System.Drawing.Point(69, 211);
            this.habilidade3.Name = "habilidade3";
            this.habilidade3.Size = new System.Drawing.Size(98, 20);
            this.habilidade3.TabIndex = 7;
            this.habilidade3.Text = "Habilidade-3";
            // 
            // Escolhe_Pato
            // 
            this.Escolhe_Pato.Location = new System.Drawing.Point(87, 349);
            this.Escolhe_Pato.Name = "Escolhe_Pato";
            this.Escolhe_Pato.Size = new System.Drawing.Size(111, 36);
            this.Escolhe_Pato.TabIndex = 8;
            this.Escolhe_Pato.Text = "Escolher";
            this.Escolhe_Pato.UseVisualStyleBackColor = true;
            this.Escolhe_Pato.Click += new System.EventHandler(this.Escolhe_Pato_Click);
            // 
            // ImagemPato
            // 
            this.ImagemPato.Location = new System.Drawing.Point(434, 13);
            this.ImagemPato.Name = "ImagemPato";
            this.ImagemPato.Size = new System.Drawing.Size(354, 267);
            this.ImagemPato.TabIndex = 9;
            this.ImagemPato.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ImagemPato);
            this.Controls.Add(this.Escolhe_Pato);
            this.Controls.Add(this.habilidade3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.display_Pato);
            this.Controls.Add(this.habilidade2);
            this.Controls.Add(this.habilidade1);
            this.Controls.Add(this.Proximo);
            this.Controls.Add(this.Anterior);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ImagemPato)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Anterior;
        private System.Windows.Forms.Button Proximo;
        private System.Windows.Forms.Label habilidade1;
        private System.Windows.Forms.Label habilidade2;
        private System.Windows.Forms.Label display_Pato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label habilidade3;
        private System.Windows.Forms.Button Escolhe_Pato;
        private System.Windows.Forms.PictureBox ImagemPato;
    }
}

