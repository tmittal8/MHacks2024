class Game
{
     Stock[] allStocks;
     Item[] allItems;
     Duck duck;

     class Stock{
        public int price;
        public int remaining_change;
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