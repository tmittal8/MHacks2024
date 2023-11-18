using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StockButtonScript : MonoBehaviour
{
    public string stock_tag;
    public TMP_Text num_stocks;
    public TMP_Text price;
    public TMP_Text stock_name;
    public TMP_Text id;
    public Sprite upOrDown;
    public Game.Stock s = new Game.Stock() {
            id = "HQPC",
            name = "HydroQuack Power Corp",
            num_owned = 0,
            price = 15.92,
            remaining_change = 0
        };

void Start()
    {

        Game.instance.allStocks.Add("HQPC", s);
        stock_name.text = Game.instance.allStocks[stock_tag].name.ToString();
        id.text = stock_tag;
    }

    // Update is called once per frame
    void Update()
    {
        num_stocks.text = Game.instance.allStocks[stock_tag].num_owned.ToString();
        price.text = "$" + Game.instance.allStocks[stock_tag].price.ToString();
    }
}
