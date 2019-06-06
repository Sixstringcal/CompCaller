using System;
namespace CompCaller
{
    public class Incident
    {
        private Competitor TheCompetitor;

        private string TheIncident;
        public Incident(Competitor TheCompetitor)
        {
            this.TheCompetitor = TheCompetitor;
        }

        public Incident(Competitor TheCompetitor, string TheIncident)
        {
            this.TheIncident = TheIncident;
            this.TheCompetitor = TheCompetitor;
        }

        public void ModifyIncident(string TheIncident)
        {
            this.TheIncident = TheIncident;
        }

        public void ChangeCompetitor(Competitor TheCompetitor)
        {
            this.TheCompetitor = TheCompetitor;
        }

        public override string ToString()
        {
            return TheCompetitor.GetCompetitorName() + " (" + TheCompetitor.GetCompetitorWcaId() + ")" + TheIncident;
        }
    }
}
