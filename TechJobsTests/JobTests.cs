using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {

      
        [TestMethod]
        public void TestSettingJobId()
        {
            Job job1 = new Job();
            Job job2 = new Job();

            Assert.IsFalse(job1.Id.Equals(job2.Id));

        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Job job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            Assert.AreEqual("Product tester", job3.Name);
            Assert.AreEqual("ACME", job3.EmployerName.ToString());
            Assert.AreEqual("Desert", job3.EmployerLocation.ToString());
            Assert.AreEqual("Quality control", job3.JobType.ToString());
            Assert.AreEqual("Persistence", job3.JobCoreCompetency.ToString());
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Job job4 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Job job5 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            Assert.IsFalse(job4.Equals(job5));
        }


        //When passed a Job object, it should return a string that contains a blank line 
        //before and after the job information.
        [TestMethod]
        public void ToStringBlankLine() {

            Job job6 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));


            string Expected = "ID:  ______\n" +
                "Name: _______\n" +
                "Employer: _______\n" +
                "Location: _______\n" +
                "Position Type: _______\n" +
                "Core Competency: _______\n";

            Assert.IsFalse(Expected.Equals(job6));
        }


        //The string should contain a label for each field, followed by the data stored in that field.
        //Each field should be on its own line.
        [TestMethod]
        public void ToStringLabelData()
        {
            Job job9 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));


            string Expected = "ID: 9\n" +
                              "Name: Product tester\n" +
                              "Employer: ACME\n" +
                              "Location: Desert\n" +
                              "Position Type: Quality control\n" +
                              "Core Competency: Persistence\n";

            Assert.AreEqual(Expected, job9.ToString());
        }


        //If a field is empty, the method should add, “Data not available” after the label.
        [TestMethod]
        public void ToStringEmptyField()
        {
            Job job7 = new Job("Product tester", new Employer(""), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));


            string ExpectedString = "ID: 7\n" +
                              "Name: Product tester\n" +
                              "Employer: Data not available\n" +
                              "Location: Desert\n" +
                              "Position Type: Quality control\n" +
                              "Core Competency: Persistence\n";

            Assert.AreEqual(ExpectedString, job7.ToString());
        }


        //(Bonus) If a Job object ONLY contains data for the id field, the method should return, 
        //“OOPS! This job does not seem to exist.”
        [TestMethod]
        public void ToStringEmptyObject()
        {
            Job job8 = new Job();

            Assert.AreEqual("OOPS! This job does not seem to exist.", job8.ToString());
        }
    }
}
