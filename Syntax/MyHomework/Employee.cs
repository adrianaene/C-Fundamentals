using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHomework
{
    class Employee : Person
    {
        public DateTime dateOfEmployment;
        public double salary;
        public int availableDaysOff;
        List<Leave> concedii = new List<Leave>();


        public Employee(string lastName, string firstName, DateTime dateOfBirth, DateTime dateOfEmployment, double salary, int availableDaysOff)
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
            {
                throw new NegativeLeaveDays("Numarul de zile ramase nu poate fi mai mare decat durata concediului");
            }

            if (!IsAnotherLeaveApproved(leave))
                throw new NegativeLeaveDays("Exista un alt concediu aprobat in perioada in care se doreste aprobarea concediului curent");

            SubstractDays(leave.duration);
            leave.employee = this;
            this.concedii.Add(leave);
        }

        public void PrintDaysOff(int year)
        {

            foreach (var leave in this.concedii)
            {
                if (leave.startingDate.Year.Equals(year))
                {
                    Console.WriteLine(leave.ToString());
                }
            }
        }

        public bool IsAnotherLeaveApproved(Leave currentLeave)
        {

            // verifica daca mai exista cel putin un alt concediu aprobat in perioada in care

            // se doreste aprobarea concediului curent
            foreach(var leave in this.concedii)
            {
                if(currentLeave.startingDate <=  leave.startingDate.AddDays(leave.duration) 
                    && currentLeave.startingDate >= leave.startingDate)
                return
                    false;
            }

            return true;

        }

    }
}

