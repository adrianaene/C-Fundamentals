using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHomework
{
    class Leave
    {
        public string startingDate;
        public int duration;
        public string leaveType;
        public Employee employee;

        public Leave(string startingDate, int duration, string leaveType){
            this.startingDate = startingDate;
            this.duration = duration;
            this.leaveType = leaveType;
        }

        public void toString()
        {
            Console.WriteLine("Start date: " + startingDate);
            Console.WriteLine("Duration: " + duration);
            Console.WriteLine("LeaveType: " + leaveType);
        }
    }
}
