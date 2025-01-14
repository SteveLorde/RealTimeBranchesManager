using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using RealTimeBranchesManager.Data.Models;

namespace RealTimeBranchesManager.Data;

public class DataContext : DbContext
{
	public DataContext(DbContextOptions<DataContext> options, IConfiguration config)
		: base(options)
	{
	}

	public DbSet<Employee> Employees { get; set; }
	public DbSet<Cashier> Cashiers { get; set; }
	public DbSet<Receipt> Receipts { get; set; }
	public DbSet<Product> Products { get; set; }

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		// optionsBuilder.UseNpgsql(_config["DatabaseConnectionLink"]);
	}
}