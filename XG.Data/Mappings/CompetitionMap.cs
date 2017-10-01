using XG.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace XG.Data.Mappings
{
	public class CompetitionMap : IEntityTypeConfiguration<Competition>
	{
		public void Configure(EntityTypeBuilder<Competition> entityTypeBuilder)
		{
            entityTypeBuilder.ToTable("Competitions", XgContext.Schema);

            entityTypeBuilder.Property(c => c.Name)
                 .IsRequired();

            entityTypeBuilder.HasMany(c => c.CompetitionInstances)
							 .WithOne(ci => ci.Competition)
                             .HasForeignKey(ci => ci.CompetitionInstanceId);
		}
	}
}
