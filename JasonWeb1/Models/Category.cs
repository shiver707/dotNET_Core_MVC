using System.ComponentModel.DataAnnotations;

namespace JasonWeb1.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; } //need to set primary key, data anotation.
        [Required]
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
        

    }
}
