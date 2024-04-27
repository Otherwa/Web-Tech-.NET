using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SOAP_SERVER
{
    public partial class Calculator_Consume : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            CalService.CalculatorSoapClient client = new CalService.CalculatorSoapClient();
            int res = client.Add((int)Convert.ToInt64((TextBox1.Text)), (int)Convert.ToInt64((TextBox2.Text)));
            Label1.Text = "Addition" + res.ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            CalService.CalculatorSoapClient client = new CalService.CalculatorSoapClient();
            int res = client.Sub((int)Convert.ToInt64((TextBox1.Text)), (int)Convert.ToInt64((TextBox2.Text)));
            Label1.Text = "Substraction " + res.ToString();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            CalService.CalculatorSoapClient client = new CalService.CalculatorSoapClient();
            int res = client.Mul((int)Convert.ToInt64((TextBox1.Text)), (int)Convert.ToInt64((TextBox2.Text)));
            Label1.Text = "Multiplication" + res.ToString();
        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            CalService.CalculatorSoapClient client = new CalService.CalculatorSoapClient();
            int res = client.Div((int)Convert.ToInt64((TextBox1.Text)), (int)Convert.ToInt64((TextBox2.Text)));
            Label1.Text = "Division" + res.ToString();
        }
    }
}