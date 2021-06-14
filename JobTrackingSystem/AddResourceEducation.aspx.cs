using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bussinesslogic;
using BusinessObject;

namespace JobTrackingSystem
{
    public partial class AddResourceEducation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                string resourceId = Request.QueryString["resourceId"];
                txtResourceId.Text = resourceId;

            }
        }

        protected void btnAddResourceEducationAndContinue_OnClick(object sender, EventArgs e)
        {
            try
            {
                var resourceEdu = new Education()
                {
                    ResourceId = Convert.ToInt32(txtResourceId.Text),
                    Type = txtType.Text,
                    Institute = txtInstitute.Text,
                    University = txtUniversity.Text,
                    PassingYear = txtPassingYear.Text,
                    Percentage = txtPercentage.Text,
                    Grade = txtGrade.Text,
                    Certificate = txtCertificate.Text,
                    MarkSheet = txtMarkSheet.Text
                };

                var resourceBl = new ResourceBL();

                int result = resourceBl.SaveResourceEducation(resourceEdu);
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Data saved successfully By Using 3 tier by :-sai')", true);

            }
            catch (Exception exception)
            {
                throw;
            }
        }
    }
}