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
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImagemPato)).BeginInit();
            this.SuspendLayout();
            // 
            // Anterior
            // 
            this.Anterior.BackColor = System.Drawing.Color.Azure;
            this.Anterior.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Anterior.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Anterior.Location = new System.Drawing.Point(40, 225);
            this.Anterior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Anterior.Name = "Anterior";
            this.Anterior.Size = new System.Drawing.Size(92, 28);
            this.Anterior.TabIndex = 0;
            this.Anterior.Text = "Anterior";
            this.Anterior.UseVisualStyleBackColor = false;
            this.Anterior.Click += new System.EventHandler(this.Anterior_Click);
            // 
            // Proximo
            // 
            this.Proximo.BackColor = System.Drawing.Color.Azure;
            this.Proximo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Proximo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Proximo.Location = new System.Drawing.Point(163, 225);
            this.Proximo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Proximo.Name = "Proximo";
            this.Proximo.Size = new System.Drawing.Size(104, 28);
            this.Proximo.TabIndex = 1;
            this.Proximo.Text = "Proximo";
            this.Proximo.UseVisualStyleBackColor = false;
            this.Proximo.Click += new System.EventHandler(this.Proximo_Click);
            // 
            // habilidade1
            // 
            this.habilidade1.AutoSize = true;
            this.habilidade1.BackColor = System.Drawing.Color.Transparent;
            this.habilidade1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.habilidade1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.habilidade1.Location = new System.Drawing.Point(50, 130);
            this.habilidade1.Name = "habilidade1";
            this.habilidade1.Size = new System.Drawing.Size(0, 22);
            this.habilidade1.TabIndex = 3;
            this.habilidade1.Click += new System.EventHandler(this.habilidade1_Click);
            // 
            // habilidade2
            // 
            this.habilidade2.AutoSize = true;
            this.habilidade2.BackColor = System.Drawing.Color.Transparent;
            this.habilidade2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.habilidade2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.habilidade2.Location = new System.Drawing.Point(50, 157);
            this.habilidade2.Name = "habilidade2";
            this.habilidade2.Size = new System.Drawing.Size(0, 22);
            this.habilidade2.TabIndex = 4;
            // 
            // display_Pato
            // 
            this.display_Pato.AutoSize = true;
            this.display_Pato.BackColor = System.Drawing.Color.Transparent;
            this.display_Pato.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display_Pato.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.display_Pato.Location = new System.Drawing.Point(50, 102);
            this.display_Pato.Name = "display_Pato";
            this.display_Pato.Size = new System.Drawing.Size(0, 22);
            this.display_Pato.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Azure;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 34);
            this.label1.TabIndex = 6;
            this.label1.Text = "Escolha o Pato";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // habilidade3
            // 
            this.habilidade3.AutoSize = true;
            this.habilidade3.BackColor = System.Drawing.Color.Transparent;
            this.habilidade3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.habilidade3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.habilidade3.Location = new System.Drawing.Point(50, 185);
            this.habilidade3.Name = "habilidade3";
            this.habilidade3.Size = new System.Drawing.Size(0, 22);
            this.habilidade3.TabIndex = 7;
            // 
            // Escolhe_Pato
            // 
            this.Escolhe_Pato.BackColor = System.Drawing.Color.Azure;
            this.Escolhe_Pato.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Escolhe_Pato.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Escolhe_Pato.Location = new System.Drawing.Point(168, 283);
            this.Escolhe_Pato.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Escolhe_Pato.Name = "Escolhe_Pato";
            this.Escolhe_Pato.Size = new System.Drawing.Size(99, 29);
            this.Escolhe_Pato.TabIndex = 8;
            this.Escolhe_Pato.Text = "Escolher";
            this.Escolhe_Pato.UseVisualStyleBackColor = false;
            this.Escolhe_Pato.Click += new System.EventHandler(this.Escolhe_Pato_Click);
            // 
            // ImagemPato
            // 
            this.ImagemPato.Location = new System.Drawing.Point(386, 10);
            this.ImagemPato.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ImagemPato.Name = "ImagemPato";
            this.ImagemPato.Size = new System.Drawing.Size(378, 265);
            this.ImagemPato.TabIndex = 9;
            this.ImagemPato.TabStop = false;
            // 
            // hab1
            // 
            this.hab1.BackColor = System.Drawing.Color.Azure;
            this.hab1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hab1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.hab1.Location = new System.Drawing.Point(357, 341);
            this.hab1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hab1.Name = "hab1";
            this.hab1.Size = new System.Drawing.Size(115, 37);
            this.hab1.TabIndex = 10;
            this.hab1.Text = "Hb1";
            this.hab1.UseVisualStyleBackColor = false;
            this.hab1.Visible = false;
            this.hab1.Click += new System.EventHandler(this.button1_Click);
            // 
            // hab2
            // 
            this.hab2.BackColor = System.Drawing.Color.Azure;
            this.hab2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hab2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.hab2.Location = new System.Drawing.Point(502, 341);
            this.hab2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hab2.Name = "hab2";
            this.hab2.Size = new System.Drawing.Size(117, 37);
            this.hab2.TabIndex = 11;
            this.hab2.Text = "Hb2";
            this.hab2.UseVisualStyleBackColor = false;
            this.hab2.Visible = false;
            this.hab2.Click += new System.EventHandler(this.hab2_Click);
            // 
            // hab3
            // 
            this.hab3.BackColor = System.Drawing.Color.Azure;
            this.hab3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hab3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.hab3.Location = new System.Drawing.Point(646, 341);
            this.hab3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hab3.Name = "hab3";
            this.hab3.Size = new System.Drawing.Size(118, 37);
            this.hab3.TabIndex = 12;
            this.hab3.Text = "Hb3";
            this.hab3.UseVisualStyleBackColor = false;
            this.hab3.Visible = false;
            this.hab3.Click += new System.EventHandler(this.button3_Click);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.Azure;
            this.menu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menu.Location = new System.Drawing.Point(40, 350);
            this.menu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(97, 28);
            this.menu.TabIndex = 13;
            this.menu.Text = "Menu";
            this.menu.UseVisualStyleBackColor = false;
            this.menu.Visible = false;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Azure;
            this.btnSair.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSair.Location = new System.Drawing.Point(40, 284);
            this.btnSair.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(97, 28);
            this.btnSair.TabIndex = 14;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(831, 439);
            this.Controls.Add(this.btnSair);
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
        private System.Windows.Forms.Button btnSair;
    }
}

