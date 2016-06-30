using System;
using SQLite;
namespace InvestmentDataSampleApp
{
	public class OpportunityModel
	{
		[PrimaryKey]
		[AutoIncrement]
		[Unique]
		public int ID { get; set; }

		public string Topic { get; set; }

		public string Company { get; set; }

		public string DBA { get; set; }

		public long LeaseAmount { get; set; }

		public string LeaseAmountAsCurrency
		{
			get { return $"{LeaseAmount:C}"; }
		}

		public SalesStages SalesStage { get; set; }

		public string Owner { get; set; }

		public DateTime DateCreated { get; set; }

		public OpportunityModel()
		{
			Topic = "";
			Company = "";
			DBA = "";
			LeaseAmount = 0;
			SalesStage = SalesStages.New;
			Owner = "";
			DateCreated = DateTime.Now;
		}

	}

	public enum SalesStages { New, Pending, Closed }
}

