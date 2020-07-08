using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class TwentyClassDealer : Dealer
    {   
        public List<card> Hand { get; set; }
        public bool stay { get; set; }
        public bool isBusted { get; set; }

    }
}
 