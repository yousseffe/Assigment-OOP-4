using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment_OOP_4.Interface
{
    internal interface ISeries
    {
        // 1. signture for property

        public int Current { get; set; }

        // 2. signture for method

        public void getNext();

        public void Reset()
        {
            Current = 0;
        }
    }
}
