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
    public partial class AddResourceSocial : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                string resourceId = Request.QueryString["resourceId"];
                txtResourceId.Text = resourceId;

            }
        }

        protected void btnAddResourceSocialAndContinue_OnClick(object sender, EventArgs e)
        {
            try
            {
                var resourceSocial = new Social()
                {
                    ResourceId = Convert.ToInt32(txtResourceId.Text),
                    Mobile = txtMobile.Text,
                    AltMobile = txtAltMobile.Text,
                    Email = txtEmail.Text,
                    WhatsApp = txtWhatsApp.Text,
                    Facebook = txtFacebook.Text,
                    Instagram = txtInstagram.Text,
                    Twitter = txtTwitter.Text,
                };

                var resourceBl = new ResourceBL();

                int result = resourceBl.SaveResourceSocial(resourceSocial);
                Response.Redirect(string.Format("~/Resources.aspx?resourceId={0}", result));

            }
            catch (Exception exception)
            {
                throw;
            }
        }

        protected void btnCancel_OnClick(object sender, EventArgs e)
        {
            Response.Redirect(string.Format("~/Resources.aspx"));
        }
    }
}