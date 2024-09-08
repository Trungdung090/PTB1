using System;
using System.Collections.Generic;
using System.Text;

namespace lib_PTB1
{
    public class Tinh
    {
        public double a, b;
        public double tinh_toan {  get; private set; }
        public string Tinhtoan()
        {
            if (a == 0)
            {
                if (b == 0)
                {
                    return "Phuong trinh vo so nghiem.";
                }
                else
                {
                    return "Phuong trinh vo nghiem.";
                }
            }
            else
            {
                double x = -b / a;
                return $"Nghiem cua phuong trinh la: x = {x}";
            }
        }
    }
}
