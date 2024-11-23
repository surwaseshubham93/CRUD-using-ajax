using System.ComponentModel.DataAnnotations;

namespace Practice.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public long Salary { get; set; }

        public string Department { get; set; }
                        
    }
}
