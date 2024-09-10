using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using System.Text;

//Họ và tên: Đặng Trung Dũng
//Bắt đầu làm bài tập: Giải Phương Trình Bậc 1
namespace PTB1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap he so a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Nhap he so b: ");
            double b = double.Parse(Console.ReadLine());
            if (a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine("Phuong trinh vo so ngiem.");
                }
                else
                {
                    Console.WriteLine("Phuong trinh vo nghiem.");
                }
            }
            else
            {
                double x = -b / a;
                Console.WriteLine("Nghiem cua phuong trinh x = " + x);
            }
            Console.ReadLine();
        }
    }
}
