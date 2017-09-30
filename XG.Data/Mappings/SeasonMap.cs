using XG.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace XG.Data.Mappings
{
	public class SeasonMap : IEntityTypeConfiguration<Season>
	{
		public void Configure(EntityTypeBuilder<Season> entityTypeBuilder)
		{
			entityTypeBuilder.ToTable("Seasons", XgContext.Schema);

			entityTypeBuilder.Property(pt => pt.Name)
				 .IsRequired();
		}
	}
}
