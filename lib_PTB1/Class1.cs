using System;
using System.Collections.Generic;
using System.Text;

namespace lib_PTB1
{
    public class Tinh
    {
        public double a, b;
        public double x {  get; private set; }
        public double Tinhtoan()
        {            
            double x = -b / a;
            return x;         
        }
    }
}
