using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_2131419
{
    class Teacher : Person
    {
        string teacherID;
        int yearsOfExperience;
        double teachingHours;

        public Teacher(string teacherID, int yearsOfExperience, double teachingHours, string firstname, string lastname, int departmentCode) : base(firstname, lastname, departmentCode)
        {
            this.teacherID = teacherID;
            this.yearsOfExperience = yearsOfExperience;
            this.teachingHours = teachingHours;
        }

        public string TeacherID
        {
            get { return teacherID; }
            set { this.teacherID = value; }
        }

        public int YearsOfExperience
        {
            get { return yearsOfExperience; }
            set { this.yearsOfExperience = value; }
        }

        public double TeachingHours
        {
            get { return teachingHours; }
            set { this.teachingHours = value; }
        }

        public override string toString()
        {
            return TeacherID + " " + base.toString();
        }

        public string getID()
        {
            return teacherID;
        }

        public int getYearsOfExperience()
        {
            return yearsOfExperience;
        }

        public double getHours()
        {
            return teachingHours;
        }
    }
}
