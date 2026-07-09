public class Job
{
    public String _company = "";
    public String _jobTitle = "";
    public int _startYear = 0;
    public int _endYear = 0;

    public void DisplayJob()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}