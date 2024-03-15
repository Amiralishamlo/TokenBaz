namespace _01_LampshadeQuery.Contracts.Coins
{
    public class CoinsQueryModels
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public string Link { get; set; }
        public string ImageAddress { get; set; }
        public decimal PriceInToman { get; set; }
        public decimal PriceInDollar { get; set; }
        public decimal LastDaysPriceChangePercent { get; set; }
        public long TotalMarketValue { get; set; }
        public long LastDaysTradingVolume { get; set; }
    }
}
