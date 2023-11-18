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
    public Duck duck;

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
        int hat;
        int color;
        int shoes;
        int clothes;
    }
}