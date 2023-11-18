using UnityEngine;
using static UnityEngine.JsonUtility;

public class PlayerState : MonoBehaviour
{
    public string playerName;
    public int lives;
    public float health;

    public void Load(string savedData)
    {
        JsonUtility.FromJsonOverwrite(savedData, this);
    }

    // Given JSON input:
    // {"lives":3, "health":0.8}
    // the Load function will change the object on which it is called such that
    // lives == 3 and health == 0.8
    // the 'playerName' field will be left unchanged
}

public class Parser : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string jsonString = "{\"playerName\": \"Joe\", \"lives\":3, \"health\":0.8}";
        PlayerState info = new PlayerState();
        info.Load(jsonString);
        Debug.Log(info.playerName);
        Debug.Log(info.lives);
        Debug.Log(info.health);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
