using XG.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace XG.Data.Mappings
{
	public class MatchMap : IEntityTypeConfiguration<Match>
	{
		public void Configure(EntityTypeBuilder<Match> entityTypeBuilder)
		{
			entityTypeBuilder.ToTable("Matches", XgContext.Schema);
		}
	}
}
