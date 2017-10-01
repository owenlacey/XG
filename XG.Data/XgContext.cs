using XG.Data.Entities;
using XG.Data.Extensions;
using XG.Data.Mappings;
using Microsoft.EntityFrameworkCore;

namespace XG.Data
{
    public class XgContext: DbContext
    {
        public static string Schema = "XG";

        public XgContext(DbContextOptions<XgContext> options) : base(options)
        {
		}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.HasDefaultSchema(Schema);
            modelBuilder.UseEntityTypeConfiguration();

			modelBuilder.ApplyConfiguration(new CompetitionMap());
            modelBuilder.ApplyConfiguration(new MatchMap());
			modelBuilder.ApplyConfiguration(new SeasonMap());
			modelBuilder.ApplyConfiguration(new TeamMap());
            modelBuilder.ApplyConfiguration(new CompetitionInstanceMap());

			base.OnModelCreating(modelBuilder);
        }

		public DbSet<Match> Matches { get; set; }
		public DbSet<Season> Seasons { get; set; }
		public DbSet<Competition> Competitions { get; set; }
		public DbSet<Team> Teams { get; set; }

        //join tables
        public DbSet<CompetitionInstance> CompetitionInstances { get; set; }
        public DbSet<CompetitionParticipation> TeamParticipations { get; set; }
	}
}
