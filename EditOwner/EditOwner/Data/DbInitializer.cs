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

			// Look for any account.
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
			context.Persons.Add(andrei);

			var sergei = new Person
			{
				FirstName = "Сергей",
				SurName = "Петров",
				Birthday = DateTime.Parse("1980-09-01")
			};
			context.Persons.Add(sergei);

			var bulls = new LegalEntity
			{
				Name = "Рога и копыта",
				Type = "ООО"
			};

			context.LegalEntities.Add(bulls);
			context.SaveChanges();

			var andreiAccount = new Account
			{
				Number= 5678,
				Ammount = 900,
				Person = andrei
			};
			context.Accounts.Add(andreiAccount);

			var bullsAccount = new Account
			{
				Number = 7876,
				Ammount = 100,
				LegalEntity = bulls
			};
			context.Accounts.Add(bullsAccount);

			var sergeiAccount = new Account
			{
				Number = 7656,
				Ammount = 7656,
				Person = sergei
			};
			context.Accounts.Add(sergeiAccount);
			context.SaveChanges();
		}
	}
}
