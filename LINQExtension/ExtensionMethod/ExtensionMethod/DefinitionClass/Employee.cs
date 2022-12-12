using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod.DefinitionClass
{
    public class Employee
    {
        public int Age { get; set; }    
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public int DepartmentId { get; set; }
        public List<string> skills { get; set; }
    }
}
