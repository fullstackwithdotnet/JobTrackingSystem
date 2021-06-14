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


                bo.FirstName = txtFName.Text;
                bo.LastName = txtLName.Text;
                bo.FathersName = txtFatherName.Text;
                bo.MothersName = txtMotherName.Text;
                bo.DOB = txtDOB.Text;
                bo.Gender = drpGender.SelectedItem.Value;

                string folderPath = Server.MapPath("~/Images/");

                //Check whether Directory (Folder) exists.
                if (!Directory.Exists(folderPath))
                {
                    //If Directory (Folder) does not exists Create it.
                    Directory.CreateDirectory(folderPath);
                }
                //Save the File to the Directory (Folder).
                photoUpload.SaveAs(folderPath + Path.GetFileName(photoUpload.FileName));
                ////Display the Picture in Image control.
                //imagePhoto.ImageUrl = "~/Images/" + Path.GetFileName(photoUpload.FileName);

                bo.Photo = photoUpload.FileName;

                var resourceBl = new ResourceBL();

                int result = resourceBl.SaveResource(bo);


                //ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Data saved successfully By Using 3 tier by :-sai')", true);
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
    }
}