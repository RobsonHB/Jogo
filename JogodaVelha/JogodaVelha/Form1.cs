using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogodaVelha
{

    public partial class Form1 : Form
    {

        
        int jogador = 1;
        int recomecar = 1;

        public Form1()
        {
            InitializeComponent();
        }
    
        private void Form1_Load(object sender, EventArgs e)
        {
            var frm = new Form2();
            frm.ShowDialog();

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button11.Enabled = false;
          
        }

        // Botões do jogo

        private void button1_Click(object sender, EventArgs e)
        {
            if (jogador == 1)
            {
                button1.Text = "X";
                jogador = 2;
                label2.Text = "Agora é a vez Jogador - O";
            }
            else
            {
                button1.Text = "O";
                jogador = 1;
                label2.Text = "Agora é a vez Jogador  - X";
            }

            if (button1.Text == button2.Text && button2.Text == button3.Text && button1.Text != "")
            {
                MessageBox.Show(" A letra " + button1.Text + " Venceu.");
                label2.Text = "A partida está encerrada.";
            }
            else if (button4.Text == button5.Text && button5.Text == button6.Text && button4.Text != "")
            {
                MessageBox.Show("A letra " + button4.Text + " Venceu.");
                label2.Text = "A partida está encerrada.";
            }
            else if (button7.Text == button8.Text && button8.Text == button9.Text && button7.Text != "")
            {
                MessageBox.Show("A letra " + button7.Text + " Venceu.");
                label2.Text = "A partida está encerrada.";
            }
            else if (button1.Text == button5.Text && button5.Text == button9.Text && button1.Text != "")
            {
                MessageBox.Show("A letra " + button1.Text + " Venceu.");
                label2.Text = "A partida está encerrada.";
            }
            else if (button3.Text == button5.Text && button5.Text == button7.Text && button3.Text != "")
            {
                MessageBox.Show("A letra " + button3.Text + " Venceu.");
                label2.Text = "A partida está encerrada.";
            }
            else if (button1.Text == button4.Text && button4.Text == button7.Text && button1.Text != "")
            {
                MessageBox.Show("A letra " + button1.Text + " Venceu.");
                label2.Text = "A partida está encerrada.";
            }
            else if (button3.Text == button6.Text && button6.Text == button9.Text && button3.Text != "")
            {
                MessageBox.Show("A letra " + button3.Text + " Venceu.");
                label2.Text = "A partida está encerrada.";
            }
            else if (button2.Text == button5.Text && button5.Text == button8.Text && button2.Text != "")
            {
                MessageBox.Show("A letra " + button2.Text + " Venceu.");
                label2.Text = "A partida está encerrada.";
            }
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (jogador == 1)
            {
                button2.Text = "X";
                jogador = 2;
                label2.Text = "Agora é a vez Jogador  - O";
            }
            else
            {
                button2.Text = "O";
                jogador = 1;
                label2.Text = "Agora é a vez Jogador  - X";
            }

            if(button1.Text == button2.Text && button2.Text == button3.Text && button1.Text != "")
            {
                MessageBox.Show(" A letra " + button1.Text + " Venceu.");
                label2.Text = "A partida está encerrada.";
            }
            else if (button4.Text == button5.Text && button5.Text == button6.Text && button4.Text != "")
            {
                MessageBox.Show("A letra " + button4.Text + " Venceu.");
                label2.Text = "A partida está encerrada.";
            }
            else if (button7.Text == button8.Text && button8.Text == button9.Text && button7.Text != "")
            {
                MessageBox.Show("A letra " + button7.Text + " Venceu.");
                label2.Text = "A partida está encerrada.";
            }
            else if (button1.Text == button5.Text && button5.Text == button9.Text && button1.Text != "")
            {
                MessageBox.Show("A letra " + button1.Text + " Venceu.");
                label2.Text = "A partida está encerrada.";
            }
            else if (button3.Text == button5.Text && button5.Text == button7.Text && button3.Text != "")
            {
                MessageBox.Show("A letra " + button3.Text + " Venceu.");
                label2.Text = "A partida está encerrada.";
            }
            else if (button1.Text == button4.Text && button4.Text == button7.Text && button1.Text != "")
            {
                MessageBox.Show("A letra " + button1.Text + " Venceu.");
                label2.Text = "A partida está encerrada.";
            }
            else if (button3.Text == button6.Text && button6.Text == button9.Text && button3.Text != "")
            {
                MessageBox.Show("A letra " + button3.Text + " Venceu.");
                label2.Text = "A partida está encerrada.";
            }
            else if (button2.Text == button5.Text && button5.Text == button8.Text && button2.Text != "")
            {
                MessageBox.Show("A letra " + button2.Text + " Venceu.");
                label2.Text = "A partida está encerrada.";
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (jogador == 1)
            {
                button3.Text = "X";
                jogador = 2;
                label2.Text = "Agora é a vez Jogador - O";
            }
            else
            {
                button3.Text = "O";
                jogador = 1;
                label2.Text = "Agora é a vez Jogador  - X";
            }

            if (button1.Text == button2.Text && button2.Text == button3.Text && button1.Text != "")
            {
                MessageBox.Show(" A letra " + button1.Text + " Venceu.");
                label2.Text = "A partida está encerrada.";
            }
            else if (button4.Text == button5.Text && button5.Text == button6.Text && button4.Text != "")
            {
                MessageBox.Show("A letra " + button4.Text + " Venceu.");
                label2.Text = "A partida está encerrada.";
            }
            else if (button7.Text == button8.Text && button8.Text == button9.Text && button7.Text != "")
            {
                MessageBox.Show("A letra " + button7.Text + " Venceu.");
                label2.Text = "A partida está encerrada.";
            }
            else if (button1.Text == button5.Text && button5.Text == button9.Text && button1.Text != "")
            {
                MessageBox.Show("A letra " + button1.Text + " Venceu.");
                label2.Text = "A partida está encerrada.";
            }
            else if (button3.Text == button5.Text && button5.Text == button7.Text && button3.Text != "")
            {
                MessageBox.Show("A letra " + button3.Text + " Venceu.");
                label2.Text = "A partida está encerrada.";
            }
            else if (button1.Text == button4.Text && button4.Text == button7.Text && button1.Text != "")
            {
                MessageBox.Show("A letra " + button1.Text + " Venceu.");
                label2.Text = "A partida está encerrada.";
            }
            else if (button3.Text == button6.Text && button6.Text == button9.Text && button3.Text != "")
            {
                MessageBox.Show("A letra " + button3.Text + " Venceu.");
                label2.Text = "A partida está encerrada.";
            }
            else if (button2.Text == button5.Text && button5.Text == button8.Text && button2.Text != "")
            {
                MessageBox.Show("A letra " + button2.Text + " Venceu.");
                label2.Text = "A partida está encerrada.";
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (jogador == 1)
            {
                button4.Text = "X";
                jogador = 2;
                label2.Text = "Agora é a vez Jogador - O";
            }
            else
            {
                button4.Text = "O";
                jogador = 1;
                label2.Text = "Agora é a vez Jogador  - X";
            }

            if (button1.Text == button2.Text && button2.Text == button3.Text && button1.Text != "")
            {
                MessageBox.Show(" A letra " + button1.Text + " Venceu.");
                label2.Text = "A partida está encerrada.";
            }
            else if (button4.Text == button5.Text && button5.Text == button6.Text && button4.Text != "")
            {
                MessageBox.Show("A letra " + button4.Text + " Venceu.");
                label2.Text = "A partida está encerrada.";
            }
            else if (button7.Text == button8.Text && button8.Text == button9.Text && button7.Text != "")
            {
                MessageBox.Show("A letra " + button7.Text + " Venceu.");
                label2.Text = "A partida está encerrada.";
            }
            else if (button1.Text == button5.Text && button5.Text == button9.Text && button1.Text != "")
            {
                MessageBox.Show("A letra " + button1.Text + " Venceu.");
                label2.Text = "A partida está encerrada.";
            }
            else if (button3.Text == button5.Text && button5.Text == button7.Text && button3.Text != "")
            {
                MessageBox.Show("A letra " + button3.Text + " Venceu.");
                label2.Text = "A partida está encerrada.";
            }
            else if (button1.Text == button4.Text && button4.Text == button7.Text && button1.Text != "")
            {
                MessageBox.Show("A letra " + button1.Text + " Venceu.");
                label2.Text = "A partida está encerrada.";
            }
            else if (button3.Text == button6.Text && button6.Text == button9.Text && button3.Text != "")
            {
                MessageBox.Show("A letra " + button3.Text + " Venceu.");
                    label2.Text = "A partida está encerrada.";
            }
            else if (button2.Text == button5.Text && button5.Text == button8.Text && button2.Text != "")
            {
                MessageBox.Show("A letra " + button2.Text + " Venceu.");
                label2.Text = "A partida está encerrada.";
            }


        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (jogador == 1)
            {
                button5.Text = "X";
                jogador = 2;
                label2.Text = "Agora é a vez Jogador - O";
            }
            else
            {
                button5.Text = "O";
                jogador = 1;
                label2.Text = "Agora é a vez Jogador  - X";
            }

            if (button1.Text == button2.Text && button2.Text == button3.Text && button1.Text != "")
            {
                MessageBox.Show(" A letra " + button1.Text + " Venceu.");
                label2.Text = "A partida está encerrada.";
            }
            else if (button4.Text == button5.Text && button5.Text == button6.Text && button4.Text != "")
            {
                MessageBox.Show("A letra " + button4.Text + " Venceu.");
                label2.Text = "A partida está encerrada.";
            }
            else if (button7.Text == button8.Text && button8.Text == button9.Text && button7.Text != "")
            {
                MessageBox.Show("A letra " + button7.Text + " Venceu.");
                label2.Text = "A partida está encerrada.";
            }
            else if (button1.Text == button5.Text && button5.Text == button9.Text && button1.Text != "")
            {
                MessageBox.Show("A letra " + button1.Text + " Venceu.");
                label2.Text = "A partida está encerrada.";
            }
            else if (button3.Text == button5.Text && button5.Text == button7.Text && button3.Text != "")
            {
                MessageBox.Show("A letra " + button3.Text + " Venceu.");
                label2.Text = "A partida está encerrada.";
            }
            else if (button1.Text == button4.Text && button4.Text == button7.Text && button1.Text != "")
            {
                MessageBox.Show("A letra " + button1.Text + " Venceu.");
                label2.Text = "A partida está encerrada.";
            }
            else if (button3.Text == button6.Text && button6.Text == button9.Text && button3.Text != "")
            {
                MessageBox.Show("A letra " + button3.Text + " Venceu.");
                label2.Text = "A partida está encerrada.";
            }
            else if (button2.Text == button5.Text && button5.Text == button8.Text && button2.Text != "")
            {
                MessageBox.Show("A letra " + button2.Text + " Venceu.");
                label2.Text = "A partida está encerrada.";
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (jogador == 1)
            {
                button6.Text = "X";
                jogador = 2;
                label2.Text = "Agora é a vez Jogador  - O";
            }
            else
            {
                button6.Text = "O";
                jogador = 1;
                label2.Text = "Agora é a vez Jogador  - X";
            }

            if (button1.Text == button2.Text && button2.Text == button3.Text && button1.Text != "")
            {
                MessageBox.Show(" A letra " + button1.Text + " Venceu.");
                label2.Text = "A partida está encerrada.";
            }
            else if (button4.Text == button5.Text && button5.Text == button6.Text && button4.Text != "")
            {
                MessageBox.Show("A letra " + button4.Text + " Venceu.");
                label2.Text = "A partida está encerrada.";
            }
            else if (button7.Text == button8.Text && button8.Text == button9.Text && button7.Text != "")
            {
                MessageBox.Show("A letra " + button7.Text + " Venceu.");
                label2.Text = "A partida está encerrada.";
            }
            else if (button1.Text == button5.Text && button5.Text == button9.Text && button1.Text != "")
            {
                MessageBox.Show("A letra " + button1.Text + " Venceu.");
                label2.Text = "A partida está encerrada.";
            }
            else if (button3.Text == button5.Text && button5.Text == button7.Text && button3.Text != "")
            {
                MessageBox.Show("A letra " + button3.Text + " Venceu.");
                label2.Text = "A partida está encerrada.";
            }
            else if (button1.Text == button4.Text && button4.Text == button7.Text && button1.Text != "")
            {
                MessageBox.Show("A letra " + button1.Text + " Venceu.");
                label2.Text = "A partida está encerrada.";
            }
            else if (button3.Text == button6.Text && button6.Text == button9.Text && button3.Text != "")
            {
                MessageBox.Show("A letra " + button3.Text + " Venceu.");
                label2.Text = "A partida está encerrada.";
            }
            else if (button2.Text == button5.Text && button5.Text == button8.Text && button2.Text != "")
            {
                MessageBox.Show("A letra " + button2.Text + " Venceu.");
                label2.Text = "A partida está encerrada.";
            }


        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (jogador == 1)
            {
                button7.Text = "X";
                jogador = 2;
                label2.Text = "Agora é a vez Jogador - O";
            }
            else
            {
                button7.Text = "O";
                jogador = 1;
                label2.Text = "Agora é a vez Jogador  - X";
            }

            if (button1.Text == button2.Text && button2.Text == button3.Text && button1.Text != "")
            {
                MessageBox.Show(" A letra " + button1.Text + " Venceu.");
                label2.Text = "A partida está encerrada.";
            }
            else if (button4.Text == button5.Text && button5.Text == button6.Text && button4.Text != "")
            {
                MessageBox.Show("A letra " + button4.Text + " Venceu.");
                label2.Text = "A partida está encerrada.";
            }
            else if (button7.Text == button8.Text && button8.Text == button9.Text && button7.Text != "")
            {
                label2.Text = "A partida está encerrada.";
                MessageBox.Show("A letra " + button7.Text + " Venceu.");
            }
            else if (button1.Text == button5.Text && button5.Text == button9.Text && button1.Text != "")
            {
                MessageBox.Show("A letra " + button1.Text + " Venceu.");
                label2.Text = "A partida está encerrada.";
            }
            else if (button3.Text == button5.Text && button5.Text == button7.Text && button3.Text != "")
            {
                MessageBox.Show("A letra " + button3.Text + " Venceu.");
                label2.Text = "A partida está encerrada.";
            }
            else if (button1.Text == button4.Text && button4.Text == button7.Text && button1.Text != "")
            {
                MessageBox.Show("A letra " + button1.Text + " Venceu.");
                label2.Text = "A partida está encerrada.";
            }
            else if (button3.Text == button6.Text && button6.Text == button9.Text && button3.Text != "")
            {
                MessageBox.Show("A letra " + button3.Text + " Venceu.");
                label2.Text = "A partida está encerrada.";
            }
            else if (button2.Text == button5.Text && button5.Text == button8.Text && button2.Text != "")
            {
                MessageBox.Show("A letra " + button2.Text + " Venceu.");
                label2.Text = "A partida está encerrada.";
            }


        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (jogador == 1)
            {
                button8.Text = "X";
                jogador = 2;
                label2.Text = "Agora é a vez Jogador - O";
            }
            else
            {
                button8.Text = "O";
                jogador = 1;
                label2.Text = "Agora é a vez Jogador  - X";
            }

            if (button1.Text == button2.Text && button2.Text == button3.Text && button1.Text != "")
            {
                MessageBox.Show(" A letra " + button1.Text + " Venceu.");
                label2.Text = "A partida está encerrada.";
            }

            else if (button4.Text == button5.Text && button5.Text == button6.Text && button4.Text != "")
            {
                MessageBox.Show("A letra " + button4.Text + " Venceu.");
                label2.Text = "A partida está encerrada.";
            }
            else if (button7.Text == button8.Text && button8.Text == button9.Text && button7.Text != "")
            {
                MessageBox.Show("A letra " + button7.Text + " Venceu.");
                label2.Text = "A partida está encerrada.";
            }
            else if (button1.Text == button5.Text && button5.Text == button9.Text && button1.Text != "")
            {
                MessageBox.Show("A letra " + button1.Text + " Venceu.");
                label2.Text = "A partida está encerrada.";
            }
            else if (button3.Text == button5.Text && button5.Text == button7.Text && button3.Text != "")
            {
                MessageBox.Show("A letra " + button3.Text + " Venceu.");
            }
            else if (button1.Text == button4.Text && button4.Text == button7.Text && button1.Text != "")
            {
                MessageBox.Show("A letra " + button1.Text + " Venceu.");
                label2.Text = "A partida está encerrada.";
            }
            else if (button3.Text == button6.Text && button6.Text == button9.Text && button3.Text != "")
            {
                MessageBox.Show("A letra " + button3.Text + " Venceu.");
                label2.Text = "A partida está encerrada.";
            }
            else if (button2.Text == button5.Text && button5.Text == button8.Text && button2.Text != "")
            {
                MessageBox.Show("A letra " + button2.Text + " Venceu.");
                label2.Text = "A partida está encerrada.";
            }


        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (jogador == 1)
            {
                button9.Text = "X";
                jogador = 2;
                label2.Text = "Agora é a vez Jogador  - O";
            }
            else
            {
                button9.Text = "O";
                jogador = 1;
                label2.Text = "Agora é a vez Jogador  - X";
            }

            if (button1.Text == button2.Text && button2.Text == button3.Text && button1.Text != "")
            {
                MessageBox.Show(" A letra " + button1.Text + " Venceu.");
                label2.Text = "A partida está encerrada.";
            }
            else if (button4.Text == button5.Text && button5.Text == button6.Text && button4.Text != "")
            {
                MessageBox.Show("A letra " + button4.Text + " Venceu.");
                label2.Text = "A partida está encerrada.";
            }
            else if (button7.Text == button8.Text && button8.Text == button9.Text && button7.Text != "")
            {
                MessageBox.Show("A letra " + button7.Text + " Venceu.");
                label2.Text = "A partida está encerrada.";
            }
            else if (button1.Text == button5.Text && button5.Text == button9.Text && button1.Text != "")
            {
                MessageBox.Show("A letra " + button1.Text + " Venceu.");
                label2.Text = "A partida está encerrada.";
            }
            else if (button3.Text == button5.Text && button5.Text == button7.Text && button3.Text != "")
            {
                MessageBox.Show("A letra " + button3.Text + " Venceu.");
                label2.Text = "A partida está encerrada.";
            }
            else if (button1.Text == button4.Text && button4.Text == button7.Text && button1.Text != "")
            {
                MessageBox.Show("A letra " + button1.Text + " Venceu.");
                label2.Text = "A partida está encerrada.";
            }
            else if (button3.Text == button6.Text && button6.Text == button9.Text && button3.Text != "")
            {
                MessageBox.Show("A letra " + button3.Text + " Venceu.");
                label2.Text = "A partida está encerrada.";
            }
            else if (button2.Text == button5.Text && button5.Text == button8.Text && button2.Text != "")
            {
                MessageBox.Show("A letra " + button2.Text + " Venceu.");
                label2.Text = "A partida está encerrada.";
            }


        }

        // Botão para iniciar o jogo.
        private void button10_Click(object sender, EventArgs e)
        {
            label2.Text = "Jogador X, inicie a jogada";
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button11.Enabled = true;
        }

        // Botão para reiniciar o jogo.
        private void button11_Click(object sender, EventArgs e)
        {
            if (recomecar == 1)
            {
                label2.Text = "Jogador O, inicie a jogada";
                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
                button5.Text = "";
                button6.Text = "";
                button7.Text = "";
                button8.Text = "";
                button9.Text = "";
                recomecar = 2;
            }
            else
            {
                label2.Text = "Jogador X, inicie a jogada";
                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
                button5.Text = "";
                button6.Text = "";
                button7.Text = "";
                button8.Text = "";
                button9.Text = "";
                recomecar = 1;
            }
           
        }

        
    }
}

