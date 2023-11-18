using System;
using System.Collections.Generic;

public class Game
{
    public static Game instance = new Game();

    private void Awake()
    {
        if (instance == null)
            instance = this;
    }

    public Dictionary<string, Stock> allStocks = new ();
    public Dictionary<string, Item> allItems;
    public Duck duck = new ();

    public class Stock
    {
        public string name;
        public string id;
        public double price;
        public int remaining_change;
        public int num_owned;
    }
    public class Item
    {
        public int price;
        public bool unlocked;

        int effect;
    }

    public class Duck
    {
        public int hat;
        public int color;
        public int shoes;
        public int clothes;
        public double net_worth;
    }
}