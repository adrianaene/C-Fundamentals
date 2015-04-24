using System;

namespace MyHomework
{
    public class NegativeLeaveDays : Exception
    {
        public NegativeLeaveDays()
        {
        }

        public NegativeLeaveDays(string message)
            : base(message)
        {

        }
        public NegativeLeaveDays(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
