using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment_OOP_4.Interface
{
    internal class SeriesByTwo : ISeries
    {
        public int Current { get; set; }
        public void getNext()
        {
            Current += 2;
        }
        
    }
}
