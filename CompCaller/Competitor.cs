using System;
using System.Collections.Generic;

namespace CompCaller
{
    public class Competitor
    {
        private string Name;
        private string WcaId;

        private List<Incident> Incidents;

        public Competitor(string Name)
        {
            Incidents = new List<Incident>();
            this.Name = Name;
            WcaId = "New Competitor";
        }

        public Competitor(string Name, List<Incident> Incidents)
        {
            this.Incidents = Incidents;
            this.Name = Name;
            WcaId = "New Competitor";
        }

        public Competitor(string Name, string WcaId)
        {
            Incidents = new List<Incident>();
            this.Name = Name;
            this.WcaId = WcaId;
        }

        public Competitor(string Name, string WcaId, List<Incident> Incidents)
        {
            this.Incidents = Incidents;
            this.Name = Name;
            this.WcaId = WcaId;

        }


        /**
         * Leave irrelevant variables as null or < 0.     
         */
        public void AddIncident(string Event, int Solve, int GroupCompeting, string Issue)
        {
            string FullIncident = "";
            if (Event != null)
            {
                FullIncident += Event + " ";
            }
            if(Solve < 0)
            {
                FullIncident += "Solve " + Solve + " ";
            }
            if (GroupCompeting < 0)
            {
                FullIncident += "Group " + GroupCompeting + ":";
            }
            FullIncident += Issue;
            Incidents.Add(new Incident(this, FullIncident));
        }

        public string GetCompetitorName()
        {
            return Name;
        }

        public string GetCompetitorWcaId()
        {
            return WcaId;
        }


        public List<Incident> GetIncidents() {
            return Incidents;
        }



    }


}
