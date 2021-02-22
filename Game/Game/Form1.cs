using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {
        public int playerInputNum = 0;
        public int aiNum = 0;
        public int min = 1, max = 100;
        public int tryCout = 7;
        public int aiRndNumber = 0;
        public bool gameStoped = false;
        public bool gameWin = false;
       

      public Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            aiNum = random.Next(1, 100);
            AI();
            gameWin = false;
            gameStoped = false;
            txtPlayerAnswer.ReadOnly = false;
            txtPlayerQuestion.ReadOnly = false;
            BtnPlay.Text = "Mnac " + tryCout + " qayl";
            BtnPlay.Enabled = true;
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            
            if (Conditions() == false && gameWin == false)
            {
                AIGuesses();
                PlayerGuesses();
                tryCout--;
                BtnPlay.Text = "Mnac " + tryCout + " qayl";
               
            }
            else if(gameWin == false)
            {
                MessageBox.Show("Sxal arjeq es mutqagrel", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if(tryCout <=0)
            {
                GameOver();
            }
           
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        void AI()
        {
            txtAIAnswer.Clear();
            aiRndNumber = (max+min-1) / 2;

            txtAIQuestion.Text = "Qo mtapahac tiv@ meca te poqr " + aiRndNumber + "-ic?";
           
        }

        bool Conditions()
        {
            if (txtPlayerAnswer.Text != ">" || txtPlayerAnswer.Text != "<" || txtPlayerAnswer.Text != "=" && String.IsNullOrEmpty(txtPlayerAnswer.Text))
            {
                if (String.IsNullOrEmpty(txtPlayerQuestion.Text)
                || int.Parse(txtPlayerQuestion.Text) <= 1 && int.Parse(txtPlayerQuestion.Text) >= 100 && int.TryParse(txtAIQuestion.Text, out playerInputNum))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }
        void AIGuesses()
        {
           
                if (txtPlayerAnswer.Text == ">")
                {
                min = aiRndNumber + 1;
                    AI();
                }
                if (txtPlayerAnswer.Text == "<")
                {
                    max = aiRndNumber - 1;
                    AI();
                }
                if (txtPlayerAnswer.Text == "=")
                {
                    AIWin();
                }
               
        }

        

        void PlayerGuesses()
        {
            txtAIAnswer.Clear();
                if (int.Parse(txtPlayerQuestion.Text) > aiNum)
                {
                    txtAIAnswer.Text = "qo mutqgrvac tiv@ mec e";
                }
                else if (int.Parse(txtPlayerQuestion.Text) < aiNum)
                {
                    
                    txtAIAnswer.Text = "qo mutqgrvac tiv@ poqr e";
                }
                else if (int.Parse(txtPlayerQuestion.Text) == aiNum)
                {
                    PlayerWin();
                }  
        }

        void PlayerWin()
        {
            txtAIAnswer.Clear();
            txtAIAnswer.Text = "du haxtecir";
            txtAIQuestion.Text = "Es mtapahel ei" + aiNum + " tiv@";
            txtPlayerAnswer.ReadOnly = true;
            txtPlayerQuestion.ReadOnly = true;
            gameWin = true;
            BtnPlay.Enabled = false;
        }

        void AIWin()
        {
            txtAIAnswer.Clear();
            txtAIQuestion.Clear();
            txtAIQuestion.Text = "Es haxteci";
            txtPlayerAnswer.ReadOnly = true;
            txtPlayerQuestion.ReadOnly = true;
            gameWin = true;
            BtnPlay.Enabled = false;
        }

        

        void GameOver()
        {
            txtAIQuestion.Clear();
            txtAIAnswer.Clear();
            txtPlayerAnswer.ReadOnly = true;
            txtPlayerQuestion.ReadOnly = true;
            txtAIAnswer.Text = "Chkaroxacanq gushakel";
            txtAIQuestion.Text = "Es mtapahel ei" + aiNum + " tiv@";
            BtnPlay.Enabled = false;
        }

       
    }
}
