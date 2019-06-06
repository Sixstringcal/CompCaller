using System;
using System.Collections.Generic;

namespace CompCaller
{
    public class Competition
    {
        private string Location;
        private List<Competitor> Delegates;
        private List<Competitor> Organizers;
        private List<Competitor> Competitors;
        private string Name;
        private Schedule CompetitionSchedule;

        public Competition(string Name, string Location, List<Competitor> Delegates, List<Competitor> Organizers, List<Competitor> Competitors, Schedule CompetitionSchedule)
        {
            this.CompetitionSchedule = CompetitionSchedule;
            this.Location = Location;
            this.Delegates = Delegates;
            this.Organizers = Organizers;
            this.Competitors = Competitors;
            this.Name = Name;
        }

        public void SetName(string NewName)
        {
            Name = NewName;
        }

        public string GetName()
        {
            return Name;
        }

        public void SetLocation(string NewLocation)
        {
            Location = NewLocation;
        }

        public string GetLocation()
        {
            return Location;
        }

        public void AddCompetitor(Competitor NewCompetitor)
        {
            Competitors.Add(NewCompetitor);
        }

        public List<Competitor> GetCompetitors()
        {
            return Competitors;
        }

        public List<Competitor> GetDelegates()
        {
            return Delegates;
        }

        public void AddOrganizer(Competitor NewOrganizer)
        {
            Organizers.Add(NewOrganizer);
        }

        public void AddDelegate(Competitor NewDelegate)
        {
            Delegates.Add(NewDelegate);
        }

        public List<Competitor> GetOrganizers()
        {
            return Organizers;
        }

       

        public Competition(string Name, string Location)
        {
            this.Location = Location;
            this.Name = Name;
        }
    }
}
