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

                var resourceBl = new ResourceBL();
                var education = resourceBl.GetResourcesEducationById(Convert.ToInt32(resourceId));
                txtResourceId.Text = resourceId;
                txtEducationId.Text = education.Id.ToString();
                txtType.Text = education.Type;
                txtInstitute.Text = education.Institute;
                txtUniversity.Text = education.University;
                txtPassingYear.Text = education.PassingYear;
                txtPercentage.Text = education.Percentage;
                txtGrade.Text = education.Grade;

            }
        }

        protected void btnAddResourceEducationAndContinue_OnClick(object sender, EventArgs e)
        {
            try
            {
                var resourceEdu = new Education()
                {
                    Id = Convert.ToInt32(txtEducationId.Text),
                    ResourceId = Convert.ToInt32(txtResourceId.Text),
                    Type = txtType.Text,
                    Institute = txtInstitute.Text,
                    University = txtUniversity.Text,
                    PassingYear = txtPassingYear.Text,
                    Percentage = txtPercentage.Text,
                    Grade = txtGrade.Text,
                    Certificate = updlCertificate.FileName,
                    MarkSheet = upldMarkSheet.FileName
                };

                var resourceBl = new ResourceBL();

                int result = resourceBl.SaveResourceEducation(resourceEdu);
                //ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Data saved successfully By Using 3 tier by :-sai')", true);
                Response.Redirect(string.Format("~/AddResourceSocial.aspx?resourceId={0}", txtResourceId.Text));

            }
            catch (Exception exception)
            {
                throw;
            }
        }

        protected void btnAddResourceEducationAndAddMore_OnClick(object sender, EventArgs e)
        {
            try
            {
                var resourceEdu = new Education()
                {
                    Id = Convert.ToInt32(txtEducationId.Text),
                    ResourceId = Convert.ToInt32(txtResourceId.Text),
                    Type = txtType.Text,
                    Institute = txtInstitute.Text,
                    University = txtUniversity.Text,
                    PassingYear = txtPassingYear.Text,
                    Percentage = txtPercentage.Text,
                    Grade = txtGrade.Text,
                    Certificate = updlCertificate.FileName,
                    MarkSheet = upldMarkSheet.FileName
                };

                var resourceBl = new ResourceBL();

                int result = resourceBl.SaveResourceEducation(resourceEdu);
                //ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Data saved successfully By Using 3 tier by :-sai')", true);
                Response.Redirect(string.Format("~/AddResourceEducation.aspx?resourceId={0}", txtResourceId.Text));


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