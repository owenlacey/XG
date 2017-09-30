using XG.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace XG.Data.Mappings
{
	public class TeamMap : IEntityTypeConfiguration<Team>
	{
		public void Configure(EntityTypeBuilder<Team> entityTypeBuilder)
		{
			entityTypeBuilder.ToTable("Teams", XgContext.Schema);

			entityTypeBuilder.Property(pt => pt.Name)
				 .IsRequired();
		}
    }
}
