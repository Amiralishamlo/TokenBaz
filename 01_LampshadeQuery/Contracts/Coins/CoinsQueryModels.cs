namespace _01_LampshadeQuery.Contracts.Coins
{
    public class CoinsQueryModels
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public string Link { get; set; }
        public string ImageAddress { get; set; }
        public string PriceInToman { get; set; }
        public string PriceInDollar { get; set; }
        public string LastDaysPriceChangePercent { get; set; }
        public string TotalMarketValue { get; set; }
        public string LastDaysTradingVolume { get; set; }
    }
}
