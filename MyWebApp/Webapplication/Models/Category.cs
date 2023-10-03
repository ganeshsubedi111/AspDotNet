using System.ComponentModel.DataAnnotations;
namespace Webapplication.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        public  string LastName{ get; set; }

        public float salary { get; set; }
        
    }
}
