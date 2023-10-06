

namespace EmployeeManger
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Employee emp1 = new Employee("Batuhan", "Dağlı", "2020.12.22", 20000);
            Employee emp2 = new Employee("Mehmet", "Ceyhan", "2019.08.22", 21000);
            Manager man1 = new Manager("Tuğçe", "Ceyhan", "2015.02.22", 50000, 2);
        }
    }
}