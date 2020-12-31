using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UsingStoredProcedures
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void GetData()
        {
            SampleDataContext dbContext = new SampleDataContext();
            GridView1.DataSource = dbContext.GetEmployees();
            GridView1.DataBind();
        }

        protected void btnGetData_Click(object sender, EventArgs e)
        {
            GetData();
        }
    }
}