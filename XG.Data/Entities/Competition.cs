using System.Collections.Generic;

namespace XG.Data.Entities
{
    public class Competition: XgEntity
    {
        public int CompetitionId { get; set; }
        public string Name { get; set; }

        public virtual IEnumerable<CompetitionInstance> CompetitionInstances { get; set; }
    }
}
