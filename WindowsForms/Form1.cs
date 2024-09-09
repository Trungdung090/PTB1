using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b;
            a = double.Parse(tbx_a.Text);
            b = double.Parse(tbx_b.Text);
                
            lib_PTB1.Tinh tinh;
            tinh = new lib_PTB1.Tinh();
            tinh.a = a;
            tinh.b = b;

            lbl_KQ.Text = $"Nghiem cua phuong trinh = {tinh.Tinhtoan()}";
        }
    }
}
