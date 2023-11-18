using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newsfeed : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Game.instance.news = new string[5];
    }

    // Update is called once per frame
    float yet;
    const float interval = 10.0f;
    
    void Update()
    {
        yet += Time.deltaTime;
        
        if (yet >= interval)
        {
            yet -= interval;
        
            updateNews();
        }
    }


    void updateNews(){
        string[] news = {"In a shocking incident, the ducks at Stock Pond started quacking in unison, producing a bizarre 'Thunderquack'. This peculiar phenomenon somehow generated an unsuspected power surge in the area, interestingly noted by local energy analysts",
                        "In an unexpected spectacle, the ducks at Stock Pond broke out into a delightful 'Quack Symphony'. The harmonious display of quacking in sync has taken the internet by storm, sparking discussions of a potential 'Duck Mozart'",
                        "A parade of ducklings around the Stock Pond, led by the oldest duck, took place this morning. The unusual event has caught attention and warmed the hearts of many, becoming a viral sensation",
                        "A delightful scene unfolded at Stock Pond when the resident ducks spontaneously started parading around the pond akin to a fashion show. The charming spectacle has become a trending topic on social media, adding vibrancy to the pond"
                        };
        int[,] pricechanges = {{70,0,30,10,-10,0,30},
                                    {0,10,20,5,20,10,15},
                                    {0,0,20,10,15,20,10},
                                    {0,-10,30,0,20,10,0}};

        string[] stockNames = {"HQPC", "QCS", "BBDS", "GB", "GEE", "CPI", "GDQI"};

        var rnd = new Random();
        int random_news  = rnd.Next(0, 5);

        //update newsfeed
        for(int i = 1; i < 5; i++){
            Game.instance.news[i] = Game.instance.news[i-1];
        }

        Game.instance.news[0] = news[random_news];

        //update stock prices based on news
        for(int i = 0; i < 7; i++){
            Game.instance.allStocks[stockNames[i]] = Game.instance.allStocks[stockNames[i]] + pricechanges[random_news][i];
        }

    }
}
