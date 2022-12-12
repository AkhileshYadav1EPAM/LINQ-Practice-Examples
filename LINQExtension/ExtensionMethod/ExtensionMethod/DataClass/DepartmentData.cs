using ExtensionMethod.DefinitionClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod.DataClass
{
    public class DepartmentData
    {
        public List<Department> deparmentList = new List<Department>()
        {
            new Department(){DepartmentId=101, DepartmentName="IT"},
            new Department(){DepartmentId=102, DepartmentName="HR"},
            new Department(){DepartmentId=103, DepartmentName="Account"},
        };
    }
}
