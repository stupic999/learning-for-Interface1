using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface1
{
    interface IGoodOrBad
    {
        int High { get; set; }
        int Low { get; set; }
        string GoodOrBad(int grade);
    }
}
