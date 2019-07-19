using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midori.Domain.Models
{
    // 1 news co nhieu tags
    public class ContentTag
    {
        [Key, Column(Order = 0)]
        public int ContentId { get; set; }
        [Key, Column(Order = 1)]
        public string TagId { get; set; }
    }
}
