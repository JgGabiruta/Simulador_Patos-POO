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
            this.hab1 = new System.Windows.Forms.Button();
            this.hab2 = new System.Windows.Forms.Button();
            this.hab3 = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImagemPato)).BeginInit();
            this.SuspendLayout();
            // 
            // Anterior
            // 
            this.Anterior.Location = new System.Drawing.Point(23, 229);
            this.Anterior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Anterior.Name = "Anterior";
            this.Anterior.Size = new System.Drawing.Size(69, 28);
            this.Anterior.TabIndex = 0;
            this.Anterior.Text = "Anterior";
            this.Anterior.UseVisualStyleBackColor = true;
            this.Anterior.Click += new System.EventHandler(this.Anterior_Click);
            // 
            // Proximo
            // 
            this.Proximo.Location = new System.Drawing.Point(146, 229);
            this.Proximo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Proximo.Name = "Proximo";
            this.Proximo.Size = new System.Drawing.Size(84, 28);
            this.Proximo.TabIndex = 1;
            this.Proximo.Text = "Proximo";
            this.Proximo.UseVisualStyleBackColor = true;
            this.Proximo.Click += new System.EventHandler(this.Proximo_Click);
            // 
            // habilidade1
            // 
            this.habilidade1.AutoSize = true;
            this.habilidade1.Location = new System.Drawing.Point(61, 114);
            this.habilidade1.Name = "habilidade1";
            this.habilidade1.Size = new System.Drawing.Size(85, 16);
            this.habilidade1.TabIndex = 3;
            this.habilidade1.Text = "Habilidade-1";
            this.habilidade1.Click += new System.EventHandler(this.habilidade1_Click);
            // 
            // habilidade2
            // 
            this.habilidade2.AutoSize = true;
            this.habilidade2.Location = new System.Drawing.Point(61, 141);
            this.habilidade2.Name = "habilidade2";
            this.habilidade2.Size = new System.Drawing.Size(85, 16);
            this.habilidade2.TabIndex = 4;
            this.habilidade2.Text = "Habilidade-2";
            // 
            // display_Pato
            // 
            this.display_Pato.AutoSize = true;
            this.display_Pato.Location = new System.Drawing.Point(61, 86);
            this.display_Pato.Name = "display_Pato";
            this.display_Pato.Size = new System.Drawing.Size(44, 16);
            this.display_Pato.TabIndex = 5;
            this.display_Pato.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Escolha o pato";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // habilidade3
            // 
            this.habilidade3.AutoSize = true;
            this.habilidade3.Location = new System.Drawing.Point(61, 169);
            this.habilidade3.Name = "habilidade3";
            this.habilidade3.Size = new System.Drawing.Size(85, 16);
            this.habilidade3.TabIndex = 7;
            this.habilidade3.Text = "Habilidade-3";
            // 
            // Escolhe_Pato
            // 
            this.Escolhe_Pato.Location = new System.Drawing.Point(77, 279);
            this.Escolhe_Pato.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Escolhe_Pato.Name = "Escolhe_Pato";
            this.Escolhe_Pato.Size = new System.Drawing.Size(99, 29);
            this.Escolhe_Pato.TabIndex = 8;
            this.Escolhe_Pato.Text = "Escolher";
            this.Escolhe_Pato.UseVisualStyleBackColor = true;
            this.Escolhe_Pato.Click += new System.EventHandler(this.Escolhe_Pato_Click);
            // 
            // ImagemPato
            // 
            this.ImagemPato.Location = new System.Drawing.Point(386, 10);
            this.ImagemPato.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ImagemPato.Name = "ImagemPato";
            this.ImagemPato.Size = new System.Drawing.Size(315, 214);
            this.ImagemPato.TabIndex = 9;
            this.ImagemPato.TabStop = false;
            // 
            // hab1
            // 
            this.hab1.Location = new System.Drawing.Point(267, 275);
            this.hab1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hab1.Name = "hab1";
            this.hab1.Size = new System.Drawing.Size(115, 37);
            this.hab1.TabIndex = 10;
            this.hab1.Text = "Hb1";
            this.hab1.UseVisualStyleBackColor = true;
            this.hab1.Visible = false;
            this.hab1.Click += new System.EventHandler(this.button1_Click);
            // 
            // hab2
            // 
            this.hab2.Location = new System.Drawing.Point(412, 275);
            this.hab2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hab2.Name = "hab2";
            this.hab2.Size = new System.Drawing.Size(117, 37);
            this.hab2.TabIndex = 11;
            this.hab2.Text = "Hb2";
            this.hab2.UseVisualStyleBackColor = true;
            this.hab2.Visible = false;
            this.hab2.Click += new System.EventHandler(this.hab2_Click);
            // 
            // hab3
            // 
            this.hab3.Location = new System.Drawing.Point(556, 275);
            this.hab3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hab3.Name = "hab3";
            this.hab3.Size = new System.Drawing.Size(118, 37);
            this.hab3.TabIndex = 12;
            this.hab3.Text = "Hb3";
            this.hab3.UseVisualStyleBackColor = true;
            this.hab3.Visible = false;
            this.hab3.Click += new System.EventHandler(this.button3_Click);
            // 
            // menu
            // 
            this.menu.Location = new System.Drawing.Point(79, 312);
            this.menu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(97, 28);
            this.menu.TabIndex = 13;
            this.menu.Text = "Menu";
            this.menu.UseVisualStyleBackColor = true;
            this.menu.Visible = false;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.hab3);
            this.Controls.Add(this.hab2);
            this.Controls.Add(this.hab1);
            this.Controls.Add(this.ImagemPato);
            this.Controls.Add(this.Escolhe_Pato);
            this.Controls.Add(this.habilidade3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.display_Pato);
            this.Controls.Add(this.habilidade2);
            this.Controls.Add(this.habilidade1);
            this.Controls.Add(this.Proximo);
            this.Controls.Add(this.Anterior);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Button hab1;
        private System.Windows.Forms.Button hab2;
        private System.Windows.Forms.Button hab3;
        private System.Windows.Forms.Button menu;
    }
}

