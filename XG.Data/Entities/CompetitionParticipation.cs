using System;
namespace XG.Data.Entities
{
	/// <summary>
	/// Join table for <see cref="Team"/> and <see cref="CompetitionInstance"/>  
	/// </summary>
	public class CompetitionParticipation
    {
        public int CompetitionParticipationId { get; set; }
        public int TeamId { get; set; }
        public int CompetitionInstanceId { get; set; }

        public virtual Team Team { get; set; }
        public virtual CompetitionInstance CompetitionInstance { get; set; }
    }
}
