using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_2131419
{
    class Student : Person
    {
        string studentID;
        string cohorNumber;
        double balance;
        string semesterID;

        public Student(string studentID, string cohorNumber, double balance, string semesterID, string firstname, string lastname, int departmentCode) : base(firstname, lastname, departmentCode)
        {
            this.studentID = studentID;
            this.cohorNumber = cohorNumber;
            this.balance = balance;
            this.semesterID = semesterID;
        }

        public string StudentID
        {
            get { return studentID; }
            set { this.studentID = value; }
        }

        public string CohorNumber
        {
            get { return cohorNumber; }
            set { this.cohorNumber = value; }
        }

        public double Balance
        {
            get { return balance; }
            set { this.balance = value; }
        }

        public string SemesterID
        {
            get { return semesterID; }
            set { this.semesterID = value; }
        }

        public string getID()
        {
            return studentID;
        }

        public string getCohorNumber()
        {
            return cohorNumber;
        }

        public double getBalance()
        {
            return balance;
        }

        public void clearCommand()
        {
            Console.Clear();
        }

        public override string toString()
        {
            return StudentID + " " + base.toString();
        }
    }
}
