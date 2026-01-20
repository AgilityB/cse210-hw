using System;

class Program
{
    static void Main(string[] args)
    {
        //first job
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        //second job
        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        //third job
        Job job3 = new Job();
        job3._jobTitle = "Dangote Petroleum Refinery";
        job3._company = "Maintenance Engineer";
        job3._startYear = 2023;
        job3._endYear = 2025;

        //add jobs to list
        Resume myResume = new Resume();
        myResume._name = "Nwakwuruibe Bright";

        myResume._jobs = new List<Job>();

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume._jobs.Add(job3);

        myResume.DisplayResume();
    }
}