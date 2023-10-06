using System;
namespace EmployeeManger
{
	public class Manager: Employee
		
	{
		private int numberofmanager;
		
        public Manager(string name, string surname, string startingDate, int salary ,int numberofmanager): base(name, surname,  startingDate, salary)
		{
			this.numberofmanager = numberofmanager;

        }



    }
}

