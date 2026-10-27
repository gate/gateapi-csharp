# Example Application

This is a demo application using `Io.Gate.GateApi` to show how Gate APIv4 works. 
Instead of running it, it is recommended to read the source code to get a general idea of
how this SDK is used. However, you can modify this code directly to implement your own logic.

## Build

The SDK library remains `netstandard2.0`; the console example uses .NET 6.
From the generated SDK root, run:

```bash
# Compile the adjacent SDK and the real example sources without executing trading code.
dotnet build example/GateApiDemo.csproj
```

The example project uses a project reference, so it follows this candidate SDK's
API and dependency versions instead of an old copied DLL. Public examples share
the SDK's Key/Secret initializer. The internal SDK deliberately refuses this
public CLI credential flow; configure its existing trusted user-ID authentication
inside a trusted service instead. A public API key is never used as a user ID.

## Run

**READ THIS BEFORE YOU RUN ANYTHING**

**This application is shown for demo only. It will try to use your input API key and secret to
place/cancel orders and transfer collateral in the spot/futures commands. Make sure you know exactly what it does before running it.**

> Examples shown below use `dotnet run` to run the application without explicit building.
> You can change to `dotnet /path/to/your/demo/dll` after `dotnet build` to avoid building every time
> before running.

```bash
# run futures demo against TestNet
dotnet run futures -k <YOUR_TESTNET_API_KEY> -s <YOUR_TESTNET_API_SECRET> -u fx-api-testnet.gateio.ws

# run futures demo against real trading
dotnet run futures -k <YOUR_API_KEY> -s <YOUR_API_SECRET>

# run spot demo
dotnet run spot -k <YOUR_API_KEY> -s <YOUR_API_SECRET>

# run margin demo
dotnet run margin -k <YOUR_API_KEY> -s <YOUR_API_SECRET>
```

The margin command is read-only and shows current MarginUni market, capacity,
loan and balance queries. Legacy P2P lending/Loan endpoints were removed; this
example does not replace them with an automatic borrowing or repayment workflow.
Position/market lookup errors propagate before futures writes. Financial writes
are never retried automatically; inspect history after any uncertain result.
