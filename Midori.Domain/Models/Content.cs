using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midori.Domain.Models
{
    // bang tin
    public class Content
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MetaTitle { get; set; }
        public int PublisherId { get; set; }
        public int AuthorId { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int CategoryId { get; set; }
        public string Detail { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        // Chi gia tri datetime ngay nao no xuong
        public DateTime TopHot { get; set; }
        public bool Status { get; set; }
        public string Tags { get; set; }
    }
}
