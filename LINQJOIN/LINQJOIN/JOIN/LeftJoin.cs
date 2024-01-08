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

		public  void LeftJoinInNormal()
        {
			var result = from e1 in em1
						 join e2 in em2
						 on e1.EmpId equals e2.EmpId
						 into EmployeeGroup
						 from add in EmployeeGroup.DefaultIfEmpty()
						 select new { add, e1 };

		    foreach (var emp in result)
			{
				Console.WriteLine($"employee  & Employee Dept= ");
			}
		}
		public void RightJoinInNormal()
		{
			var result = from e2 in em2
						 join e1 in em1
						 on e2.EmpId equals e1.EmpId
						 into EmployeeGroup
						 from add in EmployeeGroup.DefaultIfEmpty()
						 select new { add, e2 };

			foreach (var emp in result)
			{
				Console.WriteLine($"employee  & Employee Dept= ");
			}
		}

	}
}

