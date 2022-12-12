using ExtensionMethod.DataClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod.ExtensionOperatorClasses
{
    public class Join
    {
        public void JoinMethod()
        {
            EmployeeData employeeData = new EmployeeData();
            DepartmentData departmentData = new DepartmentData();

            Console.WriteLine("-> Join Operator <-");
            Console.WriteLine();

            /*var resultJoin = from emp in employeeData.employeeList
                             join dpt in departmentData.deparmentList
                             on emp.DepartmentId equals dpt.DepartmentId
                             select new
                             {
                                 EmployeeName = emp.Name,
                                 EmployeeDepartmentName = dpt.DepartmentName
                             };*/

            var resultJoin = employeeData.employeeList.Join(
                                    departmentData.deparmentList,
                                    emp => emp.DepartmentId,
                                    dpt => dpt.DepartmentId,
                                    (emp, dpt) => new
                                    {
                                        EmployeeName = emp.Name,
                                        EmployeeDepartmentName = dpt.DepartmentName
                                    });


            foreach(var item in resultJoin)
            {
                Console.WriteLine("{0} - {1}", item.EmployeeName, item.EmployeeDepartmentName);
            }

         Console.WriteLine();
        }
    }
}
