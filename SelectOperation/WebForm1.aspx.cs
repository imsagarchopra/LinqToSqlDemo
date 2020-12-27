using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Linq;

namespace SelectOperation
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SampleDataContext dbContext = new SampleDataContext();
            GridView1.DataSource = from employee in dbContext.Employees
                                   where employee.Gender == "Male"
                                   orderby employee.Salary descending
                                   select employee;
            GridView1.DataBind();
        }
    }
}