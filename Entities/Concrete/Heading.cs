using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Heading
    {
        public Heading()
        {
            Contents = new List<Content>();
        }
        [Key]
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int WriterId { get; set; }

        [StringLength(100)]
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }


        public Category Category { get; set; }
        public Writer Writer { get; set; }
        public ICollection<Content> Contents { get; set; }
    }
}
