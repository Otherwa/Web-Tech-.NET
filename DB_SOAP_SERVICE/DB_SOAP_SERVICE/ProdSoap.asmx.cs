using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace DB_SOAP_SERVICE
{
    /// <summary>
    /// Summary description for ProdSoap
    /// </summary>
    [WebService(Namespace = "http://products.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ProdSoap : System.Web.Services.WebService
    {
       protected SqlConnection _connection;
       protected SqlDataAdapter _adapter;
       protected SqlCommand _command;
       

        public ProdSoap()
        {
            _connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exam\Desktop\09_Atharv_Web\MYDB.mdf;Integrated Security=True;Connect Timeout=30");
        }

        [WebMethod]
        public DataSet Get_Details()
        {
            _connection.Open();
            _command = new SqlCommand("Select * from dbo.Prodcut",_connection);
            _adapter = new SqlDataAdapter(_command);

            DataSet ds = new DataSet();
            _adapter.Fill(ds);
            _connection.Close();
            return ds;
        }

        [WebMethod]
        public DataSet Get_Product_name(String s) {
            _connection.Open();
            _command = new SqlCommand($"Select * from dbo.Prodcut where ProdName = '{s}'", _connection);
            _adapter = new SqlDataAdapter(_command);

            DataSet ds = new DataSet();
            _adapter.Fill(ds);
            _connection.Close();
            return ds;
        }
    }
}
