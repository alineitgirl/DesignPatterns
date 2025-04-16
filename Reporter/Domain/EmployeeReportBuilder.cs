using System;
using System.Collections.Generic;
using System.Linq;
using Reporter.Domain;

public class EmployeeReportBuilder : IEmployeeReportBuilder
{
    private EmployeeReport _report;
    private IEnumerable<Employee> _employees;

    public EmployeeReportBuilder(List<Employee> employees)
    {
        _employees = employees;
        _report = new EmployeeReport();
    }

    public void BuildHeader()
    {
        _report.Header = $"REPORT ON THE DATE: {DateTime.Now}" +
                         "\n-----------------------------------------------------------------------------------------------\n\n\n";
    }

    public void BuildBody()
    {
        _report.Body = string.Join(
            Environment.NewLine, _employees.Select(e =>
                $"Employee: {e.Name} \t\t\t Salary: {e.Salary}$"));
    }

    public void BuildFooter()
    {
        _report.Footer =
            $"\n\n\n---------------------------------------------------------------------------------------------\n\n";
        _report.Footer += $"\nTOTAL EMPLOYEES: {_employees.Count()}" +
                          $" TOTAL SALARY: {_employees.Sum(e => e.Salary)}$\n\n\n";
    }

    public EmployeeReport GetReport()
    {
        var resultReport = _report;
        _report = new EmployeeReport();
        return resultReport;
    }
}