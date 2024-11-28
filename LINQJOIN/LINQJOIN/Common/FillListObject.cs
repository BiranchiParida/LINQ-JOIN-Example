using System;
using System.Collections.Generic;
using LINQJOIN.Model;

namespace LINQJOIN.Common
{
	public class FillListObject
	{
        public static List<Employee> FilEmployeeObject()
        {
            return new List<Employee>()
            {

            new Employee() {EmpId = 300, EmpName = "Anu", EmpLang = "C#"},

            new Employee() {EmpId = 301, EmpName = "Mohit", EmpLang = "C"},

            new Employee() {EmpId = 302, EmpName = "Sona", EmpLang = "Java"},
            new Employee() {EmpId = 303, EmpName = "Lana", EmpLang = "Java"},

            new Employee() {EmpId = 304, EmpName = "Lion", EmpLang = "C#"},

            new Employee() {EmpId = 305, EmpName = "Ramona", EmpLang = "Java"},

           };
        }
        public static List<Employee2> FilEmployee2Object()
        {
            return new List<Employee2>() {

            new Employee2() {EmpId = 300, EmpDept = "Designing",
                                              EmpSalary = 23000},

            new Employee2() {EmpId = 301, EmpDept = "Developing",
                                               EmpSalary = 40000},

            new Employee2() {EmpId = 302, EmpDept = "HR",
                                       EmpSalary = 50000},

            new Employee2() {EmpId = 303, EmpDept = "Designing",
                                              EmpSalary = 60000},
            new Employee2() {EmpId = 307, EmpDept = "Designing",
                                              EmpSalary = 60000},

        };
        }
    }
}

