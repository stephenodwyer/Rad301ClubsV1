using Rad301ClubsV1.Models.ClubModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Rad301ClubsV1.Migrations.ClubModelMigrations
{
    public class StudentData
    {

        public List<Student> studentSeeds = new List<Student>();

        public StudentData()
        {
            if (File.Exists(@".\Test Students.csv"))
                studentSeeds = File.ReadAllLines(@".\Test Students.csv")
                                               .Select(v => FromCsv(v)).ToList();
            else throw new 
                    Exception {
                Source = "Student Data class" + @".\Test Students.csv" + " does not exist",
                 
                 
                 };
        }

        public static Student FromCsv(string csvLine)
        {
            string[] values = csvLine.Split(',');
            Student StudentTestData = new Student();
            StudentTestData.StudentID = values[0];
            StudentTestData.Fname = values[1];
            StudentTestData.Sname = values[2];
            //dailyValues.playerid = Guid.NewGuid();
            //dailyValues.FirstName = values[0];
            //dailyValues.SecondName = values[1];
            //dailyValues.GamerTag = values[2];
            //dailyValues.topscore = Int32.Parse(values[3]);

            return StudentTestData;
        }
    }
}