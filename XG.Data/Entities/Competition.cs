
namespace XG.Data.Entities
{
    public class Competition: XgEntity
    {
        public int CompetitionId { get; set; }
        public string Name { get; set; }
        public int SeasonId { get; set; }

        public virtual Season Season { get; set; }
    }
}
