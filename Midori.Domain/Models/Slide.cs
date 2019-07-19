using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midori.Domain.Models
{
    public class Slide
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public int DisplayOrder { get; set; }
        public string Link { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public bool Status { get; set; }
    }
}
