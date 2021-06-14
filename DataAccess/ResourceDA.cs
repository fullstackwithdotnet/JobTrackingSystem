using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccess
{
    public class ResourceDA
    {
        readonly SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["JMS"].ToString());
        public int AddResource(Resource resource)
        {
            try
            {

                var cmd = new SqlCommand("AddResource", con) { CommandType = CommandType.StoredProcedure };
                cmd.Parameters.AddWithValue("@FirstName", resource.FirstName);
                cmd.Parameters.AddWithValue("@LastName", resource.LastName);
                cmd.Parameters.AddWithValue("@FatherName", resource.FathersName);
                cmd.Parameters.AddWithValue("@MotherName", resource.MothersName);
                cmd.Parameters.AddWithValue("@DOB", resource.DOB);
                cmd.Parameters.AddWithValue("@Gender", resource.Gender);
                cmd.Parameters.AddWithValue("@Photo", resource.Photo);
                con.Open();
                var result = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose();
                return result;
            }
            catch
            {
                throw;
            }
        }

        public int AddResourceEducation(Education resource)
        {
            try
            {
                var cmd = new SqlCommand("AddResourceEducation", con) { CommandType = CommandType.StoredProcedure };
                cmd.Parameters.AddWithValue("@ResourceId", resource.ResourceId);
                cmd.Parameters.AddWithValue("@Type", resource.Type);
                cmd.Parameters.AddWithValue("@Institute", resource.Institute);
                cmd.Parameters.AddWithValue("@University", resource.University);
                cmd.Parameters.AddWithValue("@PassingYear", resource.PassingYear);
                cmd.Parameters.AddWithValue("@Percentage", resource.Percentage);
                cmd.Parameters.AddWithValue("@Grade", resource.Grade);
                cmd.Parameters.AddWithValue("@Certificate", resource.Certificate);
                cmd.Parameters.AddWithValue("@MarkSheet", resource.MarkSheet);
                con.Open();
                var result = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose();
                return result;
            }
            catch
            {
                throw;
            }
        }

        public int AddResourceAddress(Address resourceAddress)
        {
            try
            {

                var cmd = new SqlCommand("AddResourceAddress", con) { CommandType = CommandType.StoredProcedure };
                cmd.Parameters.AddWithValue("@ResourceId", resourceAddress.ResourceId);
                cmd.Parameters.AddWithValue("@AddressType", resourceAddress.AddressType);
                cmd.Parameters.AddWithValue("@AddressLine1", resourceAddress.AddressLine1);
                cmd.Parameters.AddWithValue("@AddressLine2", resourceAddress.AddressLine2);
                cmd.Parameters.AddWithValue("@City", resourceAddress.City);
                cmd.Parameters.AddWithValue("@State", resourceAddress.State);
                cmd.Parameters.AddWithValue("@PinCode", resourceAddress.PinCode);
                cmd.Parameters.AddWithValue("@Country", resourceAddress.Country);
                con.Open();
                var result = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose();
                return result;
            }
            catch
            {
                throw;
            }
        }

        public List<Resource> GetResource()
        {
            try
            {
                var resources = new List<Resource>();
                var cmd = new SqlCommand("GetResources", con) { CommandType = CommandType.StoredProcedure };
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var resource = new Resource()
                        {
                            FirstName = reader["First_Name"].ToString(),
                            LastName = reader["Last_Name"].ToString(),
                            FathersName = reader["Father_Name"].ToString(),
                            MothersName = reader["Mother_Name"].ToString(),
                            Gender = reader["Gender"].ToString(),
                            DOB = reader["Date_Birth"].ToString(),
                            Photo = reader["Photo"].ToString()
                        };
                        resources.Add(resource);
                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }
                reader.Close();
                cmd.Dispose();
                return resources;
            }
            catch
            {
                throw;
            }
        }
    }
}
