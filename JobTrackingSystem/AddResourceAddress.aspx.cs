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
            var resourceBl = new ResourceBL();

            if (!this.IsPostBack)
            {
                string resourceId = Request.QueryString["resourceId"];
                string addressId = Request.QueryString["addressId"];
                txtResourceId.Text = resourceId;
                var resourceAddressList = resourceBl.GetResourcesAddressesForResource(Convert.ToInt32(resourceId));

                if (!string.IsNullOrEmpty(addressId))
                {
                    var address = resourceBl.GetResourcesAddressesById(Convert.ToInt32(addressId), Convert.ToInt32(resourceId));
                    txtAddressId.Text = addressId;
                    drpAddressType.SelectedValue = address.AddressType;
                    txtAdd1.Text = address.AddressLine1;
                    txtAdd2.Text = address.AddressLine1;
                    txtCity.Text = address.City;
                    txtPin.Text = address.PinCode;
                    txtCountry.Text = address.Country;
                    txtState.Text = address.State;
                }
                else if (resourceAddressList != null && resourceAddressList.Count == 1)
                {
                    var address = resourceBl.GetResourcesAddressesById(Convert.ToInt32(resourceAddressList[0].Id), Convert.ToInt32(resourceId));
                    txtAddressId.Text = address.Id.ToString();
                    txtResourceId.Text = address.ResourceId.ToString();
                    drpAddressType.SelectedValue = address.AddressType;
                    txtAdd1.Text = address.AddressLine1;
                    txtAdd2.Text = address.AddressLine1;
                    txtCity.Text = address.City;
                    txtPin.Text = address.PinCode;
                    txtCountry.Text = address.Country;
                    txtState.Text = address.State;
                }
                
                else if (resourceAddressList != null && resourceAddressList.Count > 1)
                {
                    Response.Redirect(string.Format("~/ResourceAddressList.aspx?resourceId={0}", txtResourceId.Text));
                }

            }
        }

        protected void btnAddResourceAddresAndContinue_OnClick(object sender, EventArgs e)
        {
            try
            {
                var resourceAddress = new Address()
                {
                    Id = string.IsNullOrEmpty(txtAddressId.Text) ? 0 : Convert.ToInt32(txtAddressId.Text),
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
                //ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Data saved successfully By Using 3 tier by :-sai')", true);
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

        protected void btnCancel_OnClick(object sender, EventArgs e)
        {
            Response.Redirect(string.Format("~/Resources.aspx"));

        }
    }
}