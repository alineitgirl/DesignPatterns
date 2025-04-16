namespace Reporter.Domain;

public class EmployeeReportDirector
{
    private readonly IEmployeeReportBuilder _builder;

    public EmployeeReportDirector(IEmployeeReportBuilder builder)
    {
        _builder = builder;
    }

    public void Build()
    {
        _builder.BuildHeader();
        _builder.BuildBody();
        _builder.BuildFooter();
    }
}