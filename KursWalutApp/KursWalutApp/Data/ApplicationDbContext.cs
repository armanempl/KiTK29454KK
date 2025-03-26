using KursWalutApp.Models;
using Microsoft.EntityFrameworkCore;

namespace KursWalutApp.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<ExchangeRateModel> ExchangeRates { get; set; }
    }
}
