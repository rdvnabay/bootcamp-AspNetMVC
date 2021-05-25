using Core.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class Content:IEntity
    {
        [Key]
        public int Id { get; set; }
        public int HeadingId { get; set; }
        public int? WriterId { get; set; }

      
        public DateTime CreatedDate { get; set; }
        public bool Status { get; set; }

        [StringLength(100)]
        public string Value { get; set; }

        public Heading Heading { get; set; }
        public Writer Writer { get; set; }
    }
}
