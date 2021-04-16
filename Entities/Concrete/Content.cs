using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Content
    {
        [Key]
        public int Id { get; set; }
        public int HeadingId { get; set; }
        public int? WriterId { get; set; }

        [StringLength(100)]
        public string Value { get; set; }
        public DateTime CreatedDate { get; set; }

   
        public Heading Heading { get; set; }
        public Writer Writer { get; set; }
    }
}
