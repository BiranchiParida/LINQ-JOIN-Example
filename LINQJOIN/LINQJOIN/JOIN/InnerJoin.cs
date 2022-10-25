	using System;
	using System.Collections.Generic;
	using LINQJOIN.Common;
	using LINQJOIN.Model;
	using System.Linq;

	namespace LINQJOIN.JOIN
	{
		public class InnerJoin
		{
			List<Employee> em1 = FillListObject.FilEmployeeObject();
			List<Employee2> em2 = FillListObject.FilEmployee2Object();

			public void InnerjoininLambda()
			{
				var result = em1.Join(em2,
							   e1 => e1.EmpId,
							   e2 => e2.EmpId,
							   (e1, e2) => new
							   {
								   Employeename = e1.EmpName,
								   EmployeeDept = e2.EmpDept
							   });

				foreach(var emp in result)
				{
					Console.WriteLine($"employee Name={emp.Employeename} & Employee Dept= {emp.EmployeeDept}");
				}

			}
			public void NormalInnerJoin()
			{
				var result = from e1 in em1
							 join e2 in em2
							 on e1.EmpId equals e2.EmpId
							 select new
							 {
								 EmployeeName = e1.EmpName,
								 EmployeeDept = e2.EmpDept
							 };

				foreach (var emp in result)
				{
					Console.WriteLine($"employee Name = {emp.EmployeeName} & Employee Dept = {emp.EmployeeDept}");
				}
			}
		}


	}

