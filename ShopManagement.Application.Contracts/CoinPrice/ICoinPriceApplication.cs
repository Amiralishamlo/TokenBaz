namespace ShopManagement.Application.Contracts.CoinPrice
{
    public interface ICoinPriceApplication
    {
        void AddCoinPrices(List<CoinPriceDto> coinPrices);
    }
}
