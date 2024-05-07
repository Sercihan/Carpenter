using System.ComponentModel.DataAnnotations;

namespace Carpenter.ORM.Entities
{
    public class Testimonial
    {
        public int Id { get; set; }
        public string Image { get; set; }
        [StringLength(30)]
        public string Title { get; set; }
        [StringLength(300)]
        public string Description { get; set; }
    }
}
