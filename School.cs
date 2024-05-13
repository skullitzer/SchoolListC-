using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Midterm_2131419
{
    class Program
    {
        static void Main(string[] args)
        {
            new School().addStudent();
            new School().addTeacher();
        }
    }
    public class School
    {
        Students myStudents = new Students();
        Teachers myTeachers = new Teachers();

        public void addStudent()
        {
            Console.WriteLine("Please enter the StudentID: ");
            string studentID = Console.ReadLine();
            if (studentID.Length != 6)
            {
                Console.WriteLine("The StudentID should be exactly 6 characters");
                return;
            }
            else
            {
                foreach (Student student in myStudents)
                {
                    if (student.getID() == studentID)
                    {
                        Console.WriteLine("There is another student with this ID");
                        return;
                    }
                }
                Console.WriteLine("Please enter the Firstname: ");
                string firstname = Console.ReadLine();
                Console.WriteLine("Please enter the Lastname: ");
                string lastname = Console.ReadLine();
                if (firstname.Length + lastname.Length >= 35)
                {
                    Console.WriteLine("The length should not exceed 35 characters");
                    return;
                }
                else
                {
                    Console.WriteLine("Please enter the Cohor Number: ");
                    string cohorNumber = Console.ReadLine();
                    if (cohorNumber.Length != 6)
                    {
                        Console.WriteLine("The Cohor Number should be exactly  characters");
                        return;
                    }
                    else
                    {
                        foreach (Student student in myStudents)
                        {
                            if (student.getCohorNumber() == cohorNumber)
                            {
                                Console.WriteLine("There is another student with this Number");
                                return;
                            }
                        }
                        Console.WriteLine("Please enter the SemesterID: ");
                        string semesterID = Console.ReadLine();
                        if (semesterID.Length != 6)
                        {
                            Console.WriteLine("The entered SemesterID is invalid");
                            return;
                        }
                        else
                        {
                            double balance = 0.0;
                            int departmentCode = 0;
                            Student student = new Student(studentID, cohorNumber, balance, semesterID, firstname, lastname, departmentCode);
                            myStudents.add(student);
                            Console.WriteLine("The Student has been successfully added to the list");
                        }
                    }
                }
            }
        }   

        public void addTeacher()
        {
            Console.WriteLine("Please enter the TeacherID: ");
            string teacherID = Console.ReadLine();
            if (teacherID.Length != 6)
            {
                Console.WriteLine("The TeacherID should be exactly 6 characters");
            }
            else
            {
                foreach (Teacher teacher in myTeachers)
                {
                    if (teacher.getID() == teacherID)
                    {
                        Console.WriteLine("There is another teacher with this ID");
                        return;
                    }
                }
                Console.WriteLine("Please enter the Firstname: ");
                string firstname = Console.ReadLine();
                Console.WriteLine("Please enter the Lastname: ");
                string lastname = Console.ReadLine();
                if (firstname.Length + lastname.Length >= 35)
                {
                    Console.WriteLine("The length should not exceed 35 characters");
                }
                else
                {
                    int yearsOfExperience = 0;
                    double teachingHours = 0.0;
                    int departmentCode = 0;
                    Teacher teacher = new Teacher(teacherID, yearsOfExperience, teachingHours, firstname, lastname, departmentCode);
                    myTeachers.add(teacher);
                    Console.WriteLine("The Teacher has been successfully added to the list");
                }
            }
        }

        public bool studentVerifier(string studentID)
        {
            bool flag = false;
            foreach (Student student in myStudents)
            {
                if (student.getID() == studentID)
                {
                    flag = true;
                }
            }
            return flag;
        }

        public bool teacherVerifier(string teacherID)
        {
            bool flag = false;
            foreach (Teacher teacher in myTeachers)
            {
                if (teacher.getID() == teacherID)
                {
                    flag = true;
                }
            }
            return flag;
        }

        public static void writeIntoStudent()
        {
            Student student = new Student("123456", "123456", 0.0, "123456", "Varad", "Patil", 0);
            using (StreamWriter sw = new StreamWriter(@"C:\Users\VARAD\source\repos\Midterm_2131419\students.txt", true))
            {
                sw.Write(student.toString());
            }
        }
    }
}