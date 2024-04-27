using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace SOAP_SERVER
{
    /// <summary>
    /// Summary description for Calculator
    /// </summary>
    [WebService(Namespace = "http://xyz.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Calculator : System.Web.Services.WebService
    {

        [WebMethod]
        public int Add(int x,int y)
        {
            return Math.Abs(x) + Math.Abs(y);
        }

        [WebMethod]
        public int Sub(int x, int y)
        {
            return Math.Abs(x) - Math.Abs(y);
        }

        [WebMethod]
        public int Mul(int x, int y)
        {
            return Math.Abs(x) * Math.Abs(y);
        }

        [WebMethod]
        public int Div(int x, int y)
        {
            return Math.Abs(x) / Math.Abs(y);
        }
    }
}
