using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPlaceHolder : MonoBehaviour
{
    public Vector2 speed;
    public Transform player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Face the player
        Vector2 direction = player.position - transform.position;
        transform.up = direction;

        // Move forward perpetually
        Vector2 movement = new Vector2(0, speed.y * 1);
        movement *= Time.deltaTime;
        transform.Translate(movement);
    }
}
