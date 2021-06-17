using Bussinesslogic;
using System;
using System.Web.UI.WebControls;

namespace JobTrackingSystem
{
    public partial class Resources : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsCallback) return;
            var resourceBl = new ResourceBL();

            var resources = resourceBl.GetResources();
            resourcesTable.DataSource = resources;
            resourcesTable.DataBind();
        }


       
        protected void linkDelete_OnCommand(object sender, CommandEventArgs e)
        {
            var resourceBl = new ResourceBL();
            var result = resourceBl.DeleteResource(Convert.ToInt32(e.CommandArgument));
            Response.Redirect(string.Format("~/Resources.aspx"));

        }
    }
}