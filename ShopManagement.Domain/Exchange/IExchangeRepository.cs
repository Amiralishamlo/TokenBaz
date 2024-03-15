using _0_Framework.Domain;

namespace ShopManagement.Domain.Exchange
{
    public interface IExchangeRepository : IRepository<long, Exchange>
    {
        Exchange GetByName(string name);
    }
}
