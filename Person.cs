using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_2131419
{
    abstract class Person
    {
        string firstname;
        string lastname;
        int departmentCode;

        public Person(string firstname, string lastname, int departmentCode)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.departmentCode = departmentCode;
        }

        public string Firstname
        {
            get { return firstname; }
            set { this.firstname = value; }
        }

        public string Lastname
        {
            get { return lastname; }
            set { this.lastname = value; }
        }

        public int DepartmentCode
        {
            get { return departmentCode; }
            set { this.departmentCode = value; }
        }

        public virtual string toString()
        {
            return Firstname + " " + Lastname + " " + DepartmentCode;
        }
    }
}
