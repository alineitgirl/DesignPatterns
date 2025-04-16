namespace Reporter.Domain;

public interface IEmployeeReportBuilder
{
    public void BuildHeader();

    public void BuildBody();

    public void BuildFooter();

    public EmployeeReport GetReport();
}