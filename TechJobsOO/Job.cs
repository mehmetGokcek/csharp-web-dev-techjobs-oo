using System;
namespace TechJobsOO
{
    public class Job : JobField
    {
        public static int nextID = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors.

        public Job()
        {
            Id = nextID;
            nextID++;
        }

        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
        }


        public override string ToString()
        {
            if (Name == null && EmployerName == null && EmployerLocation == null &&
                JobType == null && JobCoreCompetency == null)
            {
                return "OOPS! This job does not seem to exist.";
            }

            else
            {
                return $"ID: {Id}\n" +
                       $"Name: {Name}\n" +
                       $"Employer: {EmployerName}\n" +
                       $"Location: {EmployerLocation}\n" +
                       $"Position Type: {JobType}\n" +
                       $"Core Competency: {JobCoreCompetency}\n";
            }
        }

    }
}
