using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PRINCIPLE
{
    public partial class Default : System.Web.UI.Page
    {
        private ServiceReferenceSimpleInterest.SimpleInterestSoapClient interestSoapClient;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            interestSoapClient = new ServiceReferenceSimpleInterest.SimpleInterestSoapClient(); 
            interestSoapClient.Open();
            
            float principle = (float) Convert.ToDouble(TextBox1.Text);
            float amount = (float) Convert.ToDouble(TextBox2.Text);
            int year = (int) Convert.ToDouble(TextBox1.Text);
            
            float simpleInterest = interestSoapClient.CalculateInterest(principle, amount, year);

            Label4.Text = $"{simpleInterest.ToString():0.0}";
   
            interestSoapClient.Close(); 
        }
    }
}