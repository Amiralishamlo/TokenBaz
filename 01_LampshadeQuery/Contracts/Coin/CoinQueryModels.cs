namespace _01_LampshadeQuery.Contracts.Coin
{
	public class CoinQueryModels
	{
		public long PurchasePrice { get; set; }
		public decimal? PurchaseVolume { get; set; }
		public long SalesPrice { get; set; }
		public decimal? SalesVolume { get; set; }
		public string TransactionFee { get; set; }
		public string Name { get; set; }
		public string Url { get; set; }
	}
}
