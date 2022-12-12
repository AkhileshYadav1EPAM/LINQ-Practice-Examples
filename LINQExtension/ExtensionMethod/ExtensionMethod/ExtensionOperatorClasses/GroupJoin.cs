using ExtensionMethod.DataClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod.ExtensionOperatorClasses
{
    public class GroupJoin
    {
        public void GroupJoinMethod()
        {
            EmployeeData employeeData = new EmployeeData();
            DepartmentData departmentData = new DepartmentData();

            Console.WriteLine("-> GroupJoin Operator <-");
            Console.WriteLine();

            /*var resultGroupJoin = from dpt in departmentData.deparmentList
                                  join emp in employeeData.employeeList
                                  on dpt.DepartmentId equals emp.DepartmentId
                                  into EmployeeDepartmentNameGroup
                                  select new
                                  {
                                      EmployeeName = EmployeeDepartmentNameGroup,
                                      DepartmentName = dpt.DepartmentName
                                  };*/

            var resultGroupJoin = departmentData.deparmentList.GroupJoin(employeeData.employeeList,
                                    dept => dept.DepartmentId,
                                    emp => emp.DepartmentId,
                                    (dept, EmployeeDepartmentNameGroup) => new
                                    {
                                        EmployeeName = EmployeeDepartmentNameGroup,
                                        DepartmentName = dept.DepartmentName
                                    });


            foreach(var item in resultGroupJoin)
            {
                Console.WriteLine("---> {0}", item.DepartmentName);

                foreach(var empName in item.EmployeeName)
                {
                    Console.WriteLine(empName.Name);
                }
            }

            Console.WriteLine();
        }
    }
}
