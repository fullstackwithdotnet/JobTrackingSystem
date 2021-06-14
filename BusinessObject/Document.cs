using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class Document
    {
        public int Id { get; set; }
        public int ResourceId { get; set; }
        public string Type { get; set; }
        public string DocName { get; set; }
        public string Details { get; set; }
        public string DateOfUpload { get; set; }
        public bool IsDeleted { get; set; }
    }
}
