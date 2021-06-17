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

                var cmd = new SqlCommand("ResourceCRUD", con) { CommandType = CommandType.StoredProcedure };
                cmd.Parameters.AddWithValue("@Operation", "CREATE");
                cmd.Parameters.AddWithValue("@ResourceId", resource.Id);
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

        public Resource GetResourcesById(int resourceId)
        {
            try
            {
                var resources = new List<Resource>();
                var cmd = new SqlCommand("ResourceCRUD", con) { CommandType = CommandType.StoredProcedure };
                cmd.Parameters.AddWithValue("@Operation", "RETRIEVE");
                cmd.Parameters.AddWithValue("@ResourceId", resourceId);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                var resource = new Resource()
                {
                    Id = Convert.ToInt32(reader["Resource_ID"]),
                    FirstName = reader["First_Name"].ToString(),
                    LastName = reader["Last_Name"].ToString(),
                    FathersName = reader["Father_Name"].ToString(),
                    MothersName = reader["Mother_Name"].ToString(),
                    Gender = reader["Gender"].ToString(),
                    DOB = reader["Date_Birth"].ToString(),
                    Photo = reader["Photo"].ToString()
                };

                reader.Close();
                cmd.Dispose();
                return resource;
            }
            catch
            {
                throw;
            }
        }

        public int DeleteResource(int resourceId)
        {
            try
            {

                var cmd = new SqlCommand("ResourceCRUD", con) { CommandType = CommandType.StoredProcedure };
                cmd.Parameters.AddWithValue("@Operation", "DELETE");
                cmd.Parameters.AddWithValue("@ResourceId", resourceId);
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

        public int AddResourceSocial(Social resource)
        {
            try
            {
                var cmd = new SqlCommand("ResourceSocialCRUD", con) { CommandType = CommandType.StoredProcedure };
                cmd.Parameters.AddWithValue("@Operation", "CREATE");
                cmd.Parameters.AddWithValue("@ResourceId", resource.ResourceId);
                cmd.Parameters.AddWithValue("@Mobile", resource.Mobile);
                cmd.Parameters.AddWithValue("@AltMobile", resource.AltMobile);
                cmd.Parameters.AddWithValue("@Email", resource.Email);
                cmd.Parameters.AddWithValue("@WhatsApp", resource.WhatsApp);
                cmd.Parameters.AddWithValue("@Facebook", resource.Facebook);
                cmd.Parameters.AddWithValue("@Instagram", resource.Instagram);
                cmd.Parameters.AddWithValue("@Twitter", resource.Twitter);
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
                var cmd = new SqlCommand("ResourceEducationCRUD", con) { CommandType = CommandType.StoredProcedure };
                cmd.Parameters.AddWithValue("@Operation", "CREATE");
                cmd.Parameters.AddWithValue("@EducationId", resource.Id);
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

                var cmd = new SqlCommand("ResourceAddressCRUD", con) { CommandType = CommandType.StoredProcedure };
                cmd.Parameters.AddWithValue("@Operation", "CREATE");
                cmd.Parameters.AddWithValue("@AddressId", resourceAddress.Id);
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
                var cmd = new SqlCommand("ResourceCRUD", con) { CommandType = CommandType.StoredProcedure };
                cmd.Parameters.AddWithValue("@Operation", "RETRIEVE");
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var resource = new Resource()
                        {
                            Id = Convert.ToInt32(reader["Resource_ID"].ToString()),
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

        public List<Address> GetResourcesAddressesForResource(int id)
        {
            try
            {
                var resources = new List<Address>();
                var cmd = new SqlCommand("ResourceAddressCRUD", con) { CommandType = CommandType.StoredProcedure };
                cmd.Parameters.AddWithValue("@Operation", "RETRIEVE");
                cmd.Parameters.AddWithValue("@ResourceId", id);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var resource = new Address()
                        {
                            Id = Convert.ToInt32(reader["Address_ID"].ToString()),
                            ResourceId = Convert.ToInt32(reader["Resource_ID"].ToString()),
                            AddressType = reader["Address_Type"].ToString(),
                            AddressLine1 = reader["AddressLine1"].ToString(),
                            AddressLine2 = reader["AddressLine2"].ToString(),
                            City = reader["City"].ToString(),
                            State = reader["State"].ToString(),
                            PinCode = reader["PinCode"].ToString(),
                            Country = reader["Country"].ToString()
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

        public Address GetResourcesAddressesById(int addressId, int resourceId)
        {
            try
            {
                var cmd = new SqlCommand("ResourceAddressCRUD", con) { CommandType = CommandType.StoredProcedure };
                cmd.Parameters.AddWithValue("@Operation", "RETRIEVE");
                cmd.Parameters.AddWithValue("@AddressId", addressId);
                cmd.Parameters.AddWithValue("@ResourceId", resourceId);
                con.Open();
                var reader = cmd.ExecuteReader();
                reader.Read();

                var resource = new Address()
                {
                    Id = Convert.ToInt32(reader["Address_ID"].ToString()),
                    ResourceId = Convert.ToInt32(reader["Resource_ID"].ToString()),
                    AddressType = reader["Address_Type"].ToString(),
                    AddressLine1 = reader["AddressLine1"].ToString(),
                    AddressLine2 = reader["AddressLine2"].ToString(),
                    City = reader["City"].ToString(),
                    State = reader["State"].ToString(),
                    PinCode = reader["PinCode"].ToString(),
                    Country = reader["Country"].ToString()
                };

                reader.Close();
                cmd.Dispose();
                return resource;
            }
            catch
            {
                throw;
            }
        }

        public Education GetResourcesEducationById(int resourceId)
        {
            try
            {
                var cmd = new SqlCommand("ResourceEducationCRUD", con) { CommandType = CommandType.StoredProcedure };
                cmd.Parameters.AddWithValue("@Operation", "RETRIEVE");
                //cmd.Parameters.AddWithValue("@EducationId", addressId);
                cmd.Parameters.AddWithValue("@ResourceId", resourceId);
                con.Open();
                var reader = cmd.ExecuteReader();
                
                if (reader.Read())
                {

                    var resource = new Education()
                    {
                        Id = Convert.ToInt32(reader["Education_ID"].ToString()),
                        ResourceId = Convert.ToInt32(reader["Resource_ID"].ToString()),
                        Type = reader["Type"].ToString(),
                        Institute = reader["Institute"].ToString(),
                        University = reader["University"].ToString(),
                        PassingYear = reader["PassingYear"].ToString(),
                        Percentage = reader["Percentage"].ToString(),
                        Grade = reader["Grade"].ToString(),
                        Certificate = reader["Certificate"].ToString(),
                        MarkSheet = reader["Marksheet"].ToString()
                    };

                    reader.Close();
                    cmd.Dispose();
                    return resource;
                }
                else
                {
                    return new Education()
                    {
                        ResourceId = resourceId
                    };
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
