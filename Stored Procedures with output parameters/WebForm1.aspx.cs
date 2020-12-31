using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Stored_Procedures_with_output_parameters
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGetEmployeesByDepartment_Click(object sender, EventArgs e)
        {
            using (SampleDataContext dbContext = new SampleDataContext())
            {
                string deptName = string.Empty;
                GridView1.DataSource = dbContext.GetEmployeesByDepartment(1, ref deptName);
                GridView1.DataBind();

                lblDept.Text = "Department Name = " + deptName;
            }
        }
    }
}