using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHomework
{
    public enum LeaveType
    {
        Medical,
        Holiday,
        Other

    };

    class Leave
    {
        public DateTime startingDate;
        public int duration;
        public LeaveType leaveType;
        public Employee employee;

        public Leave(DateTime startingDate, int duration, LeaveType leaveType)
        {
            this.startingDate = startingDate;
            this.duration = duration;
            this.leaveType = leaveType;
        }

        public override string ToString()
        {
            return
                string.Format("Start date: " + this.startingDate.ToShortDateString() + " \nDuration: " + this.duration + " \nLeaveType: " + this.leaveType);

        }
    }
}
