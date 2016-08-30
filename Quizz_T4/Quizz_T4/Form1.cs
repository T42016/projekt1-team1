using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Quizz_T4
{
    public partial class Form1 : Form
    {
        static int iteration = 1;
        private int rightAnswers;
        private int questionNr;


        List<Query> questions = new List<Query>();
        List<Answers> answers = new List<Answers>();
        string[,] scrambledInformation = new string[10, 6];


        public Form1()
        {
            InitializeComponent();
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            timer10s.Start();
            tc.SelectedTab = tabQuiz;
            gbxQuiz.Enabled = false;
            Thread.Sleep(500);
            gbxQuiz.Enabled = true;
            rightAnswers = 0;
            prgBar10s.Value = 0;
            questionNr = 1;
            lblScore.Text = rightAnswers + " / 10";

            scrambledInformation = Shuffler.Shuffle(ReadyInformation());
            
            rtbxQuestion.Text = scrambledInformation[questionNr - 1, 0];

            btnAnsr1.Text = scrambledInformation[questionNr - 1, 2];
            btnAnsr2.Text = scrambledInformation[questionNr - 1, 3];
            btnAnsr3.Text = scrambledInformation[questionNr - 1, 4];
            btnAnsr4.Text = scrambledInformation[questionNr - 1, 5];
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {


            questions.Add(new Query(rtbnQuestion.Text));
            answers.Add(new Answers(tbxAnswer1.Text, tbxAnswer2.Text, tbxAnswer3.Text, tbxAnswer4.Text));
            Save();

        }
        /// <summary>
        /// Spara funktionen
        /// Här tas informationen som blir inskrivet i formuläret och sparas i 2 filer.
        /// "name_question.quizz" och "name_answer.quizz"
        /// </summary>
        private void Save()
        {


            string questionfile = @"stockquiz\" +  tbxQuizzName.Text + "_question" + ".quiz";
            string answerfile = @"stockquiz\" +  tbxQuizzName.Text + "_answer" + ".quiz";

            if (tbxAnswer1.Text == "" || tbxAnswer2.Text == "" || tbxAnswer3.Text == "" || tbxAnswer4.Text == "" || rtbnQuestion.Text == "" || tbxQuizzName.Text == "")
            {
                MessageBox.Show("You have to fill in all the fields");
                if (tbxAnswer1.Text == "")
                {
                    lblError3.Visible = true;
                }
                else if (tbxAnswer2.Text == "")
                {
                    lblError4.Visible = true;
                }
                else if (tbxAnswer3.Text == "")
                {
                    lblError5.Visible = true;
                }
                else if (tbxAnswer4.Text == "")
                {
                    lblError6.Visible = true;
                }
                else if (tbxQuizzName.Text == "")
                {
                    lblError1.Visible = true;
                }
                else if (rtbnQuestion.Text == "")
                {
                    lblError2.Visible = true;
                }
            }

            else if (tbxAnswer1.Text.Contains("|") || tbxAnswer2.Text.Contains("|") || tbxAnswer3.Text.Contains("|") || tbxAnswer4.Text.Contains("|") || rtbnQuestion.Text.Contains("|") || tbxQuizzName.Text.Contains("|"))
            {
                MessageBox.Show("You cant use the '|' sign");

            }

            
            else
            {
                if (iteration > 10)
                {
                    
                    MessageBox.Show("finished");
                    tbxAnswer1.Text = "";
                    tbxAnswer2.Text = "";
                    tbxAnswer3.Text = "";
                    tbxAnswer4.Text = "";
                    rtbnQuestion.Text = "";
                    tbxQuizzName.Text = "";
                    iteration = 0;
                    return;
                }
                string questionlist = "";
                string answerlist = "";
                string name = tbxQuizzName.Text;


                foreach (Query item in questions)
                {
                    questionlist += item.Question + "\r\n";
                }

                foreach (Answers item in answers)
                {
                    answerlist += item.Answer1 + "|" + item.Answer2 + "|" + item.Answer3 + "|" + item.Answer4 + "\r\n";
                }

                File.WriteAllText(questionfile, questionlist);
                File.WriteAllText(answerfile, answerlist);
                iteration++;
                MessageBox.Show("New question has been added to " + name);
            }
        }
        private void Load()
        {
            answers.Clear();
            /*
            DirectoryInfo di = new DirectoryInfo("C:\\");
            var fileInfo = di.GetFiles("*.quizz", SearchOption.AllDirectories);
            foreach (var file in fileInfo)
            {
                File.ReadAllLines(@"");
            }
            */

            string[] answersLines = System.IO.File.ReadAllLines(@"stockquiz\testAnswers.txt");

            foreach (string line in answersLines)
            {
                string[] words = line.Split('|');

                Answers answerLoad = new Answers(words[0], words[1], words[2], words[3]);

                answers.Add(answerLoad);
            }

            questions.Clear();
            string[] questionLines = System.IO.File.ReadAllLines(@"stockquiz\testQuestions.txt");

            foreach (string line in questionLines)
            {
                string[] words = line.Split('|');

                Query questionLoad = new Query(words[0]);

                questions.Add(questionLoad);
            }

        }


        private void timer10s_Tick(object sender, EventArgs e)
        {
            prgBar10s.Maximum = 1000;
            if (prgBar10s.Value < 1000)
            {
                prgBar10s.Value++;
            }
            else
            {
                timer10s.Stop();
                MessageBox.Show("Time's Up! Next question!");
                questionNr++;

                if (questionNr < 11)
                {
                    rtbxQuestion.Text = scrambledInformation[questionNr - 1, 0];

                    btnAnsr1.Text = scrambledInformation[questionNr - 1, 2];
                    btnAnsr2.Text = scrambledInformation[questionNr - 1, 3];
                    btnAnsr3.Text = scrambledInformation[questionNr - 1, 4];
                    btnAnsr4.Text = scrambledInformation[questionNr - 1, 5];
                    prgBar10s.Value = 0;
                    timer10s.Start();
                }
                else
                {
                    tc.SelectedTab = tabMenu;
                    MessageBox.Show(rightAnswers + " / 10");
                }
                
            }
        }

        private void tbxAnswer1_Click(object sender, EventArgs e)
        {
            tbxAnswer1.Text = "";
        }

        private void tbxAnswer1_Leave(object sender, EventArgs e)
        {
            if (tbxAnswer1.Text != "")
            {

            }
            else
                tbxAnswer1.Text = "Correct Answer";
        }

        private void tbxQuizzName_TextChanged(object sender, EventArgs e)
        {
            IsTextValid.isTextvalid(lblError1, tbxQuizzName.Text);
        }

        private void rtbnQuestion_TextChanged(object sender, EventArgs e)
        {
            IsTextValid.isTextvalid(lblError2, rtbnQuestion.Text);
        }

        private void tbxAnswer1_TextChanged(object sender, EventArgs e)
        {
            IsTextValid.isTextvalid(lblError3, tbxAnswer1.Text);
        }

        private void tbxAnswer2_TextChanged(object sender, EventArgs e)
        {
            IsTextValid.isTextvalid(lblError4, tbxAnswer2.Text);
        }

        private void tbxAnswer3_TextChanged(object sender, EventArgs e)
        {
            IsTextValid.isTextvalid(lblError5, tbxAnswer3.Text);
        }

        private void tbxAnswer4_TextChanged(object sender, EventArgs e)
        {
            IsTextValid.isTextvalid(lblError6, tbxAnswer4.Text);
        }

        private string[,] ReadyInformation()
        {
            //package questions and answers in a two dimentional string array.
            string[,] information = new string[questions.Count, 5];
            string[] theAnswers = new string[4];
            
            for (int a = 0; a < 10; a++)
            {
                information[a, 0] = questions[a].Question;

                theAnswers[0] = answers[a].Answer1;
                theAnswers[1] = answers[a].Answer2;
                theAnswers[2] = answers[a].Answer3;
                theAnswers[3] = answers[a].Answer4;

                for (int b = 1; b < 5; b++)
                {
                    information[a, b] = theAnswers[b-1];
                }

            }

            return information;
        }

        private void btnChooseQuiz_Click(object sender, EventArgs e)
        {
            Load();
            MessageBox.Show("Quiz loaded");
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            tc.SelectedTab = tabMenu;
            prgBar10s.Value = 0;
            timer10s.Stop();
        }
            

        private void btnAnsr1_Click(object sender, EventArgs e)
        {
            timer10s.Start();
            prgBar10s.Value = 0;
            if (btnAnsr1.Text == scrambledInformation[questionNr - 1, 1].ToString())
            {
                rightAnswers++;
                questionNr++;

                if (questionNr < 11)
                {
                    rtbxQuestion.Text = scrambledInformation[questionNr - 1, 0];

                    btnAnsr1.Text = scrambledInformation[questionNr - 1, 2];
                    btnAnsr2.Text = scrambledInformation[questionNr - 1, 3];
                    btnAnsr3.Text = scrambledInformation[questionNr - 1, 4];
                    btnAnsr4.Text = scrambledInformation[questionNr - 1, 5];
                }
                
                else 
                {
                    timer10s.Stop();
                    prgBar10s.Value = 0;
                    tc.SelectedTab = tabMenu;
                    MessageBox.Show(rightAnswers + " / 10");
                }
                
            }
            else
            {
                questionNr++;

                if (questionNr < 11)
                {
                    rtbxQuestion.Text = scrambledInformation[questionNr - 1, 0];

                    btnAnsr1.Text = scrambledInformation[questionNr - 1, 2];
                    btnAnsr2.Text = scrambledInformation[questionNr - 1, 3];
                    btnAnsr3.Text = scrambledInformation[questionNr - 1, 4];
                    btnAnsr4.Text = scrambledInformation[questionNr - 1, 5];
                }
                else
                {
                    timer10s.Stop();
                    prgBar10s.Value = 0;
                    tc.SelectedTab = tabMenu;
                    MessageBox.Show(rightAnswers + " / 10");
                }
            }

            lblScore.Text = rightAnswers + " / 10";
        }

        private void btnAnsr2_Click(object sender, EventArgs e)
        {
            timer10s.Start();
            prgBar10s.Value = 0;
            if (btnAnsr2.Text == scrambledInformation[questionNr - 1, 1].ToString())
            {
                rightAnswers++;
                questionNr++;

                if (questionNr < 11)
                {
                    rtbxQuestion.Text = scrambledInformation[questionNr - 1, 0];

                    btnAnsr1.Text = scrambledInformation[questionNr - 1, 2];
                    btnAnsr2.Text = scrambledInformation[questionNr - 1, 3];
                    btnAnsr3.Text = scrambledInformation[questionNr - 1, 4];
                    btnAnsr4.Text = scrambledInformation[questionNr - 1, 5];
                }
                else
                {
                    timer10s.Stop();
                    prgBar10s.Value = 0;
                    tc.SelectedTab = tabMenu;
                    MessageBox.Show(rightAnswers + " / 10");
                }

            }
            else
            {
                questionNr++;

                if (questionNr < 11)
                {
                    rtbxQuestion.Text = scrambledInformation[questionNr - 1, 0];

                    btnAnsr1.Text = scrambledInformation[questionNr - 1, 2];
                    btnAnsr2.Text = scrambledInformation[questionNr - 1, 3];
                    btnAnsr3.Text = scrambledInformation[questionNr - 1, 4];
                    btnAnsr4.Text = scrambledInformation[questionNr - 1, 5];
                }
                else
                {
                    timer10s.Stop();
                    prgBar10s.Value = 0;
                    tc.SelectedTab = tabMenu;
                    MessageBox.Show(rightAnswers + " / 10");
                }
            }

            lblScore.Text = rightAnswers + " / 10";
        }

        private void btnAnsr3_Click(object sender, EventArgs e)
        {
            timer10s.Start();
            prgBar10s.Value = 0;
            if (btnAnsr3.Text == scrambledInformation[questionNr - 1, 1].ToString())
            {
                rightAnswers++;
                questionNr++;

                if (questionNr < 11)
                {
                    rtbxQuestion.Text = scrambledInformation[questionNr - 1, 0];

                    btnAnsr1.Text = scrambledInformation[questionNr - 1, 2];
                    btnAnsr2.Text = scrambledInformation[questionNr - 1, 3];
                    btnAnsr3.Text = scrambledInformation[questionNr - 1, 4];
                    btnAnsr4.Text = scrambledInformation[questionNr - 1, 5];
                }
                else
                {
                    timer10s.Stop();
                    prgBar10s.Value = 0;
                    tc.SelectedTab = tabMenu;
                    MessageBox.Show(rightAnswers + " / 10");
                }

            }
            else
            {
                questionNr++;

                if (questionNr < 11)
                {
                    rtbxQuestion.Text = scrambledInformation[questionNr - 1, 0];

                    btnAnsr1.Text = scrambledInformation[questionNr - 1, 2];
                    btnAnsr2.Text = scrambledInformation[questionNr - 1, 3];
                    btnAnsr3.Text = scrambledInformation[questionNr - 1, 4];
                    btnAnsr4.Text = scrambledInformation[questionNr - 1, 5];
                }
                else
                {
                    timer10s.Stop();
                    prgBar10s.Value = 0;
                    tc.SelectedTab = tabMenu;
                    MessageBox.Show(rightAnswers + " / 10");
                }
            }

            lblScore.Text = rightAnswers + " / 10";
        }

        private void btnAnsr4_Click(object sender, EventArgs e)
        {
            timer10s.Start();
            prgBar10s.Value = 0;
            if (btnAnsr4.Text == scrambledInformation[questionNr - 1, 1].ToString())
            {
                rightAnswers++;
                questionNr++;

                if (questionNr < 11)
                {
                    rtbxQuestion.Text = scrambledInformation[questionNr - 1, 0];

                    btnAnsr1.Text = scrambledInformation[questionNr - 1, 2];
                    btnAnsr2.Text = scrambledInformation[questionNr - 1, 3];
                    btnAnsr3.Text = scrambledInformation[questionNr - 1, 4];
                    btnAnsr4.Text = scrambledInformation[questionNr - 1, 5];
                }
                else
                {
                    timer10s.Stop();
                    prgBar10s.Value = 0;
                    tc.SelectedTab = tabMenu;
                    MessageBox.Show(rightAnswers + " / 10");
                }

            }
            else
            {
                questionNr++;

                if (questionNr < 11)
                {
                    rtbxQuestion.Text = scrambledInformation[questionNr - 1, 0];

                    btnAnsr1.Text = scrambledInformation[questionNr - 1, 2];
                    btnAnsr2.Text = scrambledInformation[questionNr - 1, 3];
                    btnAnsr3.Text = scrambledInformation[questionNr - 1, 4];
                    btnAnsr4.Text = scrambledInformation[questionNr - 1, 5];
                }
                else
                {
                    timer10s.Stop();
                    prgBar10s.Value = 0;
                    tc.SelectedTab = tabMenu;
                    MessageBox.Show(rightAnswers + " / 10");
                }
            }

            lblScore.Text = rightAnswers + " / 10";
        }
    }
}
