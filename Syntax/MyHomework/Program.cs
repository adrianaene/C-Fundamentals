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

            var angajat = new Employee("Ene", "Adriana", new DateTime(1993, 05, 09), new DateTime(2015, 06, 09), 2000, 21);
            var leave1 = new Leave(new DateTime(2015, 09, 09), 5, LeaveType.Holiday);
            var leave2 = new Leave(new DateTime(2015, 10, 10), 5, LeaveType.Medical);
            var leave3 = new Leave(new DateTime(2015, 10, 12), 5, LeaveType.Medical);
            angajat.DisplayInfo();
            angajat.AddNewLeave(leave1);
            angajat.AddNewLeave(leave2);
            angajat.AddNewLeave(leave3);
            Console.WriteLine("Concedii: ");
            angajat.PrintDaysOff(2015);
            Console.Read();

        }
    }
}
