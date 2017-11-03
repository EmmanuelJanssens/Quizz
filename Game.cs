using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Quizz
{

    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }

        Dictionary<string, List<string>> _Question;
        Dictionary<string, List<string>> _Answers;
        Dictionary<string, List<string>> _Category;

        string _RightAnswer;

        int timeForAnswer = 10;

        Form frmAutoClosing;
        Label lblAutoClosingMSG;
        Timer tmrAutoClose;
        int autoCloseTimer = 3;

        int _totalQuestions;

        private void Checked( object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            string res = rb.Tag.ToString();
            if(res == "True")
            {
                NextQuestion();
                timeForAnswer = 10;
            }
            else if(res =="False")
            {
                countDown.Stop();

                autoCloseTimer = 3;

                lblAutoClosingMSG.Text = "Vous avez choisi la mauvaise réponse :(";

                frmAutoClosing.Show();
                tmrAutoClose.Start();

                rbAnswerOne.Enabled = false;
                rbAnswerTwo.Enabled = false;
                rbAnswerThree.Enabled = false;

            }
        }
        private void Game_Load(object sender, EventArgs e)
        {
            frmAutoClosing = new Form();
            frmAutoClosing.Text = "";
            frmAutoClosing.AutoSize = true;
            frmAutoClosing.StartPosition = FormStartPosition.CenterScreen;
            lblAutoClosingMSG = new Label();
            lblAutoClosingMSG.Parent = frmAutoClosing;
            lblAutoClosingMSG.AutoSize = true;
            lblAutoClosingMSG.TextAlign = ContentAlignment.MiddleCenter;

            frmAutoClosing.Size = new Size(lblAutoClosingMSG.Size.Width + 80, lblAutoClosingMSG.Size.Height + 100);
            lblAutoClosingMSG.Location = new Point(0, frmAutoClosing.Size.Height / 4  );
            tmrAutoClose = new Timer();
            tmrAutoClose.Interval = 1000;
            tmrAutoClose.Tick += showFrmDelay;
            

            _Category = MySQL.current.getData("SELECT Categorie FROM categorie WHERE idCategorie = " + GameManager.current.CategoryID.ToString());
            lblCategory.Text = _Category["Categorie"][0];

            _totalQuestions = int.Parse(MySQL.current.getData("SELECT COUNT(*) as total FROM question where Categorie_idCategorie = " + GameManager.current.CategoryID)["total"][0]);
            rbAnswerOne.MouseClick += Checked;
            rbAnswerTwo.MouseClick += Checked;
            rbAnswerThree.MouseClick += Checked;

            NextQuestion();


        }
        private void NextQuestion()
        {


            GameManager.current.QuestionID ++;
            if(GameManager.current.QuestionID <= _totalQuestions)
            {
                _Question = MySQL.current.getData("SELECT idQuestion,question FROM question INNER JOIN categorie ON Categorie_idCategorie= " + GameManager.current.CategoryID.ToString()+ " WHERE idQuestion ="+GameManager.current.CategoryID.ToString());
                lblQuestion.Text = _Question["question"][0];

                string answerQuery = "SELECT idReponse,Reponse,Juste,Question_idQuestion FROM reponse INNER JOIN question on reponse.Question_idQuestion = " + GameManager.current.QuestionID.ToString();
                _Answers = MySQL.current.getData(answerQuery);
                rbAnswerOne.Text = _Answers["Reponse"][0];
                rbAnswerTwo.Text = _Answers["Reponse"][1];
                rbAnswerThree.Text = _Answers["Reponse"][2];

                rbAnswerOne.Tag = _Answers["Juste"][0];
                rbAnswerTwo.Tag = _Answers["Juste"][1];
                rbAnswerThree.Tag = _Answers["Juste"][2];

                for (int i = 0; i < 3; i++)
                {
                    if (_Answers["Juste"][i] == "True")
                    {
                        _RightAnswer = _Answers["Reponse"][i];
                        break;
                    }
                }
                timeForAnswer = 11;
                rbAnswerOne.Enabled = true;
                rbAnswerTwo.Enabled = true;
                rbAnswerThree.Enabled = true;
                countDown.Start();
            }
            else
            {
                Console.WriteLine("NO QUESTIONS");
            }
           
        }

        private void cmdNextTest_Click(object sender, EventArgs e)
        {
            NextQuestion();
        }

        private void showFrmDelay(object sender,EventArgs e)
        {
            autoCloseTimer--;

            if (autoCloseTimer <= 1)
            {
                frmAutoClosing.Hide() ;
                tmrAutoClose.Stop();
                NextQuestion();
               
            }
        }
        private void countDown_Tick(object sender, EventArgs e)
        {
            timeForAnswer--;
            if(timeForAnswer <= 1)
            {
                //Show correct answer
                tmrAutoClose.Start();
                autoCloseTimer = 3;
                lblAutoClosingMSG.Text = "Vous avez choisi la mauvaise réponse :( \n La reponse correcte est : " + _RightAnswer;
                frmAutoClosing.Show();
                countDown.Stop();
                timeForAnswer = 10;
            }
            lblTimer.Text = timeForAnswer.ToString();
        }

        private void Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            rbAnswerOne.MouseClick -= Checked;
            rbAnswerTwo.MouseClick -= Checked;
            rbAnswerThree.MouseClick -= Checked;
        }
    }
    
}
