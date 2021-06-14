using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class Social
    {
        public int Id { get; set; }
        public int ResourceId { get; set; }
        public string Mobile { get; set; }
        public string AltMobile { get; set; }
        public string Email { get; set; }
        public string WhatsApp { get; set; }
        public string Facebook { get; set; }
        public string Instagram { get; set; }
        public string Twitter { get; set; }
        public bool IsDeleted { get; set; }
    }
}
