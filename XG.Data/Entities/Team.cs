using System.Collections.Generic;
namespace XG.Data.Entities
{
    public class Team: XgEntity
    {
        public int TeamId { get; set; }
        public int Name { get; set; }

        public virtual IEnumerable<CompetitionParticipation> CompetitionParticipations { get; set; }
    }
}
