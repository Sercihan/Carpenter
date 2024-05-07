using System.ComponentModel.DataAnnotations;

namespace Carpenter.ORM.Entities
{
    public class Team
    {
        public int Id { get; set; }
        [StringLength(30)]
        public string Name { get; set; }
        [StringLength(30)]
        public string Surname { get; set; }
        [StringLength(30)]
        public string Title { get; set; }
        public string Image { get; set; }
    }
}
