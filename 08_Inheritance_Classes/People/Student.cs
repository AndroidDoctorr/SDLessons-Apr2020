using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Inheritance_Classes.People
{
    public enum GradeLevel { fr, so, jr, sr }
    public enum CourseOfStudy { SD, WD }
    public class Student : Person
    {
        public GradeLevel GradeLevel { get; set; }
        public CourseOfStudy Course { get; set; }
        public string Cohort
        {
            get
            {
                return GradeLevel + "/" + Course;
            }
        }


        public double AverageScore { get; set; }
        public string LetterGrade
        {
            get
            {
                return GetLetterGradeFromScore();
            }
        }

        private string GetLetterGradeFromScore()
        {
            if (AverageScore > 90)
            {
                return "A";
            }
            else if (AverageScore > 80)
            {
                return "B";
            }
            else
            {
                return "F";
            }
        }
    }
}
