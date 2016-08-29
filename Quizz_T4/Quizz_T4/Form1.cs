﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Quizz_T4
{
    public partial class Form1 : Form
    {
        static int iteration = 1;



        List<Query> questions = new List<Query>();
        List<Answers> answers = new List<Answers>();



        public Form1()
        {
            InitializeComponent();

        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            timer30s.Start();
            tc.SelectedTab = tabQuiz;
            string[,] information = new string[10, 5];
            string[,] scrambledInformation = new string[10, 6];
            string[] theAnswers = new string[4];

            for (int a = 0; a < 10; a++)
            {
                information[a, 0] = questions[a].ToString();

                theAnswers[1] = answers[a].Answer1;
                theAnswers[2] = answers[a].Answer2;
                theAnswers[3] = answers[a].Answer3;
                theAnswers[4] = answers[a].Answer4;

                for (int b = 1; b < 6; b++)
                {
                    information[a, b] = theAnswers[b];
                }

            }

            scrambledInformation = Shuffler.Shuffle(information);
            for (int x = 0; x < 10; x++)
            {
                rtbxQuestion.Text = scrambledInformation[x, 0];

                btnAnsr1.Text = scrambledInformation[x, 2];
                btnAnsr2.Text = scrambledInformation[x, 3];
                btnAnsr3.Text = scrambledInformation[x, 4];
                btnAnsr4.Text = scrambledInformation[x, 5];

            }
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


            string questionfile = tbxQuizzName.Text + "_question" + ".quizz";
            string answerfile = tbxQuizzName.Text + "_answer" + ".quizz";

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

        private void timer30s_Tick(object sender, EventArgs e)
        {
            prgBar30s.Maximum = 30;
            if (prgBar30s.Value < 30)
            {
                prgBar30s.Value++;
            }
            else
            {
                timer30s.Stop();
                MessageBox.Show("Time's Up");
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
            IsTextValid.isTextvalid(lblError2, tbxQuizzName.Text);
        }

        private void tbxAnswer1_TextChanged(object sender, EventArgs e)
        {
            IsTextValid.isTextvalid(lblError3, tbxQuizzName.Text);
        }

        private void tbxAnswer2_TextChanged(object sender, EventArgs e)
        {
            IsTextValid.isTextvalid(lblError4, tbxQuizzName.Text);
        }

        private void tbxAnswer3_TextChanged(object sender, EventArgs e)
        {
            IsTextValid.isTextvalid(lblError5, tbxQuizzName.Text);
        }

        private void tbxAnswer4_TextChanged(object sender, EventArgs e)
        {
            IsTextValid.isTextvalid(lblError6, tbxQuizzName.Text);
        }
    }
}
