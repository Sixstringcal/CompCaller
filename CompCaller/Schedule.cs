using System;
using System.Collections.Generic;

namespace CompCaller
{
    public class Schedule
    {
        List<Group> CompSchedule;
        public Schedule()
        {
            CompSchedule = new List<Group>();
        }

        public Schedule(List<Group> CompSchedule)
        {
            this.CompSchedule = CompSchedule;
        }
    }
}
