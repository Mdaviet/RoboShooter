using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemy;
    float wait;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        wait += Time.deltaTime;

        if (wait >= 0.5)
        {
            SpawnEnemy();
            wait = 0;
        }
    }

    public void SpawnEnemy()
    {
        Vector2 randomSpawn = new Vector2(Random.Range(-12, 12), Random.Range(-5,5));
        int randomSide = Random.Range(0,2);

        if (randomSide < 1)
        {
            if (randomSpawn.x <= 0) randomSpawn.x -= (12 + randomSpawn.x);
            else randomSpawn.x += (12 - randomSpawn.x);
        }
        else
        {
            if (randomSpawn.y <= 0) randomSpawn.y -= (5 + randomSpawn.y);
            else randomSpawn.y += (5 - randomSpawn.y);
        }

        Instantiate(enemy, new Vector3(randomSpawn.x, randomSpawn.y, 0), Quaternion.identity);
    }
}
