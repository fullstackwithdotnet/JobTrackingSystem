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
        public int SaveResource(ResourceBO resource) 
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

        public List<ResourceBO> GetResources()
        {
            ResourceDA resourceService = new ResourceDA();
            return resourceService.GetResource();
        }
    }
}
