using System.ComponentModel.DataAnnotations.Schema;

namespace MVCcrud.Models
{
    public class Employee
    {
        public int Id { get; set; } 
        public string Name { get;set; } 
        public decimal Salary { get; set; }
        [ForeignKey("Department")]
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
