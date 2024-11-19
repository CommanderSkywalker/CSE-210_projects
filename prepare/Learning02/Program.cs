using System;
public class Job
{
    public string _title;
    public string _companyName;
    public int _startYear;
    public int _endYear;
    public void Display()
    {
        Console.WriteLine($"{_title} ({_companyName}), {_startYear}-{_endYear}");
    }
}
public class Resume
{
    public string _name;
    public  List<Job> _jobs = new List<Job>();
    public void Display()
    {
        Console.WriteLine($"{_name}");
        Console.WriteLine("Jobs:");
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Resume myResume = new Resume();
        myResume._name = "Luke";
        Console.WriteLine("Hello Learning02 World!");
        Job job1 = new Job();
        job1._title = "Inventory Merchendising Supervisor";
        job1._companyName = "Staples";
        job1._startYear = 2023;
        job1._endYear = 2024;

        Job job2 = new Job();
        job2._title = "Order picker";
        job2._companyName = "Home Depot";
        job2._startYear = 2020;
        job2._endYear = 2023;
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        
        myResume.Display();

    }
}