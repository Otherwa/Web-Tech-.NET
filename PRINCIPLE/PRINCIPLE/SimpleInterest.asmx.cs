using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace PRINCIPLE
{
    /// <summary>
    /// Summary description for SimpleInterest
    /// </summary>
    [WebService(Namespace = "http://simpleinterest.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.
    // [System.Web.Script.Services.ScriptService]
    public class SimpleInterest : System.Web.Services.WebService
    {
        [WebMethod]
        public float CalculateInterest(float principle, float amount, int time)
        {
            float interest = (principle * amount * time) / 100;
            return interest;
        }
    }
}
