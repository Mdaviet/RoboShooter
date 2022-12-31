using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameOverScreen GameOverScreen;

    int kills = 0;
    float timeSurvived = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeSurvived += Time.deltaTime;
    }

    public void GameOver()
    {
        GameOverScreen.Setup(kills, timeSurvived);
        //gameObject.GetComponent<GameOverScreen>().Setup(kills, timeSurvived);
    }

    public void Score()
    {
        kills ++;
    }
}
