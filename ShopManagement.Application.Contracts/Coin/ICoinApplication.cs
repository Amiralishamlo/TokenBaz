using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.Application.Contracts.Coin
{
    public interface ICoinApplication
    {
        void AddCoins(List<CoinDto> coins);
        List<CoinDto> GetCoins();
    }
}
