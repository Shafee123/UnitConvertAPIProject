using Microsoft.EntityFrameworkCore;

namespace UnitConverterApi.Models
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<UnitCategory> UnitCategories { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<ConversionRate> ConversionRates { get; set; }
        public DbSet<ConversionHistory> ConversionHistories { get; set; }
    }
}
