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
    }
}
