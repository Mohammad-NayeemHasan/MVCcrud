namespace MVCcrud.Models
{
    public class Department
    {
        public Department()
        {
           
            Employees = new List<Employee>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
