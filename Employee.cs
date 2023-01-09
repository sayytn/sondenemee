using System.ComponentModel.DataAnnotations.Schema;

namespace SonDeneme
{
    [Table("tblEmployee")]

    public class Employee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Gender { get; set; }
    }
}
