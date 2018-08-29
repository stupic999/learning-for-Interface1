using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface1
{
    class CTestcs : Ipass,IGoodOrBad
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

        private string goodOrBad;
        private int high = 80;
        public int High
        {
            get { return high; }
            set { high = value; }
        }
        private int low = 50;
        public int Low
        {
            get { return low; }
            set { low = value; }
        }

        public string GoodOrBad(int grade)
        {
            if (grade >= High)
            {
                goodOrBad = "You are very good!";
            }
            else if (grade < Low)
            {
                goodOrBad = "You are so lousy...";
            }
            else
            {
                goodOrBad = "You are nice.";
            }
            return goodOrBad;
        }
    }
}
