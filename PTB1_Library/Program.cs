using System;
using System.Collections.Generic;
using System.Text;

namespace PTB1_Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, x;
            Console.Write("Nhap he so a: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Nhap he so b: ");
            b = double.Parse(Console.ReadLine());

            lib_PTB1.Tinh tinh;
            tinh = new lib_PTB1.Tinh();
            tinh.a = a; 
            tinh.b = b;
            tinh.Tinhtoan();
            double tinh_toan = tinh.tinh_toan;

            Console.WriteLine("Nghiem cua phuong trinh la: x = {x}");

        }
    }
}
