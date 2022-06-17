using System.ComponentModel.DataAnnotations;

namespace BookAppMVC.Models
{
    public class Category
    {
        [Key]

        public int myProperty { get; set; }

        [Required]
        public string Name { get; set; }

        public int DisplayOrder { get; set; }

        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
