using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using WMPLib;

namespace DarkSoulsIII
{
    public partial class Form1 : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Introdução
            if (comboBox1.SelectedIndex == 0)
            {
                panel1.Visible = true;
                pictureBox1.Visible = false;
                groupBox1.Visible = false;
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
                radioButton5.Visible = false;
                radioButton6.Visible = false;
                radioButton7.Visible = false;
                radioButton8.Visible = false;
                radioButton9.Visible = false;
                radioButton10.Visible = false;
                checkBox1.Visible = false;
                panel1.Visible = true;
            }
            //Classes
            if (comboBox1.SelectedIndex == 1)
            {
                groupBox1.Visible = true;
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                radioButton3.Visible = true;
                radioButton4.Visible = true;
                radioButton5.Visible = true;
                radioButton6.Visible = true;
                radioButton7.Visible = true;
                radioButton8.Visible = true;
                radioButton9.Visible = true;
                radioButton10.Visible = true;
                checkBox1.Visible = true;
                panel1.Visible = false;

                //RadioButton Classes
                //Cavaleiro
                if (radioButton1.Checked == true)
                {
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Properties.Resources.Cavaleiro;
                }
                //Mercenário
                else if (radioButton2.Checked == true)
                {
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Properties.Resources.Mercenario;
                }
                //GUerreiro
                else if (radioButton3.Checked)
                {
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Properties.Resources.GUerreiro;
                }
                //Arauto
                else if (radioButton4.Checked)
                {
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Properties.Resources.Arauto;
                }
                //Ladrão
                else if (radioButton5.Checked)
                {
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Properties.Resources.Ladrao;
                }
                //Assassino
                else if (radioButton6.Checked)
                {
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Properties.Resources.Assassino;
                }
                //Feiticeiro
                else if (radioButton7.Checked)
                {
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Properties.Resources.Feiticeiro;
                }
                //Piromante
                else if (radioButton8.Checked)
                {
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Properties.Resources.Piromante;
                }
                //Clérigo
                else if (radioButton9.Checked)
                {
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Properties.Resources.Clerico;
                }
                //Despojado
                else if (radioButton10.Checked)
                {
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Properties.Resources.Despojado;
                }
                //Descrição
                else if (checkBox1.Checked == true)
                {
                    pictureBox2.Visible = true;
                    pictureBox2.Visible = true;
                }
                else
                {
                    pictureBox1.Image = null;
                }
            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Fundo1");
            listBox1.Items.Add("Fundo2");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1) {
                if (radioButton1.Checked == true) {
                    this.pictureBox1.Image = null;
                    pictureBox1.Visible = true;
                    this.pictureBox1.Image = Properties.Resources.Cavaleiro;
                }
                else 
                {
                    this.pictureBox1.Image = null;
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                if (radioButton2.Checked == true)
                {
                    this.pictureBox1.Image = null;
                    pictureBox1.Visible = true;
                    this.pictureBox1.Image = Properties.Resources.Mercenario;
                }
                else
                {
                    this.pictureBox1.Image = null;
                }
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                if (radioButton3.Checked == true)
                {
                    this.pictureBox1.Image = null;
                    pictureBox1.Visible = true;
                    this.pictureBox1.Image = Properties.Resources.GUerreiro;
                }
                else
                {
                    this.pictureBox1.Image = null;
                }
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                if (radioButton4.Checked == true)
                {
                    this.pictureBox1.Image = null;
                    pictureBox1.Visible = true;
                    this.pictureBox1.Image = Properties.Resources.Arauto;
                }
                else
                {
                    this.pictureBox1.Image = null;
                }
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                if (radioButton5.Checked == true)
                {
                    this.pictureBox1.Image = null;
                    pictureBox1.Visible = true;
                    this.pictureBox1.Image = Properties.Resources.Ladrao;
                }
                else
                {
                    this.pictureBox1.Image = null;
                }
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                if (radioButton6.Checked == true)
                {
                    this.pictureBox1.Image = null;
                    pictureBox1.Visible = true;
                    this.pictureBox1.Image = Properties.Resources.Assassino;
                }
                else
                {
                    this.pictureBox1.Image = null;
                }
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                if (radioButton7.Checked == true)
                {
                    this.pictureBox1.Image = null;
                    pictureBox1.Visible = true;
                    this.pictureBox1.Image = Properties.Resources.Feiticeiro;
                }
                else
                {
                    this.pictureBox1.Image = null;
                }
            }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                if (radioButton8.Checked == true)
                {
                    this.pictureBox1.Image = null;
                    pictureBox1.Visible = true;
                    this.pictureBox1.Image = Properties.Resources.Piromante;
                }
                else
                {
                    this.pictureBox1.Image = null;
                }
            }
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                if (radioButton9.Checked == true)
                {
                    this.pictureBox1.Image = null;
                    pictureBox1.Visible = true;
                    this.pictureBox1.Image = Properties.Resources.Clerico;
                }
                else
                {
                    this.pictureBox1.Image = null;
                }
            }
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                if (radioButton10.Checked == true)
                {
                    this.pictureBox1.Image = null;
                    pictureBox1.Visible = true;
                    this.pictureBox1.Image = Properties.Resources.Despojado;
                }
                else
                {
                    this.pictureBox1.Image = null;
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                if (checkBox1.Checked == true)
                {
                    pictureBox2.Visible = true;
                    pictureBox3.Visible = true;
                }
                else if (checkBox1.Checked == false)
                {
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = false;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            player.controls.play();
            player.URL = "MenuMusic.mp3";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            player.controls.stop();
            

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Historia form2 = new Historia();
            form2.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Curiosidades form3 = new Curiosidades();
            form3.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Personagens form3 = new Personagens();
            form3.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.Text == "Fundo1")
            {
                BackgroundImage = Properties.Resources.FundoPrinci;
            }
            if (listBox1.Text == "Fundo2")
            {
                BackgroundImage = Properties.Resources.FundoPrinci2;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
