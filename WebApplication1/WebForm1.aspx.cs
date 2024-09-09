using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Tinh_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy giá trị a và b từ TextBox
                double a = Convert.ToDouble(txt_a.Text);
                double b = Convert.ToDouble(txt_b.Text);

                // Kiểm tra nếu a = 0
                if (a == 0)
                {
                    if (b == 0)
                    {
                        lbl_KQ.Text = "Phương trình có vô số nghiệm.";
                    }
                    else
                    {
                        lbl_KQ.Text = "Phương trình vô nghiệm.";
                    }
                }
                else
                {
                    double x = -b / a;
                    lbl_KQ.Text = "Nghiệm của phương trình = " + x.ToString();
                }
            }
            catch (Exception ex)
            {
                lbl_KQ.Text = "Lỗi: " + ex.Message;
            }
        }
    }
}