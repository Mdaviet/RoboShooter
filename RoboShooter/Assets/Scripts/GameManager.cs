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
        int minutesSurvived = (int)timeSurvived / 60;
        int secondsSurvived = (int)timeSurvived % 60;

        GameOverScreen.Setup(kills, minutesSurvived, secondsSurvived);
        //gameObject.GetComponent<GameOverScreen>().Setup(kills, timeSurvived);

        DeactivateObjects();
    }

    public void Score()
    {
        kills ++;
    }

    void DeactivateObjects()
    {
        GameObject.Find("Player").GetComponent<Movement>().enabled = false;
        GameObject.Find("SpawnManager").GetComponent<SpawnManager>().enabled = false;
        
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        for (int i = 0; i < enemies.Length; i++)
        {
            enemies[i].GetComponent<EnemyPlaceHolder>().enabled = false;
        }
    }
}
