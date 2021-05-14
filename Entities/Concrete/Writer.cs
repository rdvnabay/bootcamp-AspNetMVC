using Core.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class Writer:IEntity
    {
        public Writer()
        {
            Contents = new List<Content>();
            Headings = new List<Heading>();
        }
        [Key]
        public int Id { get; set; }

        [StringLength(20)]
        public string FirstName { get; set; }


        [StringLength(20)]
        public string LastName { get; set; }


        [StringLength(100)]
        public string Email { get; set; }


        [StringLength(200)]
        public string Image { get; set; }

        [StringLength(100)]
        public string About { get; set; }


        [StringLength(20)]
        public string Password { get; set; }

        public ICollection<Heading> Headings { get; set; }
        public ICollection<Content> Contents { get; set; }
    }
}
