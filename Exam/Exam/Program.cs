using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    abstract class Person
    {
        public abstract string Name();
        public abstract string Lastname();
    }
    class Student : Person
    {
        public int Mark
        {
            get { return Mark; }
            set { Mark = value; }
        }

    public Student(string name, string lastname)
        {
            
        }
    }

    class Teacher:Person
    {
        public string department
        {
            get { return department; }
            set { department = value; }
        }
        public Teacher(string name, string lastname, string department)
        {

        }
    }

    class Group
    {
        public string group_number
        {
            get { return group_number; }
            set { group_number = value; }
        }
        Student[] students = new Student[20];

        public Group(string number, int count)
        {
            
        }

        public AddStudents()
        {

        }
    }

    class Exam
    {
        public string discipline;
        Teacher teacher = new Teacher();
        Group group = new Group();

        public Exam(string subj, Teacher teach, Group group)
        {

        }

        public ProcessExam()
        {

        }

        public ResultExam()
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Group group = new Group();
            AddStudents();

            Exam exam = new Exam("Программирование", teach, group);

            exam.ProcessExam();
            exam.ResultExam();
        }
    }
}
