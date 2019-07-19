using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midori.Domain.Models
{
    // luu thong tin gioi thieu
    public class About
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string MetaTitle { get; set; }
        public string Description { get; set; }
        public string Detail { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        // Chi gia tri datetime ngay nao no xuong
        public bool Status { get; set; }
    }
}
