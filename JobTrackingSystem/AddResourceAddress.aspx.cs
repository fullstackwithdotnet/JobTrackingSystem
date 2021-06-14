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
    public partial class AddResourceAddress : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                string resourceId = Request.QueryString["resourceId"];
                txtResourceId.Text = resourceId;

            }
        }

        protected void btnAddResourceAddresAndContinue_OnClick(object sender, EventArgs e)
        {
            try
            {
                var resourceAddress = new Address()
                {
                    ResourceId = Convert.ToInt32(txtResourceId.Text),
                    AddressType = drpAddressType.SelectedItem.Value,
                    AddressLine1 = txtAdd1.Text,
                    AddressLine2 = txtAdd2.Text,
                    City = txtCity.Text,
                    State = txtState.Text,
                    Zip = txtZip.Text,
                    PinCode = txtPin.Text,
                    Country = txtCountry.Text

                };

                var resourceBl = new ResourceBL();

                int result = resourceBl.SaveResourceAddress(resourceAddress);
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Data saved successfully By Using 3 tier by :-sai')", true);
                Response.Redirect(string.Format("~/AddResourceEducation.aspx?resourceId={0}", txtResourceId.Text));
            }
            catch (Exception exception)
            {
                throw;
            }
        }

        protected void btnAddResourceAddresAndAddMore_OnClick(object sender, EventArgs e)
        {
            try
            {
                var resourceAddress = new Address()
                {
                    ResourceId = Convert.ToInt32(txtResourceId.Text),
                    AddressType = drpAddressType.SelectedItem.Value,
                    AddressLine1 = txtAdd1.Text,
                    AddressLine2 = txtAdd2.Text,
                    City = txtCity.Text,
                    State = txtState.Text,
                    Zip = txtZip.Text,
                    PinCode = txtPin.Text,
                    Country = txtCountry.Text

                };

                var resourceBl = new ResourceBL();

                int result = resourceBl.SaveResourceAddress(resourceAddress);
                Response.Redirect(string.Format("~/AddResourceAddress.aspx?resourceId={0}", result));

            }
            catch (Exception exception)
            {
                throw;
            }
        }
    }
}