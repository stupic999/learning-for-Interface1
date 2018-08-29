using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface1
{
    class CTestcs : Ipass
    {
        private int score = 60;
        public int Score
        {
            get { return score; }
            set { score = value; }
        }

        private string passOK;

        public string PassOrNot(int grade)
        {
            if (grade >= score)
                passOK = "you are pass~ Well Done!";
            else
                passOK = "you are Fail!!!";
            return passOK;
        }


    }
}
