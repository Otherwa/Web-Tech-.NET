using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DisArch
{
    public partial class Default : System.Web.UI.Page
    {
        protected DataSet ds;
        protected void Page_Load(object sender, EventArgs e)
        {
            ds = new DataSet();
            ds.ReadXml(Server.MapPath("~/Books.xml"));
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
    }
}