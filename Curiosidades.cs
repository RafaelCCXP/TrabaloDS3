using DarkSoulsIII.Properties;
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
    public partial class Curiosidades : Form
    {
        public Curiosidades()
        {
            InitializeComponent();
        }

        private void Curiosidades_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ComboBox como null
            label1.Text = "Orceiros o consumido, é um dos chefes do jogo que possuem uma curiosidade bem \r\ninteressante, Porque em sua batalha, existe um certo diálogo dele, porém \r\nnão com o jogador proprimeente dito, e sim com outra pesssoa. \r\nAcontece que era realmente para ter outra pessoa, na ideia original em sua batalha, \r\nOrceiros teria consigo em seu braço um bebê consigo, porém tomaram a decisão, muito\r\nprovavelmente, de descartar essa parte porque pensaram que poderia ser algo muito \r\nimpactante para o jogador.\r\n";
            if (checkBox1.Checked == true)
            {
                this.pictureBox1.Image = Properties.Resources.OrceirosAntes;
            }
            else if(checkBox1.Checked == false)
            {
                this.pictureBox1.Image = null;
            }
            if (checkBox2.Checked == true)
            {
                this.pictureBox2.Image = Properties.Resources.OrceirosComBB;
            }
            else if(checkBox2.Checked == false)
            {
                this.pictureBox2.Image = null;
            }
            if (comboBox1.SelectedIndex == 0) {
                if (checkBox1.Checked ==  true)
                {
                    label1.Text = "Orceiros o consumido, é um dos chefes do jogo que possuem uma curiosidade bem \r\ninteressante, Porque em sua batalha, existe um certo diálogo dele, porém \r\nnão com o jogador proprimeente dito, e sim com outra pesssoa. \r\nAcontece que era realmente para ter outra pessoa, na ideia original em sua batalha, \r\nOrceiros teria consigo em seu braço um bebê consigo, porém tomaram a decisão, muito\r\nprovavelmente, de descartar essa parte porque pensaram que poderia ser algo muito \r\nimpactante para o jogador.\r\n";
                    pictureBox1.Image = Properties.Resources.OrceirosAntes;
                }
                else if (checkBox1.Checked == false)
                {
                    this.pictureBox1.Image = null;
                }
                if (checkBox2.Checked == true)
                {
                    this.pictureBox2.Image = Properties.Resources.OrceirosComBB;
                }
                else if (checkBox2.Checked == false)
                {
                    this.pictureBox2.Image = null;
                }
            }
            if (comboBox1.SelectedIndex == 1)
            {
                    label1.Text = "Está já não é bem uma curiosidade, já que está em evidência no jogo, mas ainda \r\né um detalhe que pode passar desapercebido para a maioria dos jogadores\r\nAcontece que o personagem Gael, ele tem sua primeiro aparição\r\nno jogo base, com uma aparência mais magra e fraca na  Capela Purificadora, \r\nna Catedral das Profundezas, Mas na DLC Cidade Anelar, ele aparece novamente, depois e uma serie de eventos,\r\n como um novo chefe do jogo, maior e mais forte, Gael, O Cavaleiro Escravo, se\r\n torna um dos chefes mais dificeis do jogo!\r\n";
                if (checkBox1.Checked == true)
                {
                    pictureBox1.Image = Properties.Resources.GaelAntes;
                }
                else if (checkBox1.Checked == false)
                {
                    pictureBox1.Image = null;
                }
////////////////////////////////////////////////////////////////////////
                if (checkBox2.Checked == true)
                {
                    pictureBox2.Image = Properties.Resources.GaelDepois;
                }
                else if (checkBox2.Checked == false)
                {
                    pictureBox2.Image = null;
                }

            }
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //comBox Null
            if (checkBox1.Checked == true)
            {
                this.pictureBox1.Image = Properties.Resources.OrceirosAntes;
            }
            else
            {
                this.pictureBox1.Image = null;
            }

            if (comboBox1.SelectedIndex == 0)
            {
                if (checkBox1.Checked == true)
                {
                    this.pictureBox1.Image = Properties.Resources.OrceirosAntes;
                }
                else
                {
                    this.pictureBox1.Image = null;
                }
               
            }
            if (comboBox1.SelectedIndex == 1)
            {
                if (checkBox1.Checked == true)
                {
                    this.pictureBox1.Image = Properties.Resources.GaelAntes;
                }
                else
                {
                    this.pictureBox1.Image = null;
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            //comboBox Null
            if (checkBox2.Checked == true)
            {
                this.pictureBox2.Image = Properties.Resources.OrceirosComBB;
            }
            else
            {
                this.pictureBox2.Image = null;
            }

            if (comboBox1.SelectedIndex == 0)
            {
                if (checkBox2.Checked == true)
                {
                    this.pictureBox2.Image = Properties.Resources.OrceirosComBB;
                }
                else
                {
                    this.pictureBox2.Image = null;
                }
            }
            if (comboBox1.SelectedIndex == 1)
            {
                if (checkBox2.Checked == true)
                {
                    this.pictureBox2.Image = Properties.Resources.GaelDepois;
                }
                else
                {
                    this.pictureBox2.Image = null;
                }

            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 outro = new Form1();
            outro.Show();
        }
    }
}
