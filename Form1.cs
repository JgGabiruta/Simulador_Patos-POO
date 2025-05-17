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
                    habilidade2.Text = "Voar!";
                    habilidade3.Text = "";
                    break;
                case 1:
                    ImagemPato.Load("https://i.pinimg.com/736x/6d/10/f5/6d10f53b9cd6ad5c6961c5ebc1a0c308.jpg");
                    ImagemPato.SizeMode = PictureBoxSizeMode.Zoom;
                    display_Pato.Text = "Rubber duck";
                    habilidade1.Text = "Eu faço quack";
                    habilidade2.Text = "Eu te furo hein!";
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
                    ImagemPato.Load("https://super.abril.com.br/wp-content/uploads/2022/02/AMP_patolino.png");
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
            if(index < 5)
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
                      
            MessageBox.Show("Pato escolhido com sucesso!");

            Anterior.Visible = false;
            Proximo.Visible = false;

            hab1.Visible = true;
            hab2.Visible = true;
            hab3.Visible = true;

            habilidade1.Visible = false;
            habilidade2.Visible = false;
            habilidade3.Visible = false;

            menu.Visible = true;

            Escolhe_Pato.Visible = false;

            label1.Visible = false;
   

            CriarPato();
        }
        private void CriarPato()
        {
            
            switch (index)
            {
                case 0:
                    MallardDuck patoM = new MallardDuck();
                    display_Pato.Text = patoM.display();
                    hab1.Text = patoM.quack();
                    hab2.Text = patoM.fly();
                    hab3.Visible = false;
                    break;
                case 1:
                    RubberDuck patoR = new RubberDuck();
                    display_Pato.Text = patoR.display();
                    hab1.Text = patoR.quack();
                    hab2.Text = patoR.esfaquear();
                    hab3.Visible = false;
                    break;
                case 2:
                    RedHeadDuck patoRed = new RedHeadDuck();
                    display_Pato.Text = patoRed.display();
                    hab1.Text = patoRed.swim();
                    hab2.Visible = false;
                    hab3.Visible = false;
                    break;
                case 3:
                    PatoDragao patoD = new PatoDragao();
                    display_Pato.Text = patoD.display();
                    hab1.Text = patoD.esfaquear();
                    hab2.Text = patoD.fly();
                    hab3.Visible = false;

                    break;
                case 4:
                    Patotive patoT = new Patotive();
                    display_Pato.Text = patoT.display();
                    hab1.Text = patoT.esfaquear();
                    hab2.Text = patoT.quack();
                    hab3.Text = patoT.usarRoupa();

                    break;
                case 5:
                    Patolino pato = new Patolino();
                    display_Pato.Text = pato.display();
                    hab1.Text = pato.usarRoupa();
                    hab2.Text = pato.vaiProShopping();
                    hab3.Visible = false;

                    break;
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (index) 
            { 
                case 0:
                    ImagemPato.Load("https://i.pinimg.com/736x/7a/e6/71/7ae671cd954e26ce77fd44f9d91fb0ff.jpg");
                    ImagemPato.SizeMode = PictureBoxSizeMode.Zoom;

                    break;
                case 1:
                    ImagemPato.Load("https://i.pinimg.com/736x/87/7a/64/877a64ef896d852995daada389977ee5.jpg");
                    ImagemPato.SizeMode = PictureBoxSizeMode.Zoom;

                    break;

                case 2:
                    ImagemPato.Load("https://i.pinimg.com/736x/ec/6e/59/ec6e591fc2292f592f7ab847c6275c15.jpg");
                    ImagemPato.SizeMode = PictureBoxSizeMode.Zoom;


                    break;

                case 3:
                    ImagemPato.Load("https://i.pinimg.com/736x/71/95/67/719567da41a9887d0bb4cc8f36979930.jpg");
                    ImagemPato.SizeMode = PictureBoxSizeMode.Zoom;

                    break;

                case 4:
                    ImagemPato.Load("https://i.pinimg.com/736x/69/1b/77/691b77ca88d7de24d7eba78d7e520cb4.jpg");
                    ImagemPato.SizeMode = PictureBoxSizeMode.Zoom;

                    break;
                case 5:
                    ImagemPato.Load("https://i.pinimg.com/736x/50/06/0a/50060a4336ff8474e686ec0fbb2edb12.jpg");
                    ImagemPato.SizeMode = PictureBoxSizeMode.Zoom;


                    break;
            }

        }


        private void hab2_Click(object sender, EventArgs e)
        {
            switch (index)
            {
                case 0:
                    ImagemPato.Load("https://i.pinimg.com/736x/3f/b4/63/3fb463671ed7ca43c2444ce1bfa904c9.jpg");
                    ImagemPato.SizeMode = PictureBoxSizeMode.Zoom;

                    break;
                case 1:
                    ImagemPato.Load("https://i.pinimg.com/736x/bb/fd/9c/bbfd9cadec47f101decf168aa2515f0c.jpg");
                    ImagemPato.SizeMode = PictureBoxSizeMode.Zoom;

                    break;

                case 2:
                    ImagemPato.Load("https://i.pinimg.com/736x/0c/ab/62/0cab6293d01096da0a904ca9396db30e.jpg");
                    ImagemPato.SizeMode = PictureBoxSizeMode.Zoom;

                    break;

                case 3:
                    ImagemPato.Load("https://i.pinimg.com/736x/8f/f2/a2/8ff2a22febf61dd22223b56c3c6f5f57.jpg");
                    ImagemPato.SizeMode = PictureBoxSizeMode.Zoom;

                    break;

                case 4:
               
                    ImagemPato.Load(" https://i.pinimg.com/736x/7e/73/7c/7e737ca04f0207cfb48de3892ba37f48.jpg");
                    ImagemPato.SizeMode = PictureBoxSizeMode.Zoom;

                    break;
                case 5:
                    ImagemPato.Load("https://p2.trrsf.com/image/fget/cf/1200/1600/middle/images.terra.com/2023/08/27/436500820-i786680.jpeg");
                    ImagemPato.SizeMode = PictureBoxSizeMode.Zoom;


                    break;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            switch (index)
            {
                case 0:
                    ImagemPato.Load("https://i.pinimg.com/736x/3f/b4/63/3fb463671ed7ca43c2444ce1bfa904c9.jpg");
                    ImagemPato.SizeMode = PictureBoxSizeMode.Zoom;

                    break;
                case 1:

                    break;

                case 2:
                    ImagemPato.Load("https://i.pinimg.com/736x/ec/6e/59/ec6e591fc2292f592f7ab847c6275c15.jpg");
                    ImagemPato.SizeMode = PictureBoxSizeMode.Zoom;

                    break;

                case 3:
                   
                    break;

                case 4:
                    ImagemPato.Load("https://i.pinimg.com/736x/95/78/b0/9578b03fa93f4c845f5b0854e786003b.jpg");
                    ImagemPato.SizeMode = PictureBoxSizeMode.Zoom;


                    break;
                case 5:
                    ImagemPato.Load("https://i.pinimg.com/736x/95/78/b0/9578b03fa93f4c845f5b0854e786003b.jpg");
                    ImagemPato.SizeMode = PictureBoxSizeMode.Zoom;


                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void menu_Click(object sender, EventArgs e)
        {
            EscolherPato();
            Anterior.Visible = true;
            Proximo.Visible = true;

            menu.Visible = false;

            habilidade1.Visible = true;
            habilidade2.Visible = true;
            habilidade3.Visible = true;

            hab1.Visible = false;
            hab2.Visible = false;
            hab3.Visible = false;

            Escolhe_Pato.Visible = true;
            label1.Visible = true;





        }
    }
}
