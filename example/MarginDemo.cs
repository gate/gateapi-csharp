using System;
using Io.Gate.GateApi.Api;

namespace GateApiDemo
{
    // The current isolated-margin query flow replaces removed P2P Loan APIs.
    public class MarginDemo
    {
        private readonly RunConfig _runConfig;
        public MarginDemo(RunConfig runConfig) { _runConfig = runConfig; }

        public void Run()
        {
            const string pair = "BTC_USDT";
            var config = ExampleAuth.Create(_runConfig);
            var margin = new MarginUniApi(config);
            var market = margin.GetUniCurrencyPair(pair);
            var capacity = margin.GetUniBorrowable("USDT", pair);
            var loans = margin.ListUniLoans(currencyPair: pair, currency: "USDT", limit: 20);
            var accounts = new MarginApi(config).ListMarginAccounts(pair);
            Console.WriteLine("{0} status={1} borrowable={2}, loan records={3}, accounts={4}",
                pair, market.Status, capacity.Borrowable, loans.Count, accounts.Count);
            // Borrow/repay uses an explicit CreateUniLoan operation. Do not turn a
            // retired lending example into a different financial write automatically.
        }
    }
}
