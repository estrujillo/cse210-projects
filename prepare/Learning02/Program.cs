using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Global";
        job1._jobTitle = "Software Engineer";
        job1._startYear = "2019";
        job1._endYear = "2020";
        Job job2 = new Job();
        job2._company = "Hitss";
        job2._jobTitle = "Network Engineer";
        job2._startYear = "2021";
        job2._endYear = "2022";
        //job1.Display();
        //job2.Display();

        Resume resume1 = new Resume();
        resume1._name = "Eduardo Trujillo";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        resume1.Display();
    }
}