using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            // in main am creat un angajat
            // am adaugat un concediu de 5 zile si apoi unul care arunca o exceptie

            Employee angajat = new Employee("Ene", "Adriana", "9.05.1993", "9.07.2015", 2000, 21);
            Leave leave1 = new Leave("9.08.2015", 5, "Holiday");
            Leave leave2 = new Leave("9.09.2015", 25, "Medical");
            angajat.DisplayInfo();
            angajat.AddNewLeave(leave1);
            angajat.AddNewLeave(leave2);
            Console.WriteLine("Concedii: ");
            angajat.PrintDaysOff();
            Console.Read();

        }
    }
}
