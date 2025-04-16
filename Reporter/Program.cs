using System;
using System.IO;
using Reporter.Domain;

namespace Reporter 
{
	class Program
	{
		static void Main(string[] args) {


			var employees = new List<Employee>() {
			new Employee {Name = "Ivan", Salary = 100 },
			new Employee {Name = "Boris", Salary = 50},
			new Employee {Name = "Fedor", Salary = 250}
			};

			var builder = new EmployeeReportBuilder(employees);
			var director = new EmployeeReportDirector(builder);
			director.Build();

			var report = builder.GetReport();
			Console.WriteLine(report);
		}
	}
}