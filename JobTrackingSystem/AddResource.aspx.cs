using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bussinesslogic;

namespace JobTrackingSystem
{
    public partial class AddResource : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAddResource_OnClick(object sender, EventArgs e)
        {
            if (txtFName.Text == "")
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Please Enter First Name')", true);
            }
            else if (txtLName.Text == "")
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Please Enter Last Name')", true);
            }
            else
            {
                ResourceBO bo = new ResourceBO();


                bo.FirstName = txtFName.Text;
                bo.LastName = txtLName.Text;
                bo.FatherName = txtFatherName.Text;
                bo.DOB = DOB.Text;
                bo.AddressType = drpAddressType.SelectedItem.Text;
                bo.AddressLine1 = txtAddress1.Text;
                bo.AddressLine2 = txtAddress2.Text;
                bo.City = txtCity.Text;
                bo.Mobile = txtMobile.Text;

                var resourceBl = new ResourceBL();

                int result = resourceBl.SaveResource(bo);


                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Data saved successfully By Using 3 tier by :-sai')", true);


            }


        }
    }
}