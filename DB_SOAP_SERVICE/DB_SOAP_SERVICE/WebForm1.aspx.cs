using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DB_SOAP_SERVICE
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private ServiceReferenceSOAPPRODUCT.ProdSoapSoapClient prodSoapSoapClient;
        

        protected void Page_Load(object sender, EventArgs e)
        {
            prodSoapSoapClient = new ServiceReferenceSOAPPRODUCT.ProdSoapSoapClient();
            GridView1.DataSource = prodSoapSoapClient.Get_Details();
            GridView1.DataBind();
            prodSoapSoapClient.Close();
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            prodSoapSoapClient = new ServiceReferenceSOAPPRODUCT.ProdSoapSoapClient();
            GridView2.DataSource = prodSoapSoapClient.Get_Product_name(TxtName.Text.Trim());
            GridView2.DataBind();
            prodSoapSoapClient.Close();
        }
    }
}