using System;
using System.Collections.Generic;
using System.Text;


namespace PTB1_Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            Console.Write("Nhap he so a: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Nhap he so b: ");
            b = double.Parse(Console.ReadLine());

            lib_PTB1.Tinh tinh;
            tinh = new lib_PTB1.Tinh();
            tinh.a = a; 
            tinh.b = b;
            double x = tinh.Tinhtoan();

            Console.WriteLine("Nghiem cua phuong trinh x = " + x);
        }
    }
}
