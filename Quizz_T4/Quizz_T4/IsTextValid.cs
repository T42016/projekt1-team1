using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quizz_T4
{
    class IsTextValid
    {
        static public void isTextvalid (Label l, string t)
        {
            if (t.Contains("|"))
            {
                l.Visible = true;
            }
            else
                l.Visible = false;

        }
    }
}
