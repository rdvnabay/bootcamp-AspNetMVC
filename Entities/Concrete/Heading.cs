using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class Heading:IEntity
    {
        public Heading()
        {
            Contents = new List<Content>();
        }
        [Key]
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int WriterId { get; set; }


        public DateTime CreatedDate { get; set; }

        [StringLength(100)]
        public string Name { get; set; }
        public bool Status { get; set; }
     


        public Category Category { get; set; }
        public Writer Writer { get; set; }
        public ICollection<Content> Contents { get; set; }
    }
}
