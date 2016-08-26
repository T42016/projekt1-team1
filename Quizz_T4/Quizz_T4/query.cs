using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizz_T4
{
    class Query
    {
        private string question;

        public Query(string question)
        {
            Question = question;
        }

        public string Question
        {
            get { return question; }
            set { question = value; }
        }

    }
}
