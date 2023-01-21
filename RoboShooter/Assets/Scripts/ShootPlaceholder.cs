using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootPlaceholder : MonoBehaviour
{
    public int speed;
    [SerializeField] int lifeTime;

    private Vector2 velocity = new Vector2(1, 1);
    float timeAlive = 0f;

    // Start is called before the first frame update
    void Start()
    {
        GameObject player = GameObject.Find("Player");
        Vector2 mouseScreenPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = (mouseScreenPosition - (Vector2)player.transform.position).normalized;
        velocity = velocity * direction * speed;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(velocity * Time.deltaTime);

        timeAlive += Time.deltaTime;
        if (timeAlive > lifeTime) Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Enemy")
        {
            Destroy(collider.gameObject);
            Destroy(gameObject);
            
            GameManager manager = GameObject.Find("Game Manager").GetComponent<GameManager>();
            manager.Score();
        }
    }
}
