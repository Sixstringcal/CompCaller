using System;
using System.Collections.Generic;

namespace CompCaller
{
    public class Group
    {
        private string Location;
        DateTime StartTime;
        DateTime EndTime;
        int Duration = 15;

        HashSet<Competitor> Competitors;
        HashSet<Competitor> Scramblers;
        HashSet<Competitor> Judges;
        HashSet<Competitor> Runners;


        public Group(string Location)
        {
            this.Location = Location;
            Competitors = new HashSet<Competitor>();
            StartTime = new DateTime();
            EndTime = new DateTime();
        }

        public Group(string Location, HashSet<Competitor> Competitors)
        {
            this.Location = Location;
            this.Competitors = Competitors;
        }

        public Group(string Location, DateTime StartTime)
        {
            this.Location = Location;
            SetStartTime(StartTime);
        }

        public Group(string Location, HashSet<Competitor> Competitors, DateTime StartTime, DateTime EndTime)
        {
            this.Location = Location;
            this.Competitors = Competitors;
            this.StartTime = StartTime;
            this.EndTime = EndTime;
        }

        public Group(string Location, HashSet<Competitor> Competitors, HashSet<Competitor> Scramblers, HashSet<Competitor> Runners, HashSet<Competitor> Judges, DateTime StartTime, int Duration)
        {
            this.Location = Location;
            this.Judges = Judges;
            this.Runners = Runners;
            this.Scramblers = Scramblers;
            this.Competitors = Competitors;
            this.Duration = Duration;
            SetStartTime(StartTime);
        }

        public void SetStartTime(DateTime StartTime)
        {
            this.StartTime = StartTime;
            EndTime = new DateTime(StartTime.Year, StartTime.Month, StartTime.Day, StartTime.Hour, StartTime.Minute, 0);
            EndTime.AddMinutes(15);
        }

        public void ModifyEnd(int Duration)
        {
            this.Duration = Duration;
            EndTime = new DateTime(StartTime.Year, StartTime.Month, StartTime.Day, StartTime.Hour, StartTime.Minute, 0);
            EndTime.AddMinutes(Duration);
        }

        public void Shift(DateTime StartTime)
        {
            this.StartTime = StartTime;
            EndTime = new DateTime(StartTime.Year, StartTime.Month, StartTime.Day, StartTime.Hour, StartTime.Minute, 0);
            EndTime.AddMinutes(Duration);
        }

        public void AddScrambler(Competitor Scrambler) {
            Scramblers.Add(Scrambler);
        }

        public void RemoveScrambler(Competitor Scrambler)
        {
            Scramblers.Remove(Scrambler);
        }

        public void AddJudge(Competitor Judge)
        {
            Judges.Add(Judge);
        }

        public void RemoveJudge(Competitor Judge)
        {
            Judges.Remove(Judge);
        }

        public void AddRunner(Competitor Runner)
        {
            Runners.Add(Runner);
        }

        public void RemoveRunner(Competitor Runner)
        {
            Runners.Remove(Runner);
        }

        public void SetLocation(string Location)
        {
            this.Location = Location;
        }

        public string GetLocation()
        {
            return Location;
        }
    }
}
