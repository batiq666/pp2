using System;

namespace Task2
{
    class Student
    {
        public string name;
        public string id;
        public int year;
        public Student(string name, string id, int year)
        {
            this.name = name;
            this.id = id;
            this.year = year;
        }
        public void PrintStudent()
        {
            for (int i = 1; i < 5; i++)
            {
                this.year = i;
                Console.WriteLine(this);
            }
        }
        public override string ToString()
        {
            return name + " " + id + " " + year;
        }
      
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student first = new Student("Batyrbek", "18BD174334", 1);
            first.PrintStudent();
        
        }
        
    }
    
}
