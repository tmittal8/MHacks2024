using System;
using System.Collections.Generic;

class Game
{
    Dictionary<string, Stock> allStocks;
    Dictionary<string, Item> allItems;
    Duck duck;

     class Stock{
        public int price;
        public int remaining_change;
        public int num_owned;
    }
    class Item{
        public int price;
        public bool unlocked;

        int effect;
    }

    class Duck{
        int hat;
        int color;
        int shoes;
        int clothes;
    }
}