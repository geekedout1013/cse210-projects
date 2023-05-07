using System;

class Program
{
    static void Main(string[] args)
    {
        
        Job job1 = new Job();
        job1._company ="Google";
        job1._jobTitle ="Web Developer";
        job1._startYear =2017;
        job1._endYear =2023;

        Job job2 = new Job();
        job2._company ="Acme Inc";
        job2._jobTitle ="Web Desginer";
        job2._startYear =2010;
        job2._endYear =2017;

        Job job3 = new Job();
        job3._company ="Stark Enterprises";
        job3._jobTitle ="R & D";
        job3._startYear =2006;
        job3._endYear =2010;

        Resume resume1 = new Resume();
        resume1._name ="Reese Edwards";
        resume1._jobs = new List<Job>();
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        resume1._jobs.Add(job3);

        resume1.Display();
    

        
    }
}