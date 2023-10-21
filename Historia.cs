using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarkSoulsIII
{
    public partial class Historia : Form
    {
        public Historia()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = "Dark Souls III se passa vários anos após os acontecimentos dos jogos anteriores.Mais uma\r\nvez somos o protagonista no meio da transição do ciclo do fogo e da escuridão e o \r\nobjetivo é devolver os 5 Lords das Cinzas aos seus tronos, de onde nunca deveriam ter saído\r\ne acender a chama para que o ciclo se complete.\r\nDessa vez nosso personagem é um Inaceso, um Lord das Cinzas, nascido dos restos de um\r\nguerreiro que falhou no objetivo de acender a chama e, consequentemente, teve seu corpo \r\ntransformado em cinzas.\r\n";
            if (checkBox1.Checked == true)
            {
                this.pictureBox1.Image = Properties.Resources.Ludleth;
                checkBox1.Text = "Ludleth";
            }
            else if (checkBox1.Checked == false)
            {
                this.pictureBox1.Image = null;
                checkBox1.Text = "Ludleth";
            }
            ///////////////////////////////////////////////////////////////////////////////////
            else if (checkBox2.Checked == true)
            {
                this.pictureBox2.Image = Properties.Resources.Aldritch;
                checkBox2.Text = "Aldritch";
            }
            else if (checkBox2.Checked == false)
            {
                this.pictureBox2.Image = null;
                checkBox2.Text = "Aldritch";
            }
            ////////////////////////////////////////////////////////////////////////////////////
            else if (checkBox3.Checked == true)
            {
                pictureBox3.Image = Properties.Resources.Lothric;
                checkBox3.Text = "Lothric";
            }
            else if (checkBox3.Checked == false)
            {
                this.pictureBox3.Image = null;
                checkBox3.Text = "Lothric";
            }
            ////////////////////////////////////////////////////////////////////////////////////
            else if (checkBox4.Checked == true)
            {
                this.pictureBox4.Image = Properties.Resources.Yhorm;
                checkBox4.Text = "Yhorn";
            }
            else if (checkBox4.Checked == false)
            {
                this.pictureBox4.Image = null;
                checkBox4.Text = "Yhorn";
            }
            /////////////////////////////////////////////////////////////////////////////////////
            else if (checkBox5.Checked == true)
            {
                pictureBox5.Image = Properties.Resources.Vigilantes;
                checkBox1.Text = "Vigilantes \r\ndo Abismo";
            }
            else if (checkBox5.Checked == false)
            {
                this.pictureBox5.Image = null;
                checkBox5.Text = "Vigilantes\r\ndo Abismo";
            }

            if (comboBox1.SelectedIndex == 0)
            {
                label1.Text = "Dark Souls III se passa vários anos após os acontecimentos dos jogos anteriores.Mais uma\r\nvez somos o protagonista no meio da transição do ciclo do fogo e da escuridão e o \r\nobjetivo é devolver os 5 Lords das Cinzas aos seus tronos, de onde nunca deveriam ter saído\r\ne acender a chama para que o ciclo se complete.\r\nDessa vez nosso personagem é um Inaceso, um Lord das Cinzas, nascido dos restos de um\r\nguerreiro que falhou no objetivo de acender a chama e, consequentemente, teve seu corpo \r\ntransformado em cinzas.\r\n";
                if (checkBox1.Checked == true)
                {
                    this.pictureBox1.Image = Properties.Resources.Ludleth;
                    checkBox1.Text = "Ludleth";
                }
                else if (checkBox1.Checked == false)
                {
                    this.pictureBox1.Image = null;
                    checkBox1.Text = "Ludleth";
                }
///////////////////////////////////////////////////////////////////////////////////
                else if (checkBox2.Checked == true)
                {
                    this.pictureBox2.Image = Properties.Resources.Aldritch;
                    checkBox2.Text = "Aldritch";
                }
                else if (checkBox2.Checked == false)
                {
                    this.pictureBox2.Image = null;
                    checkBox2.Text = "Aldritch";
                }
////////////////////////////////////////////////////////////////////////////////////
                else if (checkBox3.Checked == true)
                {
                    pictureBox3.Image = Properties.Resources.Lothric;
                    checkBox3.Text = "Lothric";
                }
                else if (checkBox3.Checked == false)
                {
                    this.pictureBox3.Image = null;
                    checkBox3.Text = "Lothric";
                }
////////////////////////////////////////////////////////////////////////////////////
                else if (checkBox4.Checked == true)
                {
                    this.pictureBox4.Image = Properties.Resources.Yhorm;
                    checkBox4.Text = "Yhorn";
                }
                else if (checkBox4.Checked == false)
                {
                    this.pictureBox4.Image = null;
                    checkBox4.Text = "Yhorn";
                }
/////////////////////////////////////////////////////////////////////////////////////
                else if (checkBox5.Checked == true)
                {
                    pictureBox5.Image = Properties.Resources.Vigilantes;
                    checkBox1.Text = "Vigilantes \r\ndo Abismo";
                }
                else if (checkBox5.Checked == false)
                {
                    this.pictureBox5.Image = null;
                    checkBox5.Text = "Vigilantes\r\ndo Abismo";
                }
//////////////////////////////////////////////////////////////////////////////////////

            }
            if (comboBox1.SelectedIndex == 1)
            {
                label1.Text = "Dark Souls 3 conta com oito pactos que funcionam como facções para o modo multiplayer, \r\nassim como nos jogos anteriores da franquia.\r\nOs pactos em Dark Souls 3 permitem ao jogador se aliar a certas facções dentro do jogo para \r\nobter acesso a itens, habilidades ou mecânicas especiais. Para se ingressar em uma facção, \r\no personagem do jogador deve equipar uma das várias insígnias do Covenant descobertas \r\nem Lothric.\r\n";
                if (checkBox1.Checked == true)
                {
                    checkBox1.Text = "Caminho Azul";
                    pictureBox1.Image = Properties.Resources.CaminhoAzul;
                }
                else if (checkBox1.Checked == false)
                {
                    checkBox1.Text = "Caminho Azul";
                    pictureBox1.Image = null;
                }
                /////////////////////////////////////////////////////////////
                if (checkBox2.Checked == true)
                {
                    checkBox2.Text = "Sentinelas Azuis";
                    pictureBox2.Image = Properties.Resources.SentinelasAzuis;
                }
                else if (checkBox2.Checked == false)
                {
                    checkBox2.Text = "Sentinelas Azuis";
                    pictureBox2.Image = null;
                }
                /////////////////////////////////////////////////////////////
                if (checkBox3.Checked == true)
                {
                    checkBox3.Text = "Guerreiros \r\nda Luz Solar";
                    pictureBox3.Image = Properties.Resources.GuerreiroSol;
                }
                else if (checkBox3.Checked == false)
                {
                    checkBox3.Text = "Guerreiros \r\nda Luz Solar";
                    pictureBox3.Image = null;
                }
                /////////////////////////////////////////////////////////////
                if (checkBox4.Checked == true)
                {
                    checkBox4.Text = "Cães de Guarda \r\nde Farron";
                    pictureBox4.Image = Properties.Resources.Farron;

                }
                else if (checkBox4.Checked == false)
                {
                    checkBox4.Text = "Cães de Guarda \r\nde Farron";
                    pictureBox4.Image = null;
                }
                /////////////////////////////////////////////////////////
                if (checkBox5.Checked == true)
                {
                    checkBox5.Text = "Dedos de Rosaria";
                    pictureBox5.Image = Properties.Resources.Rosaria;
                }
                else if (checkBox5.Checked == false)
                {
                    checkBox5.Text = "Dedos de Rosaria";
                    pictureBox5.Image = null;
                }
            }
            
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 outro = new Form1();
            outro.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //ComboBox como null
           
            if (checkBox1.Checked == true)
            {
                this.pictureBox1.Image = Properties.Resources.Ludleth;
                checkBox1.Text = "Ludleth";
            }
            else if (checkBox1.Checked == false)
            {

                this.pictureBox1.Image = null;
            }
            if (comboBox1.SelectedIndex == 0)
            {
                if (checkBox1.Checked == true)
                {
                    this.pictureBox1.Image = Properties.Resources.Ludleth;
                    checkBox1.Text = "Ludleth";
                }
                else if(checkBox1.Checked == false){
                    
                    this.pictureBox1.Image = null;
                }
            }
            if(comboBox1.SelectedIndex == 1)
            {
                if(checkBox1.Checked == true)
                {
                    this.pictureBox1.Image = Properties.Resources.CaminhoAzul;
                    checkBox1.Text = "Caminho Azul";
                }
                else if(checkBox1.Checked == false)
                {
                    this.pictureBox1.Image = null;
                }
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            //ComboBox como null
            if (checkBox2.Checked == true)
            {
                this.pictureBox2.Image = Properties.Resources.Aldrich;
                checkBox2.Text = "Aldritch";
            }
            else if (checkBox2.Checked == false)
            {

                this.pictureBox2.Image = null;
            }

            if (comboBox1.SelectedIndex == 0)
            {
                if (checkBox2.Checked == true)
                {
                    this.pictureBox2.Image = Properties.Resources.Aldrich;
                    checkBox2.Text = "Aldritch";
                }
                else if (checkBox2.Checked == false)
                {

                    this.pictureBox2.Image = null;
                }
            }
            if (comboBox1.SelectedIndex == 1)
            {
                if (checkBox2.Checked == true)
                {
                    this.pictureBox2.Image = Properties.Resources.SentinelasAzuis;
                    checkBox2.Text = "Sentinelas Azuis";
                }
                else if (checkBox2.Checked == false)
                {
                    this.pictureBox2.Image = null;
                }
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            //ComboBox como null
            if (checkBox3.Checked == true)
            {
                this.pictureBox3.Image = Properties.Resources.Lothric;
                checkBox3.Text = "Lothric";
            }
            else if (checkBox3.Checked == false)
            {

                this.pictureBox3.Image = null;
            }
            if (comboBox1.SelectedIndex == 0)
            {
                if (checkBox3.Checked == true)
                {
                    this.pictureBox3.Image = Properties.Resources.Lothric;
                    checkBox3.Text = "Lothric";
                }
                else if (checkBox3.Checked == false)
                {

                    this.pictureBox3.Image = null;
                }
            }
            if (comboBox1.SelectedIndex == 1)
            {
                if (checkBox3.Checked == true)
                {
                    this.pictureBox3.Image = Properties.Resources.GuerreiroSol;
                    checkBox3.Text = "Guerreiros da\r\n Luz Solar";
                }
                else if (checkBox3.Checked == false)
                {
                    this.pictureBox3.Image = null;
                }
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            //ComboBox como null
            if (checkBox4.Checked == true)
            {
                this.pictureBox4.Image = Properties.Resources.Yhorm;
                checkBox4.Text = "Yhorn";
            }
            else if (checkBox4.Checked == false)
            {

                this.pictureBox4.Image = null;
            }
            if (comboBox1.SelectedIndex == 0)
            {
                if (checkBox4.Checked == true)
                {
                    this.pictureBox4.Image = Properties.Resources.Yhorm;
                    checkBox4.Text = "Yhorn";
                }
                else if (checkBox4.Checked == false)
                {

                    this.pictureBox4.Image = null;
                }
            }
            if (comboBox1.SelectedIndex == 1)
            {
                if (checkBox4.Checked == true)
                {
                    this.pictureBox4.Image = Properties.Resources.Farron;
                    checkBox4.Text = "Cães de Guarda\r\n de Farron";
                }
                else if (checkBox4.Checked == false)
                {
                    this.pictureBox4.Image = null;
                }
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            //ComboBox como null
            if (checkBox5.Checked == true)
            {
                this.pictureBox5.Image = Properties.Resources.Vigilantes;
                checkBox5.Text = "Vigilanestes \r\n do Abismo";
            }
            else if (checkBox5.Checked == false)
            {

                this.pictureBox5.Image = null;
            }
            if (comboBox1.SelectedIndex == 0)
            {
                if (checkBox5.Checked == true)
                {
                    this.pictureBox5.Image = Properties.Resources.Vigilantes;
                    checkBox5.Text = "Vigilanestes \r\n do Abismo";
                }
                else if (checkBox5.Checked == false)
                {

                    this.pictureBox5.Image = null;
                }
            }
            if (comboBox1.SelectedIndex == 1)
            {
                if (checkBox5.Checked == true)
                {
                    this.pictureBox5.Image = Properties.Resources.Rosaria;
                    checkBox5.Text = "Dedos de Rosaria";
                }
                else if (checkBox5.Checked == false)
                {
                    this.pictureBox5.Image = null;
                }
            }
        }
    }
}
