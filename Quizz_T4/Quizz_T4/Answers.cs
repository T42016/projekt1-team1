using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizz_T4
{
    class Answers
    {
        private string answer1;
        private string answer2;
        private string answer3;
        private string answer4;

        public Answers(string answer1, string answer2, string answer3, string answer4)
        {
            Answer1 = answer1;
            Answer2 = answer2;
            Answer3 = answer3;
            Answer4 = answer4;
        }

        public string Answer4
        {
            get { return answer4; }
            set { answer4 = value; }
        }


        public string Answer3
        {
            get { return answer3; }
            set { answer3 = value; }
        }


        public string Answer2
        {
            get { return answer2; }
            set { answer2 = value; }
        }


        public string Answer1
        {
            get { return answer1; }
            set { answer1 = value; }
        }

    }
}
