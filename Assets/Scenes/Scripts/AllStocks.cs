using System;

public class AllStocks
{
    
    public Game.Stock hq = new Game.Stock()
    {
        id = "HQPC",
        name = "HydroQuack Power Corp",
        num_owned = 0,
        price = Math.Round(getInitialPrice(), 2),
        remaining_change = 0
    };
    public Game.Stock qc = new Game.Stock()
    {
        id = "QCS",
        name = "Quack-crete Solutions",
        num_owned = 0,
        price = Math.Round(getInitialPrice(), 2),
        remaining_change = 0
    };
    public Game.Stock bb = new Game.Stock()
    {
        id = "BBDS",
        name = "Bill-to-Bill Data Solutions",
        num_owned = 0,
        price = Math.Round(getInitialPrice(), 2),
        remaining_change = 0
    };
    public Game.Stock gb = new Game.Stock()
    {
        id = "GBI",
        name = "General Bills, Inc.",
        num_owned = 0,
        price = Math.Round(getInitialPrice(), 2),
        remaining_change = 0
    };
    public Game.Stock ge = new Game.Stock()
    {
        id = "GEE",
        name = "Golden Egg Estates",
        num_owned = 0,
        price = Math.Round(getInitialPrice(), 2),
        remaining_change = 0
    };
    public Game.Stock cp = new Game.Stock()
    {
        id = "CPI",
        name = "Clean Ponds, Inc.",
        num_owned = 0,
        price = Math.Round(getInitialPrice(), 2),
        remaining_change = 0
    };
    public Game.Stock gq = new Game.Stock()
    {
        id = "GQI",
        name = "Goldduck Quachs, Inc.",
        num_owned = 0,
        price = Math.Round(getInitialPrice(), 2),
        remaining_change = 0
    };

    public static double getInitialPrice()
    {
        var random = new Random();
        return (10.0*random.NextDouble()) + 10.0;
    }

    void Start()
    {

        Game.instance.allStocks.Add("HQPC", hq);
        Game.instance.allStocks.Add("QCS", qc);
        Game.instance.allStocks.Add("BBDS", bb);
        Game.instance.allStocks.Add("GBI", gb);
        Game.instance.allStocks.Add("GEE", ge);
        Game.instance.allStocks.Add("CPI", cp);
        Game.instance.allStocks.Add("GQI", gq);
    }
}
