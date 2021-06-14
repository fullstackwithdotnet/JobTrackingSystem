using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class ReslCard
    {
        public int Id { get; set; }
        public int ResourceId { get; set; }
        public string Adhaar { get; set; }
        public string PAN { get; set; }
        public string Voter { get; set; }
        public string Ration { get; set; }
        public string Passport { get; set; }
        public bool IsDeleted { get; set; }

    }
}
