using System.Collections.Generic;

namespace XG.Data.Entities
{
    public class Season : XgEntity
    {
        public int SeasonId { get; set; }
        public string Name { get; set; }

        public virtual IEnumerable<CompetitionInstance> CompetitionInstances {get;set;}
    }
}
