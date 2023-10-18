using System.ComponentModel.DataAnnotations.Schema;

namespace EnterpriseResourcePlanning.Models
{
    public class JobTitle
    {
        public int JobTitleId { get; set; }
        public string JobTitleName { get; set; }
        public decimal Salary { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public List<Employee> Employees { get; set; }

    }
}
