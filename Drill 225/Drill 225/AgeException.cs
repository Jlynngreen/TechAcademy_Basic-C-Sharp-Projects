using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill_225
{
    public  class AgeException : Exception
    {
        public AgeException()
            : base(String.Format("please enter valid number")) { }

    }
}
