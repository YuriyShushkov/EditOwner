using System.ComponentModel.DataAnnotations.Schema;

namespace EditOwner.Models
{
    public class Account
    {
		public int ID { get; set; }

		public int Number { get; set; }

		[Column(TypeName = "money")]
		public decimal Ammount { get; set; }

		public int? PersonID { get; set; }
		public Person Person { get; set; }

		public int? LegalEntityID { get; set; }
		public LegalEntity LegalEntity { get; set; }

		[NotMapped]
		public string OwnerType
		{
			get
			{
				return Person == null ? (LegalEntity == null ? "Не задан" : "юр") : "физ";
			}
		}

		[NotMapped]
		public string OwnerName
		{
			get
			{
				return Person == null ? (LegalEntity == null ? "Не задан" : LegalEntity.Name) : $"{Person.SurName} {Person.FirstName}";
			}
		}
	}
}
