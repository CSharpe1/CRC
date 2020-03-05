using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W1._1
{
    class Student
    {
        public static int StudentCount;
        public string firstName;
        public string lastName;
        public string grade;
    }
    class Program
    {
        static void Main(string[] args) {
            Student firstStudent = new Student();
            Student.StudentCount++;
            Student secondStudent = new Student();
            Student.StudentCount++;

            firstStudent.firstName = "John";
            firstStudent.lastName = "Smith";
            firstStudent.grade = "A-";

            secondStudent.firstName = "Tom";
            secondStudent.lastName = "Thumb";
            secondStudent.grade = "C-";

            // task 1 , add user input

            Console.WriteLine("Student 1;");
            Console.WriteLine(firstStudent.firstName);
            Console.ReadLine();
            Console.WriteLine("Student 2;");
            Console.WriteLine(secondStudent.firstName);
            Console.ReadLine();
            Console.WriteLine("# of Students;");
            Console.WriteLine(Student.StudentCount);
            Console.ReadLine();

            // Display fisrtName, lastName and grade
            Console.WriteLine("First Name;{0} \nLast Name;{1} \nGrade;{2}", firstStudent.firstName, firstStudent.lastName, firstStudent.grade);



            // Keep Console open until I close it
            Console.WriteLine("Press any key to close");
            Console.ReadKey();
        }
    } 
}
