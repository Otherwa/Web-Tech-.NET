using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AJAX
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        List<String> quotes = new List<String>();
        Random random;

        protected void Page_Load(object sender, EventArgs e)
        {
            random = new Random();
            quotes.Add("W");
            quotes.Add("F");
            quotes.Add("LOL");
            quotes.Add("KYS");

            Label2.Text = quotes[random.Next(0, quotes.Count)]; 
        }

        protected void Tick(object sender, EventArgs e)
        {

            Label2.Text = $"Quote : {quotes[random.Next(0, quotes.Count)]}";
            
        }

        protected void Timer2_Tick(object sender, EventArgs e)
        {
            Label3.Text = DateTime.Now.ToString();
        }
    }
}