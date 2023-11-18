using System;
public class BuySell
{
    public void buy(string stock_tag)
    {
        Game.instance.allStocks[stock_tag].num_owned++;
        Game.instance.duck.net_worth -= Game.instance.allStocks[stock_tag].price;
    }
    public void sell(string stock_tag)
    {
        Game.instance.allStocks[stock_tag].num_owned--;
        Game.instance.duck.net_worth += Game.instance.allStocks[stock_tag].price;
    }
}

