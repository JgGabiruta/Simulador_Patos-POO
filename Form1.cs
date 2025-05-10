using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulador_Patos_POO
{
    public partial class Form1 : Form
    {
        public int index = 0;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void EscolherPato()
        {
            
            switch (index) 
            {
                case 0:
                    ImagemPato.Load("https://i.pinimg.com/736x/1a/8e/ce/1a8eced333a982ceae9960bcaea06682.jpg");
                    ImagemPato.SizeMode = PictureBoxSizeMode.Zoom;
                    display_Pato.Text = "Mallard duck";
                    habilidade1.Text = "Eu faço quack";
                    habilidade2.Text = "Eu sei voar!";
                    habilidade3.Text = "";
                    break;
                case 1:
                    ImagemPato.Load("https://i.pinimg.com/736x/6d/10/f5/6d10f53b9cd6ad5c6961c5ebc1a0c308.jpg");
                    ImagemPato.SizeMode = PictureBoxSizeMode.Zoom;
                    display_Pato.Text = "Rubber duck";
                    habilidade1.Text = "Eu faço quack";
                    habilidade2.Text = "";
                    habilidade3.Text = "";
                    break;
                case 2:
                    ImagemPato.Load("https://i.pinimg.com/736x/5e/0a/e6/5e0ae67a995fee4508bc7014aa8cab26.jpg");
                    ImagemPato.SizeMode = PictureBoxSizeMode.Zoom;
                    display_Pato.Text = "Red head duck";
                    habilidade1.Text = "Eu nado";
                    habilidade2.Text = "";
                    habilidade3.Text = "";
                    break;
                case 3:
                    ImagemPato.Load("https://i.pinimg.com/736x/1c/77/1c/1c771c5b2f91eee5bc2e79844cab0ad7.jpg");
                    ImagemPato.SizeMode = PictureBoxSizeMode.Zoom;
                    display_Pato.Text = "Pato dragão";
                    habilidade1.Text = "Eu cuspo fogo";
                    habilidade2.Text = "Nuhh,, falei e saí voando!!";
                    habilidade3.Text = "";
                    break;
                case 4:
                    ImagemPato.Load("https://blogger.googleusercontent.com/img/b/R29vZ2xl/AVvXsEh1f0Z4CWM3thHAXnw9E8GUivP-k461h5Sbdogf45CrgLPnT_lDZR6Xf3M1eWeYrAn6eWKt6afpww3s5CBYO03LuZYQr_3GpxXBrWBkrhBORFBrPzBN3zYKQUhoo8EtAp842Hk4S-rtPoQ6HTbehFj49RsiI8SklSgYhiwqBh12ENjHRn2ow_SmWd0Hj2yY/s1920/duck-detective-the-secret-salami.jpg");
                    ImagemPato.SizeMode = PictureBoxSizeMode.Zoom;
                    display_Pato.Text = "Patotive";
                    habilidade1.Text = "Atirar com arma";
                    habilidade2.Text = "Quaaaack investigativo!!!";
                    habilidade3.Text = "Eu uso terno!";
                    break;
                case 5:
                    ImagemPato.Load("https://i.pinimg.com/736x/50/06/0a/50060a4336ff8474e686ec0fbb2edb12.jpg");
                    ImagemPato.SizeMode = PictureBoxSizeMode.Zoom;
                    display_Pato.Text = "Patolino";
                    habilidade1.Text = "Patolino está usando uma calça jeans de shopping.";
                    habilidade2.Text = "Patolino pode comprar uma calça de shopping.";
                    habilidade3.Text = "";
                    break;
            }


        }
        private void Anterior_Click(object sender, EventArgs e)
        {
            if(index == 0)
            {
                index = 5;
            } else
            {
                index--;                
            }
            EscolherPato();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void nome_pato_Click(object sender, EventArgs e)
        {

        }

        private void Proximo_Click(object sender, EventArgs e)
        {
            if(index < 6)
            {
                index++;
            } else
            {
                index = 0;
            }
            EscolherPato();
        }

        private void habilidade1_Click(object sender, EventArgs e)
        {

        }

        private void Escolhe_Pato_Click(object sender, EventArgs e)
        {
            CriarPato();
            label1.Visible = false;
            Proximo.Visible = false;
            Anterior.Visible = false;
            MessageBox.Show("Pato escolhido com sucesso!");
        }
        private void CriarPato()
        {
            
            switch (index)
            {
                case 0:
                    MallardDuck patoM = new MallardDuck();
                    display_Pato.Text = patoM.display();
                    habilidade1.Text = patoM.fly();
                    habilidade2.Text = patoM.quack();
                    habilidade3.Text = "";
                    break;
                case 1:
                    RubberDuck patoR = new RubberDuck();
                    display_Pato.Text = patoR.display();
                    habilidade1.Text = patoR.quack();
                    habilidade2.Text = "";
                    habilidade3.Text = "";
                    break;
                case 2:
                    RedHeadDuck patoRed = new RedHeadDuck();
                    display_Pato.Text = patoRed.display();
                    habilidade1.Text = patoRed.swim();
                    habilidade2.Text = "";
                    habilidade3.Text = "";
                    break;
                case 3:
                    PatoDragao patoD = new PatoDragao();
                    display_Pato.Text = patoD.display();
                    habilidade1.Text = patoD.atirar();
                    habilidade2.Text = patoD.fly();
                    habilidade3.Text = "";
                    break;
                case 4:
                    Patotive patoT = new Patotive();
                    display_Pato.Text = patoT.display();
                    habilidade1.Text = patoT.atirar();
                    habilidade2.Text = patoT.quack();
                    habilidade3.Text = patoT.usarRoupa();
                    break;
                case 5:
                    Patolino pato = new Patolino();
                    display_Pato.Text = pato.display();
                    habilidade1.Text = pato.usarRoupa();
                    habilidade2.Text = pato.vaiProShopping();
                    habilidade3.Text = "";
                    break;
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
