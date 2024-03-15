using ShopManagement.Application.Contracts.CoinPrice;
using ShopManagement.Domain.Coin;
using ShopManagement.Domain.CoinPrice;
using ShopManagement.Domain.Exchange;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.Application
{
    public class CoinPriceApplication : ICoinPriceApplication
    {
        private readonly ICoinRepository _coinRepository;
        private readonly ICoinPriceRepository _coinPriceRepository;
        private readonly IExchangeRepository _exchangeRepository;

        public CoinPriceApplication(ICoinRepository coinRepository, ICoinPriceRepository coinPriceRepository, IExchangeRepository exchangeRepository)
        {
            _coinRepository = coinRepository;
            _coinPriceRepository = coinPriceRepository;
            _exchangeRepository = exchangeRepository;
        }

        public void AddCoinPrices(List<CoinPriceDto> coinPrices)
        {
            foreach (CoinPriceDto coinPrice in coinPrices)
            {
                try
                {
                    var coin = _coinRepository.GetBySymbol(coinPrice.CoinSymbol);
                    var exchange = _exchangeRepository.GetByName(coinPrice.ExchangeName);
                    if (exchange == null)
                    {
                        exchange = BuildExchange(coinPrice);
                        _exchangeRepository.Create(exchange);
                        _exchangeRepository.SaveChanges();
                        exchange = _exchangeRepository.GetByName(coinPrice.ExchangeName);
                    }
                    CoinPrice entity = BuildCoinPrice(coinPrice);
                    entity.CoinID = coin.Id;
                    entity.ExchangeID = exchange.Id;
                    _coinPriceRepository.Create(entity);
                    _coinPriceRepository.SaveChanges();
                }
                catch (Exception)
                {
                    continue;
                }
            }
        }

        private CoinPrice BuildCoinPrice(CoinPriceDto coinPrice)
        {
            return new CoinPrice
            {
                CreationDate = DateTime.Now,
                Date = coinPrice.Date,
                PurchasePrice = coinPrice.PurchasePrice,
                PurchaseVolume = coinPrice.PurchaseVolume,
                SalesPrice = coinPrice.SalesPrice,
                SalesVolume = coinPrice.SalesVolume,
                TransactionFee = coinPrice.TransactionFee,
            };
        }

        private Exchange? BuildExchange(CoinPriceDto coinPrice)
        {
            return new Exchange
            {
                CreationDate = DateTime.Now,
                ExchangeType = (Domain.Exchange.ExchangeType)coinPrice.ExchangeType,
                Name = coinPrice.ExchangeName,
                Url = coinPrice.ExchangeUrl,
            };
        }
    }
}
