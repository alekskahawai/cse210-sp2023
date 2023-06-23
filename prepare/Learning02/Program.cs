using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a new job instance named job1 .
        Job job1 = new Job();

        // Set the member variables using the dot notation 
        // (for example, job1._jobTitle = "Software Engineer";
        job1._company = "Local Cherity";
        job1._jobTitle = "Pro-bono Volunteer";
        job1._startYear = 2018;
        job1._endYear = 2021;

        /* Verify that you can display the company of this job on the screen, again using the dot notation to access the member variable. */
        // Console.WriteLine(job1._company);

        // Create a second job
        Job job2 = new Job();

        job2._company = "Global Company";
        job2._jobTitle = "Deputy Manager";
        job2._startYear = 2021;
        job2._endYear = 2023;

        /* Verify that you can display the jobs on the screen correctly. */
        // job1.DisplayJobDetails();
        // job2.DisplayJobDetails();

        // create a new instance of the Resume class.
        Resume workingResume = new Resume();
        workingResume._name = "Aleksejs Volegovs";

        // Add the two jobs you created earlier, to the list of jobs in the resume object.
        workingResume._jobs.Add(job1);
        workingResume._jobs.Add(job2);

        /* Verify that you can access and display the first job title */
        // Console.WriteLine(workingResume._jobs[0]._jobTitle);

        /* add a call at the end to the Display method from your Resume class to display the name and all the jobs in one line. */
        workingResume.DisplayResume();

    }
}