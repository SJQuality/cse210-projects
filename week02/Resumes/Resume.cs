public class Resume()
{
    public String _name = "";
    public List<Job> _jobs = new List<Job>();


    public void DisplayResume()
    {
        Console.WriteLine(_name);

        foreach (String position in _jobs)
        {

        }
    }


}