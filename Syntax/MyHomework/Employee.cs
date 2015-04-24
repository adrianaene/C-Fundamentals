using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHomework
{
    class Employee : Person
    {
        public string dateOfEmployment;
        public double salary;
        public int availableDaysOff;
        List<Leave> concedii = new List<Leave>();


        public Employee(string lastName, string firstName, string dateOfBirth, string dateOfEmployment, double salary, int availableDaysOff)
            : base(lastName, firstName, dateOfBirth)
        {
            this.salary = salary;
            this.dateOfEmployment = dateOfEmployment;
            this.availableDaysOff = availableDaysOff;
        }

        public void DisplayInfo()
        {
            //Nume, Prenume,Salariu, Numar zile disonibile
            Console.WriteLine("Nume: " + this.lastName);
            Console.WriteLine("Prenume: " + this.firstName);
            Console.WriteLine("Salariu: " + this.salary);
            Console.WriteLine("Zile libere: " + this.availableDaysOff);
        }

        private void SubstractDays(int nrZile)
        {
            this.availableDaysOff -= nrZile;
        }

        public void AddNewLeave(Leave leave)
        {
            if (this.availableDaysOff < leave.duration)
                throw new NegativeLeaveDays("Numarul de zile ramase nu poate fi mai mare decat durata concediului");
            SubstractDays(leave.duration);
            leave.employee = this;
            this.concedii.Add(leave);
        }

        public void PrintDaysOff()
        {
            foreach (Leave leave in this.concedii)
                if (leave.startingDate.Contains("2015"))
                    leave.toString();
        }

    }
}

