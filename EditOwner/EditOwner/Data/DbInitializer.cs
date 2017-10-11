using EditOwner.Models;
using System;					
using System.Linq;	   

namespace EditOwner.Data
{
	public static class DbInitializer
	{
		public static void Initialize(AccountContext context)
		{
			context.Database.EnsureCreated();

			// Look for any students.
			if (context.Accounts.Any())
			{
				return;   // DB has been seeded
			}

			var andrei = new Person
			{
				FirstName = "Андрей",
				SurName = "Иванов",
				Birthday = DateTime.Parse("2010-09-01")
			};

			var sergei = new Person
			{
				FirstName = "Сергей",
				SurName = "Петров",
				Birthday = DateTime.Parse("1980-09-01")
			};

			var bulls = new LegalEntity
			{
				Name = "Рога и копыта",
				Type = "ООО"
			};
		}
	}
}
