using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class About:IEntity
    {
        [Key]
        public int Id { get; set; }

        [StringLength(1000)]
        public string Details1 { get; set; }

        [StringLength(1000)]
        public string Details2 { get; set; }

        [StringLength(100)]
        public string Image1 { get; set; }

        [StringLength(100)]
        public string Image2 { get; set; }
    }
}
