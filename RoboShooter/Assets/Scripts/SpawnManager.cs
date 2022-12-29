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
        /* Vector2 randomSpawn = new Vector2(Random.Range(-24, 24), Random.Range(-10, 10));

         if (randomSpawn.x > -12 && randomSpawn.x <= 0) randomSpawn.x -= 12;

         else if (randomSpawn.x >= 0 && randomSpawn.x < 12) randomSpawn.x += 12;
        */

        Vector2 randomSpawn = new Vector2(Random.Range(-12, 12), Random.Range(-5, 5));

        if (randomSpawn.x < 0) randomSpawn.x -= 12;
        else randomSpawn.x += 12;

        if (randomSpawn.y < 0) randomSpawn.y -= 5;
        else randomSpawn.y += 5;

        Instantiate(enemy, new Vector3(randomSpawn.x, randomSpawn.y, 0), Quaternion.identity);
    }
}
