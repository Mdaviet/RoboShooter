using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemy;
    public GameObject gameManager;
    public AnimationCurve graph = new AnimationCurve();

    float wait;
    int level;
    float spawnRate;

    GameManager gameManagerScript;

    void Awake()
    {
        gameManagerScript = gameManager.GetComponent<GameManager>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        wait += Time.deltaTime;
        level = gameManagerScript.currentLevel;
        spawnRate = Mathf.Pow(1.1f, level);
        graph.AddKey(Time.realtimeSinceStartup, spawnRate);

        if (wait >= (1 / spawnRate))
        {
            SpawnEnemy();
            wait = 0;
        }
    }

    public void SpawnEnemy()
    {
        Vector2 randomSpawn = new Vector2(Random.Range(-12, 12), Random.Range(-6,6));
        int randomSide = Random.Range(0,2);

        if (randomSide < 1)
        {
            if (randomSpawn.x <= 0) randomSpawn.x -= (12 + randomSpawn.x);
            else randomSpawn.x += (12 - randomSpawn.x);
        }
        else
        {
            if (randomSpawn.y <= 0) randomSpawn.y -= (6 + randomSpawn.y);
            else randomSpawn.y += (6 - randomSpawn.y);
        }

        Instantiate(enemy, new Vector3(randomSpawn.x, randomSpawn.y, 0), Quaternion.identity);
    }
}
