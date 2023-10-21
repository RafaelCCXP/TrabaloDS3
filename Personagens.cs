using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using WMPLib;

namespace DarkSoulsIII
{
    public partial class Personagens : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        public Personagens()
        {
            
            InitializeComponent();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                groupBox1.Visible = true;
                radioButton1.Visible = true;
                radioButton1.Text = "Personagens de Missõs";
                radioButton2.Visible = true;
                radioButton2.Text = "Personagens de Diálogo";
                radioButton3.Visible = false;
                radioButton4.Visible = false;
                radioButton5.Visible = false;
                radioButton6.Visible = false;
                radioButton7.Visible = false;
                radioButton8.Visible = false;
                radioButton9.Visible = false;
                radioButton10.Visible = false;
                radioButton11.Visible = false;
                radioButton12.Visible = false;
                radioButton13.Visible = false;
                radioButton14.Visible = false;
                radioButton15.Visible = false;
                radioButton16.Visible = false;
                radioButton17.Visible = false;
                radioButton18.Visible = false;
                radioButton19.Visible = false;
                panel1.Visible = true;
                label1.Visible = true; 
                label2.Visible = true;

                
                //Personagens de Missões
                if(radioButton1.Checked == true)
                {
                    pictureBox1.Image = Properties.Resources.SIegward;
                    label1.Text = "Personagens de Missão";
                    label2.Text = "Os Personagens não jógaveis(NPC), de missões, são aqueles que ao se ter algum diálogo\r\nem especifico ou se encontrados em uam certa área do jogo, as vezes com certos eventos\r\nespecificos também, poderá desbloquear a respectiva missão daquele personagem também\r\nassim podendo ganhar uma recompesa por aquela atividade.\r\n\r\nIsso também pode servir para ganhar as conquistas de desafios do jogo, para aqueles\r\ninteressados em concluir todas as atividades do jogo. ";
                }
                else if(radioButton2.Checked == true)
                {
                    pictureBox1.Image = Properties.Resources.FIrekeeper;
                    label1.Text = "Personagens de diálogo/\r\nAprimorametentos";
                    label2.Text = "Os Personagen não joágaveis(NPC), que apenas servem para diálogo, são aqueles em que\r\nsão encontrados durante o jogo e costumam a expelir algumas falas onde podem servir\r\ntanto para maior compreensão da história e desse mundo, mesmo que a história de\r\nDark Souls III possua elementos que são abertos a interpetação, e também servem para\r\ncompor o ambiente afim de propor mais o jogador a imersãode uma forma que ele também\r\npossa compreender a ambientação do mundo e o que está acontecendo nele.\r\n\r\nAlguns desses NPC's, podem aparecer posteriormente até mesmo como chefes nas DLC's\r\ndo jogo, Isso se enquadra e perosnagens que só se pode dialogar ou que se pode\r\nusa-lo para aumentar o nível ou comprar e vender itens com as almas que você ganha\r\nao derrotar inimigos";
                }
                

            }
            if (comboBox1.SelectedIndex == 1) {
                panel1.Visible = true;
                groupBox1.Visible = true;
                radioButton1.Visible = true;
                radioButton1.Text = "Iudex Gundyr";
                radioButton2.Visible = true;
                radioButton2.Text = "Vordt";
                radioButton3.Visible = true;
                radioButton4.Visible = true;
                radioButton5.Visible = true;
                radioButton6.Visible = true;
                radioButton7.Visible = true;
                radioButton8.Visible = true;
                radioButton9.Visible = true;
                radioButton10.Visible = true;
                radioButton11.Visible = true;
                radioButton12.Visible = true;
                radioButton13.Visible = true;
                radioButton14.Visible = true;
                radioButton15.Visible = true;
                radioButton16.Visible = true;
                radioButton17.Visible = true;
                radioButton18.Visible = true;
                radioButton19.Visible = true;
                panel1.Visible = true;
                label1.Visible = true;
                label2.Visible = true;

                //RadioButton Chefes
                //Iudex Gubdyr
                if (radioButton1.Checked == true)
                {
                    pictureBox1.Image = Properties.Resources.IudexGundyr;
                    label1.Text = "Iudex Gundyr";
                    label2.Text = "Iudex Gundyr é um grande humanóide vestido com uma armadura pesada e ataca o jogador \r\nusando um grandealabarda. Os jogadores encontrarão umespadaembutido em seu peito \r\nquando o encontram pela primeira vez. \r\nDepois de ser derrubado a um certo limite de saúde, uma massa negra gigante emerge de seu\r\npescoço que lhe dá acesso a ataques adicionais. \r\nEste chefe não é opcional e o jogador terá que enfrentá-lo para ter acesso aSantuário Firelink.\r\n";
                }
                //Vordt
                else if (radioButton2.Checked == true)
                {
                    pictureBox1.Image = Properties.Resources.Vordt;
                    label1.Text = "Vordt do Vale Boreal";
                    label2.Text = "Vordt do Vale Borealé uma grande criatura quadrúpede vestindo uma pesada armadura \r\nde cavaleiro e muitos dos ataques em seu moveset apresentam umgrande marteloque se \r\nassemelha a uma maça.\r\n \r\nQuando os jogadores o encontram, ele é visto saindo de um orbe de névoa. \r\nDepois de ser reduzido a um certo limite de saúde, a névoa azul ao seu redor e sua arma se \r\nintensificam, infligindo lentamenteQueimadura por friono jogador se eles ficarem perto dele,\r\nEsta é a primeira ocorrência de congelamento que o jogador pode encontrar no jogo.\r\n";
                }
                //Grande Madeira
                else if (radioButton3.Checked)
                {
                    pictureBox1.Image = Properties.Resources.GrandeMadeira;
                    label1.Text = "Grande Madeira Apodrecida";
                    label2.Text = "É uma árvore gigante com membros humanos. É coberto por sacos que atuam como hitbox \r\ndo chefe. Quando o jogador o encontrar, encontrará alguns mortos-vivos na arena que \r\nlutarão ao lado dele durante o combate. Depois de ser reduzido a um certo limite de saúde,\r\nem vez de passar por uma transformação, a arena de batalha muda. \r\n\r\nEsta enorme árvore está cheia de maldições e é objeto de adoração para o habitantes do\r\nAssentamento de mortos-vivos.\r\n";
                }
                //Sabio de Cristal
                else if (radioButton4.Checked)
                {
                    pictureBox1.Image = Properties.Resources.SabioCristal;
                    label1.Text = "Sábio de Cristal";
                    label2.Text = "Ele veste um traje de mago.chapéugrande o suficiente para cobrir o rosto.\r\n Eles lançam feitiços principalmente usando um orbe mágico, mas podem atacar\r\n jogadores que se aproximam muito deles com suas mãos.florete. \r\n\r\nOs jogadores devem estar alertas ao se aproximarem de sua arena, pois a luta \r\ncontra o chefe começa assim que eles entram. Depois de ser reduzido a um \r\ncerto limite de saúde, o chefe começará a gerar clones que se parecem muito com ele,\r\n exceto pela diferença na cor de sua magia.\r\n";
                }
                //Vigilantes
                else if (radioButton5.Checked)
                {
                    pictureBox1.Image = Properties.Resources.Vigilantes;
                    label1.Text = "Vigilantes do Abismo";
                    label2.Text = "Os Vigilantes do Abismo são humanóides altos vestidos com armaduras de couro,\r\nempunhando uma espada larga na mão direita e uma adaga na mão esquerda. \r\nOs jogadores encontrarão os Vigilantes do Abismo aparentemente lutando entre si \r\nquando os encontrarem. Depois de ser reduzido a um certo limite de saúde, a espada larga \r\ndo chefe principal é infundida com Fogo, aumentando seus ataques. \r\n\r\nOs Vigilantes do Abismo, sua alma, passando de um \r\ncorpo para o outro, sempre em guerra, é um dos Senhores das Cinzas, e é o primeiro \r\ndos 5 que o jogador encontrará.\r\n";
                }
                //Diaconos das profundezas
                else if (radioButton6.Checked)
                {
                    pictureBox1.Image = Properties.Resources.Diaconos;
                    label1.Text = "Diaconos das Profundezas";
                    label2.Text = "São um grupo de clérigos que exercemcastiçaisem combate. Alguns empunham sua arma\r\nsemelhante à de uma espada, enquanto outros a usam como um catalisador para a \r\npiromancia. Esta congregação de clérigos defende uma alma errante, que eventualmente se\r\nrevela ser o arquidiácono depois deser derrubado a um certo limite de saúde.\r\n";
                }
                //Grande Lorde Wolnir
                else if (radioButton7.Checked)
                {
                    pictureBox1.Image = Properties.Resources.Wolnir;
                    label1.Text = "Grande Lorde Wolnir";
                    label2.Text = "O Lorde Supremo Wolnir é um esqueleto enorme coberto de joias, das quais as pulseiras \r\natuam como a caixa de colisão do chefe. Ele ataca principalmente o jogador com seu \r\ntorso e membros, mas ocasionalmente pode empunhar uma espada, tornando a luta \r\nmais perigosa. Este esqueleto colossal está imbuído de escuridão mortal e comanda um \r\nexército de esqueletos em sua defesa\r\n";
                }
                //Rei Demônio
                else if (radioButton8.Checked)
                {
                    pictureBox1.Image = Properties.Resources.ReiDemonio;
                    label1.Text = "Velho Rei demônio";
                    label2.Text = "O Velho Rei Demônio é um grande demônio coberto de chamas e empunha um gigante\r\nmartelo em combate. Queimando nas covas do lago fumegante, os cadáveres dos \r\ndemônios o cercam. Depois de ser reduzido a um certo limite de saúde, ele será fortalecido \r\ncom uma aura flamejante mais forte, dando-lhe acesso a ataques mais fortes\r\n";
                }
                //Pontife Sulyvhan
                else if (radioButton9.Checked)
                {
                    pictureBox1.Image = Properties.Resources.Sulyvahn;
                    label1.Text = "Pontife Sulyvahn";
                    label2.Text = "O pontífice Sulyvahn é um humanóide alto vestido com vestes de feiticeiro enfeitadas \r\ncom joias. Ele empunha duas grandes espadas em combate - aespada largaem sua mão\r\nesquerda emanando uma aura roxa e aespada largaem sua mão direita envolto em chamas. \r\nDepois de ser derrubado a um certo limite de saúde, asas semelhantes a galhos brotam de \r\nsuas costas.\r\n";
                }
                //Yhorm O Gigante
                else if (radioButton10.Checked)
                {
                    pictureBox1.Image = Properties.Resources.Yhorm;
                    label1.Text = "Yorm o gigante";
                    label2.Text = "Conhecido como o \"senhor recluso da Capital Profanada\", Yhorm é descendente de \r\num antigo conquistador, mas foi solicitado pelo próprio povo uma vez subjugado \r\npara liderá-los. No passado, ele era um combatente gigante e habilidoso, poderoso o \r\nsuficiente para se tornar um senhor de uma cidade e um Senhor das Cinzas. Durante \r\no combate, ataca os jogadores em massafacãoque brilha como brasas depois de ser \r\nreduzido a um certo limite de saúde.\r\n";
                }
                //Aldrich, Devorador de Deuses
                else if (radioButton11.Checked)
                {
                    pictureBox1.Image = Properties.Resources.Aldritch;
                    label1.Text = "Aldritch, Devorador de Deuses";
                    label2.Text = "Aldritch aparece para o jogador como uma massa escura de ossos e carne com a parte \r\nsuperior do corpo e roupas semelhantes às usadas por Gwyndolinem Almas escuras. \r\nEle ataca com as armas de Gwyndolin. Um catalisador que é imbuído de fogo após \r\nser reduzido a um certo limite de saúde e um arco.\r\n";
                }
                //Dançarina do Vale Boral
                else if (radioButton12.Checked)
                {
                    pictureBox1.Image = Properties.Resources.Dancarina;
                    label1.Text = "Dançarina do Vale Boral";
                    label2.Text = "A Dançarina é uma cavaleira de armadura alto com uma capa espectral e se esconde em\r\ndireção ao jogador quando encontrado. Durante o combate, ela empunha uma chama \r\nespada na mão esquerda e, depois de atingir um certo limite de saúde, empunha uma \r\nespada de freixo na direita, uma reminiscência dePontífice Sulyvahnarmas.\r\n";
                }
                //Armadura Matadora de Dragões
                else if (radioButton13.Checked)
                {
                    pictureBox1.Image = Properties.Resources.ArmaduraMatadora;
                    label1.Text = "Armadura Matadora de Dragões";
                    label2.Text = "É  uma armadura autônoma que guarda a entrada dos Grandes Arquivos, e é assistido\r\n por Pilgrim Butterflies, que na verdade são as que animam o traje. Ele ataca os jogadores\r\n com um ataque eletrificadomachado grandee pode atacar e proteger contra ataques de\r\n jogadores com sua enormeescudo. Depois de ser reduzido a um certo limite de saúde, os \r\nprojéteis começarão a chover na arena de batalha.\r\n";
                }
                //Orceiros, O rei Consumido
                else if (radioButton14.Checked)
                {
                    pictureBox1.Image = Properties.Resources.Oceiros;
                    label1.Text = "Orceiros, O Rei Consumido";
                    label2.Text = "Oceiros é encontrado no jardim abaixo do Castelo Lothric, guardando um santuário. \r\nPode-se supor que ele é cego (comoSeath), pois suas órbitas estão vazias, e ele faz \r\nreferências a isso ao longo da luta. Ele é um chefe muito vocal e fala de um bebê \r\ninvisível ou imaginário que embala em seu braço durante a primeira metade da luta. \r\n\r\nOceiros inicialmente ataca o jogador com um cajado, mas depois de ser derrubado \r\na um certo limite de saúde, fica de quatro e ataca como uma fera.\r\n";
                }
                //Campeão Gundyr
                else if (radioButton15.Checked)
                {
                    pictureBox1.Image = Properties.Resources.CampeaomGundyr;
                    label1.Text = "Campeão Gundyr";
                    label2.Text = "Campeão Gundyr é uma versão diferente deIudex Gundyr, no entanto, ele utiliza o mesmo\r\nconjunto de movimentos de  Iudex Gundyr com a adição de novos ataques. Ele é muito \r\nmais agressivo do que era nocemitério de cinzas. Depois de ser reduzido a um certo limite \r\nde saúde, em vez de passar por uma transformação física, seus olhos ficam vermelhos e \r\ncomeçam a atacar o jogador com muito mais agressividade.\r\n";
                }
                //Principe Lothric
                else if (radioButton16.Checked)
                {
                    pictureBox1.Image = Properties.Resources.Lothric;
                    label1.Text = "Principe Lothric";
                    label2.Text = "Lothric é um chefe puramente mágico e é uma força a ser reconhecida enquanto está \r\nacompanhado por seu irmão e chefe parceiro.Lorian, Príncipe Ancião. Ele é uma figura \r\nalta encapuzada com a característica mais notável sendo seus braços finos, e é o único \r\ndos príncipes gêmeos a falar durante as cenas. \r\n\r\nEmbora ele não seja combatido durante a primeira fase, após esgotar a barra de saúde \r\nde Lorian uma vez, Lothric se teletransporta para o lado de seu irmão e se agarra em \r\nsuas costas pelo restante da luta.\r\n";
                }
                //Wyvern Ancião
                else if (radioButton17.Checked)
                {
                    pictureBox1.Image = Properties.Resources.Wyvern;
                    label1.Text = "Ancião Wyvern";
                    label2.Text = "O Ancient Wyvern é um grande wyvern cinza, e sua luta contra o chefe é única, pois \r\nhá uma maneira adicional de matá-lo além da tática normal de bater e correr necessária \r\npara a maioria dos chefes. Em vez de lutar contra o wyvern de frente, os jogadores \r\npodem optar por subir as ruínas, lutando contra inimigos regulares, para chegar alto o\r\n suficiente para desferir um ataque de mergulho na cabeça do dragão.\r\n";
                }
                //Rei Sem Nome
                else if (radioButton18.Checked)
                {
                    pictureBox1.Image = Properties.Resources.ReiSemNome;
                    label1.Text = "Rei sem nome";
                    label2.Text = "O Rei Sem Nome é um humanóide blindado montado em um wyvern azul e ataca\r\n os jogadores com seulança. Durante a primeira fase da luta contra o chefe, seu \r\nnome é mostrado como \"Rei da Tempestade\", até que o wyvern que ele monta seja \r\nmorto.\r\nIsso inicia a segunda fase em que seu nome muda para \"Rei sem nome\".\r\n";
                }
                //Alma Das Cinzas
                else if (radioButton19.Checked)
                {
                    pictureBox1.Image = Properties.Resources.AlmaDasCinzas;
                    label1.Text = "Alma DAs Cinzas";
                    label2.Text = "É visto como o amálgama de todos os Lordes da Cinzas, com uma variedade de feitiços \r\ne movesets da Dark Dialectics usados ​​durante sua primeira fase e o uso do moveset de\r\nGwyn para a segunda fase. \r\nEle aparece para o jogador como um cavaleiro fortemente blindado e empunha o Firelink \r\nGreatswordna batalha, uma grande espada que pode se transformar em uma das três outras\r\n formas durante a primeira fase da luta. Depois de esgotar sua saúde uma vez, a segunda fase \r\ncomeça, onde o chefe recupera toda a sua saúde e mantém um moveset.\r\n";
                }
                else
                {
                    pictureBox1.Image = null;
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                if(radioButton1.Checked == true){
                    this.pictureBox1.Image = Properties.Resources.SIegward;
                    label1.Text = "Personagens de Missão";
                    label2.Text = "Os Personagens não jógaveis(NPC), de missões, são aqueles que ao se ter algum diálogo\r\nem especifico ou se encontrados em uam certa área do jogo, as vezes com certos eventos\r\nespecificos também, poderá desbloquear a respectiva missão daquele personagem também\r\nassim podendo ganhar uma recompesa por aquela atividade.\r\n\r\nIsso também pode servir para ganhar as conquistas de desafios do jogo, para aqueles\r\ninteressados em concluir todas as atividades do jogo. ";

                }
                else
                {
                    this.pictureBox1.Image = null;
                }
            }
            if (comboBox1.SelectedIndex == 1)
            {
                if (radioButton1.Checked == true)
                {
                    label1.Text = "Iudex Gundyr";
                    label2.Text = "Iudex Gundyr é um grande humanóide vestido com uma armadura pesada e ataca o jogador \r\nusando um grandealabarda. Os jogadores encontrarão umespadaembutido em seu peito \r\nquando o encontram pela primeira vez. \r\nDepois de ser derrubado a um certo limite de saúde, uma massa negra gigante emerge de seu\r\npescoço que lhe dá acesso a ataques adicionais. \r\nEste chefe não é opcional e o jogador terá que enfrentá-lo para ter acesso aSantuário Firelink.\r\n";
                    radioButton1.Text = "Iudex Gundyr";
                    this.pictureBox1.Image = null;
                    pictureBox1.Visible = true;
                    this.pictureBox1.Image = Properties.Resources.IudexGundyr;
                }
                else
                {
                    this.pictureBox1.Image = null;
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                if (radioButton2.Checked)
                {
                    pictureBox1.Visible = true;
                    this.pictureBox1.Image = Properties.Resources.FIrekeeper;
                    label1.Text = "Personagens de diálogo/\r\nAprimoramentos";
                    label2.Text = "Os Personagen não joágaveis(NPC), que apenas servem para diálogo, são aqueles em que\r\nsão encontrados durante o jogo e costumam a expelir algumas falas onde podem servir\r\ntanto para maior compreensão da história e desse mundo, mesmo que a história de\r\nDark Souls III possua elementos que são abertos a interpetação, e também servem para\r\ncompor o ambiente afim de propor mais o jogador a imersãode uma forma que ele também\r\npossa compreender a ambientação do mundo e o que está acontecendo nele.\r\n\r\nAlguns desses NPC's, podem aparecer posteriormente até mesmo como chefes nas DLC's\r\ndo jogo, Isso se enquadra e perosnagens que só se pode dialogar ou que se pode\r\nusa-lo para aumentar o nível ou comprar e vender itens com as almas que você ganha\r\nao derrotar inimigos";
                }
                else
                {
                    this.pictureBox1.Image = null;
                }
            }
                if (comboBox1.SelectedIndex == 1)
                {
                    if (radioButton2.Checked == true)
                    {
                    label1.Text = "Vordt do Vale Boreal";
                    label2.Text = "Vordt do Vale Borealé uma grande criatura quadrúpede vestindo uma pesada armadura \r\nde cavaleiro e muitos dos ataques em seu moveset apresentam umgrande marteloque se \r\nassemelha a uma maça.\r\n \r\nQuando os jogadores o encontram, ele é visto saindo de um orbe de névoa. \r\nDepois de ser reduzido a um certo limite de saúde, a névoa azul ao seu redor e sua arma se \r\nintensificam, infligindo lentamenteQueimadura por friono jogador se eles ficarem perto dele,\r\nEsta é a primeira ocorrência de congelamento que o jogador pode encontrar no jogo.\r\n";
                    radioButton2.Text = "Vordt";
                    this.pictureBox1.Image = null;
                    pictureBox1.Visible = true;
                    this.pictureBox1.Image = Properties.Resources.Vordt;
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
                    label1.Text = "Grande Madeira\r\nApodrecida";
                    label2.Text = "É uma árvore gigante com membros humanos. É coberto por sacos que atuam como hitbox \r\ndo chefe. Quando o jogador o encontrar, encontrará alguns mortos-vivos na arena que \r\nlutarão ao lado dele durante o combate. Depois de ser reduzido a um certo limite de saúde,\r\nem vez de passar por uma transformação, a arena de batalha muda. \r\n\r\nEsta enorme árvore está cheia de maldições e é objeto de adoração para o habitantes do\r\nAssentamento de mortos-vivos.\r\n";
                    this.pictureBox1.Image = null;
                    pictureBox1.Visible = true;
                    this.pictureBox1.Image = Properties.Resources.GrandeMadeira;
                    
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
                    label1.Text = "Sábio de Cristal";
                    label2.Text = "Ele veste um traje de mago.chapéugrande o suficiente para cobrir o rosto.\r\n Eles lançam feitiços principalmente usando um orbe mágico, mas podem atacar\r\n jogadores que se aproximam muito deles com suas mãos.florete. \r\n\r\nOs jogadores devem estar alertas ao se aproximarem de sua arena, pois a luta \r\ncontra o chefe começa assim que eles entram. Depois de ser reduzido a um \r\ncerto limite de saúde, o chefe começará a gerar clones que se parecem muito com ele,\r\n exceto pela diferença na cor de sua magia.\r\n";
                    this.pictureBox1.Image = null;
                    pictureBox1.Visible = true;
                    this.pictureBox1.Image = Properties.Resources.SabioCristal;
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
                    label1.Text = "Vigilantes do Abismo";
                    label2.Text = "Os Vigilantes do Abismo são humanóides altos vestidos com armaduras de couro,\r\nempunhando uma espada larga na mão direita e uma adaga na mão esquerda. \r\nOs jogadores encontrarão os Vigilantes do Abismo aparentemente lutando entre si \r\nquando os encontrarem. Depois de ser reduzido a um certo limite de saúde, a espada larga \r\ndo chefe principal é infundida com Fogo, aumentando seus ataques. \r\n\r\nOs Vigilantes do Abismo, sua alma, passando de um \r\ncorpo para o outro, sempre em guerra, é um dos Senhores das Cinzas, e é o primeiro \r\ndos 5 que o jogador encontrará.\r\n";
                    this.pictureBox1.Image = null;
                    pictureBox1.Visible = true;
                    this.pictureBox1.Image = Properties.Resources.Vigilantes;
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
                    label1.Text = "Diaconos das\r\nProfundezas";
                    label2.Text = "São um grupo de clérigos que exercemcastiçaisem combate. Alguns empunham sua arma\r\nsemelhante à de uma espada, enquanto outros a usam como um catalisador para a \r\npiromancia. Esta congregação de clérigos defende uma alma errante, que eventualmente se\r\nrevela ser o arquidiácono depois deser derrubado a um certo limite de saúde.\r\n";
                    this.pictureBox1.Image = null;
                    pictureBox1.Visible = true;
                    this.pictureBox1.Image = Properties.Resources.Diaconos;
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
                    label1.Text = "Alto Lorde Wolnir";
                    label2.Text = "O Lorde Supremo Wolnir é um esqueleto enorme coberto de joias, das quais as pulseiras \r\natuam como a caixa de colisão do chefe. Ele ataca principalmente o jogador com seu \r\ntorso e membros, mas ocasionalmente pode empunhar uma espada, tornando a luta \r\nmais perigosa. Este esqueleto colossal está imbuído de escuridão mortal e comanda um \r\nexército de esqueletos em sua defesa\r\n";
                    this.pictureBox1.Image = null;
                    pictureBox1.Visible = true;
                    this.pictureBox1.Image = Properties.Resources.Wolnir;
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
                    label1.Text = "Velho Rei demônio";
                    label2.Text = "O Velho Rei Demônio é um grande demônio coberto de chamas e empunha um gigante\r\nmartelo em combate. Queimando nas covas do lago fumegante, os cadáveres dos \r\ndemônios o cercam. Depois de ser reduzido a um certo limite de saúde, ele será fortalecido \r\ncom uma aura flamejante mais forte, dando-lhe acesso a ataques mais fortes\r\n";
                    this.pictureBox1.Image = null;
                    pictureBox1.Visible = true;
                    this.pictureBox1.Image = Properties.Resources.ReiDemonio;
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
                    label1.Text = "Pontificie Sulyvahn";
                    label2.Text = "O pontífice Sulyvahn é um humanóide alto vestido com vestes de feiticeiro enfeitadas \r\ncom joias. Ele empunha duas grandes espadas em combate - aespada largaem sua mão\r\nesquerda emanando uma aura roxa e aespada largaem sua mão direita envolto em chamas. \r\nDepois de ser derrubado a um certo limite de saúde, asas semelhantes a galhos brotam de \r\nsuas costas.\r\n";
                    this.pictureBox1.Image = null;
                    pictureBox1.Visible = true;
                    this.pictureBox1.Image = Properties.Resources.Sulyvahn;
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
                    label1.Text = "Yhorn o gigante";
                    label2.Text = "Conhecido como o senhor recluso da Capital Profanada, Yhorm é descendente de \r\num antigo conquistador, mas foi solicitado pelo próprio povo uma vez subjugado \r\npara liderá-los. No passado, ele era um combatente gigante e habilidoso, poderoso o \r\nsuficiente para se tornar um senhor de uma cidade e um Senhor das Cinzas. Durante \r\no combate, ataca os jogadores em massafacãoque brilha como brasas depois de ser \r\nreduzido a um certo limite de saúde.\r\n";
                    this.pictureBox1.Image = null;
                    pictureBox1.Visible = true;
                    this.pictureBox1.Image = Properties.Resources.Yhorm;
                }
                else
                {
                    this.pictureBox1.Image = null;
                }
            }
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                if (radioButton11.Checked == true)
                {
                    label1.Text = "Aldritch, Devorador\r\nde Deuses";
                    label2.Text = "Aldritch aparece para o jogador como uma massa escura de ossos e carne com a parte \r\nsuperior do corpo e roupas semelhantes às usadas por Gwyndolinem Almas escuras. \r\nEle ataca com as armas de Gwyndolin. Um catalisador que é imbuído de fogo após \r\nser reduzido a um certo limite de saúde e um arco.\r\n";
                    this.pictureBox1.Image = null;
                    pictureBox1.Visible = true;
                    this.pictureBox1.Image = Properties.Resources.Aldritch;
                }
                else
                {
                    this.pictureBox1.Image = null;
                }
            }
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                if (radioButton12.Checked == true)
                {
                    label1.Text = "Dançarina do \r\nVale Boral";
                    label2.Text = "A Dançarina é uma cavaleira de armadura alto com uma capa espectral e se esconde em\r\ndireção ao jogador quando encontrado. Durante o combate, ela empunha uma chama \r\nespada na mão esquerda e, depois de atingir um certo limite de saúde, empunha uma \r\nespada de freixo na direita, uma reminiscência dePontífice Sulyvahnarmas.\r\n";
                    this.pictureBox1.Image = null;
                    pictureBox1.Visible = true;
                    this.pictureBox1.Image = Properties.Resources.Dancarina;
                }
                else
                {
                    this.pictureBox1.Image = null;
                }
            }
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                if (radioButton13.Checked == true)
                {
                    label1.Text = "Armadura Matadora\r\nde Dragões";
                    label2.Text = "É  uma armadura autônoma que guarda a entrada dos Grandes Arquivos, e é assistido\r\n por Pilgrim Butterflies, que na verdade são as que animam o traje. Ele ataca os jogadores\r\n com um ataque eletrificadomachado grandee pode atacar e proteger contra ataques de\r\n jogadores com sua enormeescudo. Depois de ser reduzido a um certo limite de saúde, os \r\nprojéteis começarão a chover na arena de batalha.\r\n";
                    this.pictureBox1.Image = null;
                    pictureBox1.Visible = true;
                    this.pictureBox1.Image = Properties.Resources.ArmaduraMatadora;
                }
                else
                {
                    this.pictureBox1.Image = null;
                }
            }
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                if (radioButton14.Checked == true)
                {
                    label1.Text = "Orceiros, O \r\nRei Consumido";
                    label2.Text = "Oceiros é encontrado no jardim abaixo do Castelo Lothric, guardando um santuário. \r\nPode-se supor que ele é cego (comoSeath), pois suas órbitas estão vazias, e ele faz \r\nreferências a isso ao longo da luta. Ele é um chefe muito vocal e fala de um bebê \r\ninvisível ou imaginário que embala em seu braço durante a primeira metade da luta. \r\n\r\nOceiros inicialmente ataca o jogador com um cajado, mas depois de ser derrubado \r\na um certo limite de saúde, fica de quatro e ataca como uma fera.\r\n";
                    this.pictureBox1.Image = null;
                    pictureBox1.Visible = true;
                    this.pictureBox1.Image = Properties.Resources.Oceiros;
                }
                else
                {
                    this.pictureBox1.Image = null;
                }
            }
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                if (radioButton15.Checked == true)
                {
                    label1.Text = "Campeão Gundyr";
                    label2.Text = "Campeão Gundyr é uma versão diferente deIudex Gundyr, no entanto, ele utiliza o mesmo\r\nconjunto de movimentos de  Iudex Gundyr com a adição de novos ataques. Ele é muito \r\nmais agressivo do que era nocemitério de cinzas. Depois de ser reduzido a um certo limite \r\nde saúde, em vez de passar por uma transformação física, seus olhos ficam vermelhos e \r\ncomeçam a atacar o jogador com muito mais agressividade.\r\n";
                    this.pictureBox1.Image = null;
                    pictureBox1.Visible = true;
                    this.pictureBox1.Image = Properties.Resources.CampeaomGundyr;
                }
                else
                {
                    this.pictureBox1.Image = null;
                }
            }
        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                if (radioButton16.Checked == true)
                {
                    label1.Text = "Principe Lothric";
                    label2.Text = "Lothric é um chefe puramente mágico e é uma força a ser reconhecida enquanto está \r\nacompanhado por seu irmão e chefe parceiro.Lorian, Príncipe Ancião. Ele é uma figura \r\nalta encapuzada com a característica mais notável sendo seus braços finos, e é o único \r\ndos príncipes gêmeos a falar durante as cenas. \r\n\r\nEmbora ele não seja combatido durante a primeira fase, após esgotar a barra de saúde \r\nde Lorian uma vez, Lothric se teletransporta para o lado de seu irmão e se agarra em \r\nsuas costas pelo restante da luta.\r\n";
                    this.pictureBox1.Image = null;
                    pictureBox1.Visible = true;
                    this.pictureBox1.Image = Properties.Resources.Lothric;
                }
                else
                {
                    this.pictureBox1.Image = null;
                }
            }
        }

        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                if (radioButton17.Checked == true)
                {
                    label1.Text = "Ancião Wyvern";
                    label2.Text = "O Ancient Wyvern é um grande wyvern cinza, e sua luta contra o chefe é única, pois \r\nhá uma maneira adicional de matá-lo além da tática normal de bater e correr necessária \r\npara a maioria dos chefes. Em vez de lutar contra o wyvern de frente, os jogadores \r\npodem optar por subir as ruínas, lutando contra inimigos regulares, para chegar alto o\r\n suficiente para desferir um ataque de mergulho na cabeça do dragão.\r\n";
                    this.pictureBox1.Image = null;
                    pictureBox1.Visible = true;
                    this.pictureBox1.Image = Properties.Resources.Wyvern;
                }
                else
                {
                    this.pictureBox1.Image = null;
                }
            }
        }

        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                if (radioButton18.Checked == true)
                {
                    pictureBox1.Image = Properties.Resources.ReiSemNome;
                    label1.Text = "Rei sem nome";
                    label2.Text = "O Rei Sem Nome é um humanóide blindado montado em um wyvern azul e ataca\r\n os jogadores com seulança. Durante a primeira fase da luta contra o chefe, seu \r\nnome é mostrado como \"Rei da Tempestade\", até que o wyvern que ele monta seja \r\nmorto.\r\nIsso inicia a segunda fase em que seu nome muda para \"Rei sem nome\".\r\n";
                    this.pictureBox1.Image = null;
                    pictureBox1.Visible = true;
                    this.pictureBox1.Image = Properties.Resources.ReiSemNome;
                    
                }
                else
                {
                    this.pictureBox1.Image = null;
                }
            }
        }

        private void radioButton19_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                if (radioButton19.Checked == true)
                {
                    label1.Text = "Alma das Cinzas";
                    label2.Text = "É visto como o amálgama de todos os Lordes da Cinzas, com uma variedade de feitiços \r\ne movesets da Dark Dialectics usados ​​durante sua primeira fase e o uso do moveset de\r\nGwyn para a segunda fase. \r\nEle aparece para o jogador como um cavaleiro fortemente blindado e empunha o Firelink \r\nGreatswordna batalha, uma grande espada que pode se transformar em uma das três outras\r\n formas durante a primeira fase da luta. Depois de esgotar sua saúde uma vez, a segunda fase \r\ncomeça, onde o chefe recupera toda a sua saúde e mantém um moveset.\r\n";
                    this.pictureBox1.Image = null;
                    pictureBox1.Visible = true;
                    this.pictureBox1.Image = Properties.Resources.AlmaDasCinzas;
                }
                else
                {
                    this.pictureBox1.Image = null;
                }
            }
        }

        private void Personagens_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            player.controls.play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            player.controls.stop();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 outro = new Form1();
            outro.Show();
        }
    }
}
