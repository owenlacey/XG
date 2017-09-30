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

            entityTypeBuilder.Property(pt => pt.Name)
                 .IsRequired();
		}
	}
}
