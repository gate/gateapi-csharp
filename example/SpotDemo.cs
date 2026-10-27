using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace GateApiDemo
{
    public class SpotDemo
    {
        private readonly RunConfig _runConfig;

        public SpotDemo(RunConfig runConfig)
        {
            this._runConfig = runConfig;
        }

        public void Run()
        {
            const string currencyPair = "GT_USDT";
            string currency = currencyPair.Split('_')[1];

            Configuration config = ExampleAuth.Create(_runConfig);
            SpotApi spotApi = new SpotApi(config);

            CurrencyPair pair = spotApi.GetCurrencyPair(currencyPair);
            Console.WriteLine("testing against currency pair: {0}", currencyPair);
            string minAmount = pair.MinBaseAmount;

            List<Ticker> tickers = spotApi.ListTickers(currencyPair);
            Debug.Assert(tickers.Count == 1);
            string lastPrice = tickers[0].Last;
            Debug.Assert(lastPrice != null);

            decimal orderAmount = decimal.Parse(minAmount, CultureInfo.InvariantCulture) * 2;
            List<SpotAccount> accounts = spotApi.ListSpotAccounts(currency);
            Debug.Assert(accounts.Count == 1);
            decimal available = decimal.Parse(accounts[0].Available, CultureInfo.InvariantCulture);
            Console.WriteLine("Account available: {0} {1}", available, currency);
            // Quote balance must cover base amount times quote price.
            decimal price = decimal.Parse(lastPrice, CultureInfo.InvariantCulture);
            if (orderAmount <= 0 || price <= 0 || available < 0)
                throw new InvalidOperationException("Invalid market amount, price or available balance");
            if (available.CompareTo(orderAmount * price) < 0)
            {
                Console.Error.WriteLine("Account balance not enough");
                return;
            }

            Order order = new Order(currencyPair: currencyPair, amount: orderAmount.ToString(CultureInfo.InvariantCulture), price: lastPrice)
            {
                Account = "spot",
                Side = Order.SideEnum.Buy,
            };
            Console.WriteLine("place a spot {0} order in {1} with amount {2} and price {3}", order.Side,
                order.CurrencyPair, order.Amount, order.Price);
            Order created = spotApi.CreateOrder(order);
            Console.WriteLine("order created with id {0}, status {1}", created.Id, created.Status);

            if (Order.StatusEnum.Open.Equals(created.Status))
            {
                Order orderResult = spotApi.GetOrder(created.Id, created.CurrencyPair);
                Console.WriteLine("order {0} filled: {1}, left: {2}", orderResult.Id, orderResult.FilledTotal, orderResult.Left);

                Order result = spotApi.CancelOrder(orderResult.Id, orderResult.CurrencyPair);
                if (Order.StatusEnum.Cancelled.Equals(result.Status))
                {
                    Console.WriteLine("order {0} cancelled", result.Id);
                }
            }
            else
            {
                List<Trade> trades = spotApi.ListMyTrades(currencyPair, orderId: created.Id);
                Debug.Assert(trades.Count > 0);
                foreach (Trade t in trades)
                {
                    Console.WriteLine("order {0} filled {1} with price {2}", t.OrderId, t.Amount, t.Price);
                }
            }
        }
    }
}