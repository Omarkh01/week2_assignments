using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public abstract class Person
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; private set; }
        protected decimal salary;

        public Person(string name, DateTime birthDate)
        {
            Name = name;
            BirthDate = birthDate;
        }

        public void CalculateAge()
        {
            Console.WriteLine($"Age: {DateTime.Now.Year - BirthDate.Year}");
        }

        public virtual void CalculateSalary()
        {
            Console.WriteLine($"Salary: {salary:C}");
        }

        public void SetSalary(decimal newSalary)
        {
            if (newSalary < 0)
                throw new ArgumentException("Salary cannot be negative.");
            salary = newSalary;
        }
    }

    public class Student : Person, IStudentService
    {
        public List<string> Courses { get; private set; } = new List<string>();

        public Student(string name, DateTime birthDate) : base(name, birthDate) { }

        public void CalculateGPA()
        {
            // Placeholder for GPA calculation
            Console.WriteLine("Calculating GPA...");
        }
    }

    public class Instructor : Person, IInstructorService
    {
        public DateTime JoinDate { get; private set; }

        public Instructor(string name, DateTime birthDate, DateTime joinDate) : base(name, birthDate)
        {
            JoinDate = joinDate;
        }

        public void CalculateBonus()
        {
            int experienceYears = DateTime.Now.Year - JoinDate.Year;
            decimal bonus = experienceYears * 1000;  // Simplified bonus calculation
            Console.WriteLine($"Bonus: {bonus:C}");
        }

        public override void CalculateSalary()
        {
            base.CalculateSalary();
            CalculateBonus();
        }
    }
}
