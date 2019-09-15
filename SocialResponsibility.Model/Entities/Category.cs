using System.ComponentModel.DataAnnotations;

namespace SocialResponsibility.Model.Entities
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [MaxLength(64)]
        public string Name { get; set; }
    }
}
