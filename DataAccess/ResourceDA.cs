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
        public int AddResource(ResourceBO resource)
        {
            try
            {

                var cmd = new SqlCommand("AddResource", con) { CommandType = CommandType.StoredProcedure };
                cmd.Parameters.AddWithValue("@FirstName", resource.FirstName);
                cmd.Parameters.AddWithValue("@LastName", resource.LastName);
                cmd.Parameters.AddWithValue("@FatherName", resource.FatherName);
                cmd.Parameters.AddWithValue("@DOB", resource.DOB);
                cmd.Parameters.AddWithValue("@AddressType", resource.AddressType);
                cmd.Parameters.AddWithValue("@AddressLine1", resource.AddressLine1);
                cmd.Parameters.AddWithValue("@AddressLine2", resource.AddressLine2);
                cmd.Parameters.AddWithValue("@City", resource.City);
                cmd.Parameters.AddWithValue("@Mobile", resource.Mobile);
                con.Open();
                var result = cmd.ExecuteNonQuery();
                cmd.Dispose();
                return result;
            }
            catch
            {
                throw;
            }
        }

        public List<ResourceBO> GetResource()
        {
            try
            {
                var resources = new List<ResourceBO>();
                var cmd = new SqlCommand("GetResources", con) { CommandType = CommandType.StoredProcedure };
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var resource = new ResourceBO()
                        {
                            FirstName = reader["FirstName"].ToString(),
                            LastName = reader["LastName"].ToString(),
                            FatherName = reader["FathersName"].ToString(),
                            DOB = reader["DOB"].ToString(),
                            AddressType = reader["AddressType"].ToString(),
                            AddressLine1 = reader["AddressLine1"].ToString(),
                            AddressLine2 = reader["AddressLine2"].ToString(),
                            City = reader["City"].ToString(),
                            Mobile = reader["MobileNo"].ToString(),
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
