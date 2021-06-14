using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class Resource
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FathersName  { get; set; }
        public string MothersName  { get; set; }
        public string Gender { get; set; }
        public string DOB { get; set; }
        public string Photo { get; set; }
        public bool IsDeleted { get; set; }
        

    }
}
