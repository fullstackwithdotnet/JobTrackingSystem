using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bussinesslogic;

namespace JobTrackingSystem
{
    public partial class ResourceAddressList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                string resourceId = Request.QueryString["resourceId"];
                var resourceBl = new ResourceBL();
                var resourceAddressList = resourceBl.GetResourcesAddressesForResource(Convert.ToInt32(resourceId));
                resourcesAddresses.DataSource = resourceAddressList;
                resourcesAddresses.DataBind();
            }
        }

        protected void btnCancel_OnClick(object sender, EventArgs e)
        {
            Response.Redirect(string.Format("~/Resources.aspx"));
        }

    }
}