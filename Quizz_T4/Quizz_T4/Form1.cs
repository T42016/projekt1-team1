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

namespace Quizz_T4
{
    public partial class Form1 : Form
    {
        static int iteration = 1;
        string filename = "quizz" + iteration;
        

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
            string[,] information = new string[10, 6];
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

                    questions.Add(new Query(rtbnQuestion.Text));
                    answers.Add(new Answers(tbxAnswer1.Text, tbxAnswer2.Text, tbxAnswer3.Text, tbxAnswer4.Text));
                    Save();
                    iteration++;

        }

        private void Save()
        {
            string questionlist = "";
            string answerlist = "";
            foreach (Query item in questions)
            {
                questionlist += item.Question + "\r\n"; //Här spara jag den nya boken.
            }

            foreach (Answers item in answers)
            {
                answerlist += item.Answer1 + "|" + item.Answer2 + "|" + item.Answer3 + "|" + item.Answer4 + "\r\n"; //Här spara jag den nya boken.
            }

            File.WriteAllText(@"question.txt", questionlist);
            File.WriteAllText(@"answers.txt", answerlist);

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

        
    }
}
