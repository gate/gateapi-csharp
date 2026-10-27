using System;
using System.Globalization;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Model;

namespace GateApiDemo
{
    // Current futures quantities are decimal strings, not integer SDK properties.
    public class FuturesDemo
    {
        private readonly RunConfig _runConfig;
        public FuturesDemo(RunConfig runConfig) { _runConfig = runConfig; }

        public void Run()
        {
            const string settle = "usdt", contract = "BTC_USDT", leverage = "3";
            var config = ExampleAuth.Create(_runConfig);
            var api = new FuturesApi(config);
            // A failed position query must propagate before any trading write.
            var position = api.GetPosition(settle, contract);
            var market = api.GetFuturesContract(settle, contract);
            var tickers = api.ListFuturesTickers(settle, contract);
            if (tickers.Count == 0) throw new InvalidOperationException("Missing futures ticker");
            decimal size = Math.Max(Positive(market.OrderSizeMin, "minimum size"), 10m);
            if (decimal.Parse(position.Size, CultureInfo.InvariantCulture) < 0) size = -size;
            decimal margin = Math.Abs(size) * Positive(tickers[0].Last, "last price") *
                Positive(market.QuantoMultiplier, "contract multiplier") / 3m * 1.1m;
            decimal available = decimal.Parse(api.ListFuturesAccounts(settle).Available, CultureInfo.InvariantCulture);
            if (available < 0) throw new InvalidOperationException("Negative available collateral");
            if (available < margin)
            {
                if (_runConfig.UseTestNet)
                    throw new InvalidOperationException("Fund testnet collateral before running this example");
                // Transfer only the shortfall, using the same explicit settlement currency.
                new WalletApi(config).Transfer(new Transfer(currency: settle.ToUpperInvariant(),
                    amount: (margin - available).ToString(CultureInfo.InvariantCulture))
                    { From = Transfer.FromEnum.Spot, To = Transfer.ToEnum.Futures, Settle = settle });
            }
            api.UpdatePositionLeverage(settle, contract, leverage);
            // Preserve the contract filter after xGateExptime was inserted before it.
            api.CancelFuturesOrders(settle, contract: contract);
            var created = api.CreateFuturesOrder(settle, new FuturesOrder(contract)
                { Size = size.ToString(CultureInfo.InvariantCulture), Price = "0", Tif = FuturesOrder.TifEnum.Ioc });
            Console.WriteLine("Futures order {0} status={1} size={2}", created.Id, created.Status, created.Size);
            if (created.Status == FuturesOrder.StatusEnum.Open)
                api.CancelFuturesOrder(settle, created.Id.ToString());
            // Do not retry writes automatically. Inspect history if any call fails.
        }

        private static decimal Positive(string value, string field)
        {
            decimal result = decimal.Parse(value, CultureInfo.InvariantCulture);
            if (result <= 0) throw new InvalidOperationException(field + " must be positive");
            return result;
        }
    }
}
