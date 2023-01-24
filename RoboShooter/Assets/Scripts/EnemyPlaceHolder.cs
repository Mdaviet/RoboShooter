using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPlaceHolder : MonoBehaviour
{
    public Vector2 speed;
    GameObject player;
    UnityEngine.Rendering.Universal.Light2D spawnIndicator;
    
    [SerializeField] float lifeTime;
    float timeAlive = 0f;

    void Awake()
    {
        player = FindObjectOfType<PlayerCollisions>().gameObject;
        spawnIndicator = gameObject.GetComponent<UnityEngine.Rendering.Universal.Light2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Spawn flash
        if (timeAlive > 0.15f) spawnIndicator.enabled = false;

        // Face the player
        Vector2 direction = player.transform.position - transform.position;
        transform.up = direction;

        // Move forward perpetually
        Vector2 movement = new Vector2(0, speed.y * 1);
        movement *= Time.deltaTime;
        transform.Translate(movement);

        // Declutter
        timeAlive += Time.deltaTime;
        if (timeAlive > lifeTime) Destroy(gameObject);
    }
}
