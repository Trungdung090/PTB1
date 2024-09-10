using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using lib_PTB1;
using Newtonsoft.Json;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            {
                try
                {
                    string jsonString = new System.IO.StreamReader(Request.InputStream).ReadToEnd();

                    var data = JsonConvert.DeserializeObject<Dictionary<string, double>>(jsonString);

                    double a = data["hesoa"];
                    double b = data["hesob"];
                    lib_PTB1.Tinh tinh;
                    tinh = new lib_PTB1.Tinh();
                    tinh.a = a;
                    tinh.b = b;
                    double x = tinh.Tinhtoan();
                    Response.ContentType = "application/json";
                    Response.Write(JsonConvert.SerializeObject(x));
                }
                catch (Exception ex)
                {
                    Response.Write("Lỗi: " + ex.Message);
                }
            }
        }
    }
}