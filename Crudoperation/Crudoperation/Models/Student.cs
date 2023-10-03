using System.ComponentModel.DataAnnotations;

namespace Crudoperation.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public int RollNo { get; set; }

        public string Address { get; set; }




    }
}
