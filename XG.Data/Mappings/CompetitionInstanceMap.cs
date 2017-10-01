using XG.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace XG.Data.Mappings
{
	public class CompetitionInstanceMap : IEntityTypeConfiguration<CompetitionInstance>
	{
		public void Configure(EntityTypeBuilder<CompetitionInstance> entityTypeBuilder)
		{
            entityTypeBuilder.ToTable("CompetitionInstances", XgContext.Schema);

            entityTypeBuilder.HasMany(ci => ci.TeamsTakingPart)
                             .WithOne(cp => cp.CompetitionInstance)
                             .HasForeignKey(ci => ci.CompetitionParticipationId);
		}
	}
}
