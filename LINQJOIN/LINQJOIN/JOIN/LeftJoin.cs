using System;
using System.Collections.Generic;
using LINQJOIN.Common;
using LINQJOIN.Model;
using System.Linq;

namespace LINQJOIN.JOIN
{
	public class LeftJoin
	{
		List<Employee> em1 = FillListObject.FilEmployeeObject();
		List<Employee2> em2 = FillListObject.FilEmployee2Object();

		public void LeftJoinInNormal()
        {
			var result = from e1 in em1
						 join e2 in em2
						 on e1.EmpId equals e2.EmpId
						 into EmployeeGroup
						 from add in EmployeeGroup.DefaultIfEmpty()
						 select new { add.EmpDept, add.EmpSalary };

		    foreach (var emp in result)
			{
				Console.WriteLine($"employee Salary= {emp.EmpSalary} & Employee Dept= {emp.EmpDept}");
			}
		}
	}
}

