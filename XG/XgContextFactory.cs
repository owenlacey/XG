using System.IO;
using XG.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace XG
{
    public class XgContextFactory : IDesignTimeDbContextFactory<XgContext>
	{
		public XgContext CreateDbContext(string[] args)
		{
			IConfigurationRoot configuration = new ConfigurationBuilder()
				.SetBasePath(Directory.GetCurrentDirectory())
				.AddJsonFile("appsettings.json")
				.Build();

			var builder = new DbContextOptionsBuilder<XgContext>();

			var connectionString = configuration.GetConnectionString("DefaultConnection");

			builder.UseSqlServer(connectionString);

			return new XgContext(builder.Options);
		}
	}
}
