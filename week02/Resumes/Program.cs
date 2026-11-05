using System;

class Programme
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "BYU, Idaho";
        job1._startYear = 2026;
        job1._endYear = 2029;

        Job job2 = new Job();
        job2._jobTitle = "Software Developer";
        job2._company = "currently undergoing studies";
        job2._startYear = 2026;
        job2._endYear = 2029;

        Resume myResume = new Resume();
        myResume._name = "Mathias Abbas Nyako";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}