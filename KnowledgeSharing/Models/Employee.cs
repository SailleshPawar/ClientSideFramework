using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KnowledgeSharing.Models
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }
        public string EmCode { get; set; }
        public string Profile { get; set; }
    }

    public class EmployeeVM
    {
        public EmployeeVM()
        {
            Employees = new List<Employee>();
        }
        public List<Employee> Employees { get; set; }//list of meeting
    }
}