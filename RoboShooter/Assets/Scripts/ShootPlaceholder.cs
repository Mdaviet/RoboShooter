using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootPlaceholder : MonoBehaviour
{
    public int speed;
    private Vector2 velocity = new Vector2(1, 1);

    // Start is called before the first frame update
    void Start()
    {
        GameObject player = GameObject.Find("Player");
        Vector2 mouseScreenPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = (mouseScreenPosition - (Vector2)player.transform.position).normalized;
        velocity = velocity * direction * speed * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(velocity);
    }
}
