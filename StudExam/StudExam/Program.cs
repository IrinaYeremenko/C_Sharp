using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudExam
{
    public class Student
    {
        public string Name;
        public string Lastname;

        public Student(string lastname, string name)
        {
            this.Name = name;
            this.Lastname = lastname;
        }
    }

    class RangeException : Exception
    {
        public int Mark { get; }

        public override string Message
        {
            get
            {
                return "Некорректная операция";
            }
        }

        public RangeException(int mark)
        {
            this.Mark = mark;
        }
    }

    class ExistExceptions : Exception
    {
        public string Lastname { get; }
        public string Name { get; }

        public override string Message
        {
            get
            {
                return "Некорректная операция";
            }
        }

        public ExistExceptions(string lastname, string name)
        {
            this.Lastname = lastname;
            this.Name = name;
        }
    }

    class DictionaryStudents
    {
        private SortedList<Student, int> _students;

        private static readonly Random getrandom = new Random();

        public int GetRandomNumber(int min, int max)
        {
            lock (getrandom) // synchronize
            {
                return getrandom.Next(min, max);
            }
        }

        public DictionaryStudents()
        {
            _students = new SortedList<Student, int>(new StudentComparer());
        }

        public void AddStudents(int n)
        {
            string[] lastnames = { "Рыженко", "Мастюх", "Василенко", "Франко", "Симончук", "Зварыч" };
            string[] names = { "Егор", "Александр", "Татьяна", "Анастасия", "Эдуард", "Анна" };
            int[] marks = { 98, 47, 66, 89, 203, -1 };

            for (int i = 0; i < n; i++)
            {
                var lastname = lastnames[GetRandomNumber(0, 5)];
                var name = names[GetRandomNumber(0, 5)];
                var mark = marks[GetRandomNumber(0, 5)];

                var st = new Student(lastname, name);
                try
                {
                    AddStudent(st, mark);
                }

                catch (RangeException e)
                {
                    Console.WriteLine("Студент не был добавлен - оценка {0} вне диапазона 0-100: {1}", e.Mark, e.Message);
                }

                catch (ExistExceptions ee)
                {
                    Console.WriteLine("Студент {0} {1} уже есть в списке: {2}", ee.Lastname, ee.Name, ee.Message);
                }
            }
        }

        public void AddStudent(Student st, int mark)
        {
                if (mark < 0 || mark > 100)
                {
                    throw new RangeException(mark);
                }

                foreach (var stud in _students)
                {
                    if (stud.Key.Lastname == st.Lastname && stud.Key.Name == st.Name)
                    {
                        throw new ExistExceptions(st.Lastname, st.Name);
                    }
                }

                _students.Add(st, mark);
        }

        public void ListStudents()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Список студентов:");
            foreach (var student in _students)
            {
                Console.WriteLine(student.Key.Lastname + " " + student.Key.Name + " - " + student.Value);
            }
        }
    }

    public class StudentComparer : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            int lastnamesResult = String.Compare(x.Lastname, y.Lastname);
            if (lastnamesResult != 0)
            {
                return lastnamesResult;
            }
            return String.Compare(x.Name, y.Name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DictionaryStudents dictionaryStudents = new DictionaryStudents();
            dictionaryStudents.AddStudents(15);
            dictionaryStudents.ListStudents();
        }
    }
}