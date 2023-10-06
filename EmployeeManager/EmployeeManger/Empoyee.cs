using System;
namespace EmployeeManger
{
    public class Employee
    {
        private string name;
        private string surname;
        private string startingDate;
        private int salary;

        public Employee(string name, string surname, string startingDate, int salary)
        {
            this.name = name;
            this.surname = surname;
            this.startingDate = startingDate;
            this.salary = salary;
        }

        public string Name
        {
            get {return name;}
            set {name = value;}
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public string StartingDate
        {
            get { return startingDate; }
            set { startingDate = value; }
        }

        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }


 
    }
}

