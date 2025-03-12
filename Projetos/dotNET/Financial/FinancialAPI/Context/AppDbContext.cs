using FinancialAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FinancialAPI.Context
{
     public class AppDbContext : DbContext
     {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

        public DbSet<Expense> Expenses { get; set; }
     }
}