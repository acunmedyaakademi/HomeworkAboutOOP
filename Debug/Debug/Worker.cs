using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Debug
{
    public class Worker
    {
		private string name;
        private int dailyWorkingHours;

        public Worker(string name)

        {
            this.Name = name;
        }

        public string Name
        {
            get { return name;}
            set { name = value;}
        }

        public int DailyWorkingHours
        {
            set {
                if (value != 8)
                {
                    Console.WriteLine("Çalışma saati 8 saatten fazla olamaz.");
                }
                else 
                {
                    DailyWorkingHours = value;
                }

            }
        }

        
    
    }

   
}

