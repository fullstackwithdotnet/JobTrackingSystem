using BusinessObject;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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
            if (!this.IsPostBack)
            {
                string resourceId = Request.QueryString["resourceId"];
                
                var resourceBl = new ResourceBL();
                var resource = resourceBl.GetResourcesById(Convert.ToInt32(resourceId));
                txtResourceId.Text = resourceId;
                txtFName.Text = resource.FirstName;
                txtLName.Text = resource.LastName;
                txtFatherName.Text = resource.FathersName;
                txtMotherName.Text = resource.MothersName;
                txtDOB.Text = Convert.ToDateTime(resource.DOB).ToString("yyyy-MM-dd");
                imagePhoto.ImageUrl = $"/Images/{resource.Photo}";
                drpGender.SelectedValue = resource.Gender;
               
            }
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
                Resource bo = new Resource();

                bo.Id = Convert.ToInt32(txtResourceId.Text);
                bo.FirstName = txtFName.Text;
                bo.LastName = txtLName.Text;
                bo.FathersName = txtFatherName.Text;
                bo.MothersName = txtMotherName.Text;
                bo.DOB = txtDOB.Text;
                bo.Gender = drpGender.SelectedItem.Value;

                string folderPath = Server.MapPath("/Images/");

                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                if (!photoUpload.HasFile)
                {
                    if (!string.IsNullOrEmpty(imagePhoto.ImageUrl))
                    {
                        bo.Photo = imagePhoto.ImageUrl;
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Please Enter Last Name')", true);
                    }
                }
                else
                {
                    photoUpload.SaveAs(folderPath + Path.GetFileName(photoUpload.FileName));
                    bo.Photo = photoUpload.FileName;
                }

                var resourceBl = new ResourceBL();
                int result = resourceBl.SaveResource(bo);

                Response.Redirect(string.Format("~/AddResourceAddress.aspx?resourceId={0}", result));


            }


        }

        public void btnPhotoUpload_OnClick(object sender, EventArgs e)
        {
            string folderPath = Server.MapPath("~/Images/");

            //Check whether Directory (Folder) exists.
            if (!Directory.Exists(folderPath))
            {
                //If Directory (Folder) does not exists Create it.
                Directory.CreateDirectory(folderPath);
            }

            //Save the File to the Directory (Folder).
            photoUpload.SaveAs(folderPath + Path.GetFileName(photoUpload.FileName));

            //Display the Picture in Image control.
            //imagePhoto.ImageUrl = "~/Images/" + Path.GetFileName(photoUpload.FileName);
        }

        protected void btnCancel_OnClick(object sender, EventArgs e)
        {
            Response.Redirect(string.Format("~/Resources.aspx"));
        }
    }
}