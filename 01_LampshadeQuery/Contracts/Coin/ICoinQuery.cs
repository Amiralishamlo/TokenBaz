namespace _01_LampshadeQuery.Contracts.Coin
{
	public interface ICoinQuery
	{
		List<CoinQueryModels> GetCoin(long id);
		CoinParentQueryModels GetCoinParents(long id);
	}
}
