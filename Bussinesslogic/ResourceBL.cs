using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using DataAccess;

namespace Bussinesslogic
{
    public class ResourceBL
    {
        public int SaveResource(Resource resource) 
        {
            try
            {
                ResourceDA resourceService = new ResourceDA(); 
                return resourceService.AddResource(resource);
            }
            catch
            {
                throw;
            }
        }

        public List<Resource> GetResources()
        {
            ResourceDA resourceService = new ResourceDA();
            return resourceService.GetResource();
        }

        public List<Address> GetResourcesAddressesForResource(int id)
        {
            ResourceDA resourceService = new ResourceDA();
            return resourceService.GetResourcesAddressesForResource(id);
        }

        public Address GetResourcesAddressesById(int addressId, int resourceId)
        {
            ResourceDA resourceService = new ResourceDA();
            return resourceService.GetResourcesAddressesById(addressId, resourceId);
        }

        public Resource GetResourcesById(int resourceId)
        {
            var resourceService = new ResourceDA();
            return resourceService.GetResourcesById(resourceId);
        }

        public int SaveResourceAddress(Address resourceAddress)
        {
            var resourceService = new ResourceDA();
            return resourceService.AddResourceAddress(resourceAddress);
        }

        public int SaveResourceEducation(Education resourceEdu)
        {
            var resourceService = new ResourceDA();
            return resourceService.AddResourceEducation(resourceEdu);
        }

        public int SaveResourceSocial(Social resourceSocial)
        {
            var resourceService = new ResourceDA();
            return resourceService.AddResourceSocial(resourceSocial);
        }

        public int DeleteResource(int resourceId)
        {
            var resourceService = new ResourceDA();
            return resourceService.DeleteResource(resourceId);
        }

        public Education GetResourcesEducationById(int resourceId)
        {
            var resourceService = new ResourceDA();
            return resourceService.GetResourcesEducationById(resourceId);
        }
    }
}
