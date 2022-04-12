using System;
using System.Collections.Generic;
using System.Text;

namespace TaskClass.Models
{
    class Milk:Product
    {
        public int Volume;
        public int FatRate;
        public Milk(string test) :base(test)
        {
            
        }
    }
}
