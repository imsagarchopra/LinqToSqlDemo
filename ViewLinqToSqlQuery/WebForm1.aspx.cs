using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ViewLinqToSqlQuery
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void GetData()
        {
            #region Example1
            //Using the Log property of the DataContext object

            //using (SampleDataContext dbContext = new SampleDataContext())
            //{
            //    // Write the generated sql query to the webform
            //    dbContext.Log = Response.Output;

            //    // Write the generated sql query to the Console window
            //    // dbContext.Log = Console.Out;

            //    GridView1.DataSource = from employee in dbContext.Employees
            //                           select employee;
            //    GridView1.DataBind();
            //}
            #endregion Example1

            #region Example2
            //Using ToString() method

            //using (SampleDataContext dbContext = new SampleDataContext())
            //{
            //    var linqQuery = from employee in dbContext.Employees
            //                    select employee;

            //    string sqlQuery = linqQuery.ToString();
            //    Response.Write(sqlQuery);

            //    GridView1.DataSource = linqQuery;
            //    GridView1.DataBind();
            //}
            #endregion Example2

            #region Example3
            //Using GetCommand() method of DataContext object

            using (SampleDataContext dbContext = new SampleDataContext())
            {
                var linqQuery = from employee in dbContext.Employees
                                select employee;


                Response.Write(dbContext.GetCommand(linqQuery).CommandText);
                Response.Write("<br/>");
                Response.Write(dbContext.GetCommand(linqQuery).CommandType);

                GridView1.DataSource = linqQuery;
                GridView1.DataBind();
            }
            #endregion Example3

            #region Example4
            // We can also use SQL profiler to see the sql queries.
            #endregion Example4
        }

        protected void btnGetData_Click(object sender, EventArgs e)
        {
            GetData();
        }
    }
}