using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class Education
    {
        public int Id { get; set; }
        public int ResourceId { get; set; }
        public string Type { get; set; }
        public string Institute { get; set; }
        public string University { get; set; }
        public string PassingYear { get; set; }
        public string Percentage { get; set; }
        public string Grade { get; set; }
        public string Certificate { get; set; }
        public string MarkSheet { get; set; }
        public bool IsDeleted { get; set; }

    }
}
