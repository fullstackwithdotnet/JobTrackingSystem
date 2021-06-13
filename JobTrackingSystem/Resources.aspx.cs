using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessObject;
using Bussinesslogic;

namespace JobTrackingSystem
{
    public partial class Resources : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsCallback)
            {
                var resourceBl = new ResourceBL();

                var resources = resourceBl.GetResources();
                resourcesTable.DataSource = resources;
                resourcesTable.DataBind();
            }
        }
    }
}