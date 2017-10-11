using EditOwner.Models;
using Microsoft.EntityFrameworkCore;	 

namespace EditOwner.Data
{
    public class AccountContext : DbContext
	{
		public AccountContext(DbContextOptions<AccountContext> options) : base(options)
        {
		}

		public DbSet<Account> Accounts { get; set; }
		public DbSet<Person> Persons { get; set; }
		public DbSet<LegalEntity> LegalEntities { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Account>().ToTable("Account");
			modelBuilder.Entity<Person>().ToTable("Person");
			modelBuilder.Entity<LegalEntity>().ToTable("LegalEntity");
		}
	}	   
}
