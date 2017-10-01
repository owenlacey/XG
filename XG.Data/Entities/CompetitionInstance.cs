using System.Collections.Generic;
namespace XG.Data.Entities
{
    /// <summary>
    /// Join table for <see cref="Competition"/> and <see cref="Season"/>  
    /// </summary>
    public class CompetitionInstance: XgEntity
    {
        public int CompetitionInstanceId { get; set; }
        public int CompetitionId { get; set; }
        public int SeasonId { get; set; }

        public virtual Competition Competition {get;set;}
        public virtual Season Season { get; set; }

        /// <summary>
        /// The teams taking part in the competition
        /// </summary>
        public virtual IEnumerable<CompetitionParticipation> TeamsTakingPart { get; set; }
    }
}
