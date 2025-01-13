using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace RealTimeBranchesManager.Data;

public class DataContext : DbContext
{
	public DataContext(DbContextOptions<DataContext> options, IConfiguration config)
		: base(options)
	{
	}

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		// optionsBuilder.UseNpgsql(_config["DatabaseConnectionLink"]);
	}
}