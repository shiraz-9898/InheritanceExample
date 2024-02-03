using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(name: "student1", studentId: 171, contact: 9871230654, address: "Ashoka Garden");
            s1.StudentDetails();

            Console.WriteLine();

            Teacher t1 = new Teacher(name: "teacher1", teacherId: 101, contact: 9876543210, address: "Pata Nahi");
            t1.TeacherDetails();

            Console.ReadKey();
        }
    }

    public class Person
    {
        public string name;
        public string address;
        public long contact;
    }

    public class Student : Person
    {
        public int studentId;

        public Student(string name, string address, long contact, int studentId)
        {
            this.name = name;
            this.address = address;
            this.contact = contact;
            this.studentId = studentId;
        }

        public void StudentDetails()
        {
            Console.WriteLine("Student's Name: " + name);
            Console.WriteLine("Student's Student Id: " + studentId);
            Console.WriteLine("Student's Address: " + address);
            Console.WriteLine("Student's Contact: " + contact);
        }

    }

    public class Teacher : Person
    {
        public int teacherId;

        public Teacher(string name, string address, long contact, int teacherId)
        {
            this.teacherId = teacherId;
            this.name = name;   
            this.address = address;
            this.contact = contact;
        }

        public void TeacherDetails()
        {
            Console.WriteLine("Teacher's Name: " + name);
            Console.WriteLine("Teacher's Teacher Id: " + teacherId);
            Console.WriteLine("Teacher's Address: " + address);
            Console.WriteLine("Teacher's Contact: " + contact);
        }
    }
}
