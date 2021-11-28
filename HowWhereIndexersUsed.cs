using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HowWhereIndexersUsed
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["Session1"] = "Session 1 Data";
            Session["Session2"] = "Session 2 Data";

            Response.Write("Session 1 Data = " + Session[0].ToString());
            Response.Write("<br/>");
            Response.Write("Session 2 Data = " + Session["Session2"].ToString());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lesson64_HowWhereIndexersUsed
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("Select * from tblEmployee", con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Response.Write("Id = " + rdr[0].ToString() + " ");
                    Response.Write("LastName = " + rdr["LastName"].ToString());
                    Response.Write("<br/>");
                }
            }
        }
    }
}
