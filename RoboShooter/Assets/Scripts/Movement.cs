using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Vector2 speed;
    public GameObject projectile;

    [SerializeField] float fireRate;
    float shotWait = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Rotate Player to mouse
        Vector2 mouseScreenPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = (mouseScreenPosition - (Vector2)transform.position).normalized;
        transform.up = direction;

        // Move Player with keyboard input
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(speed.x * inputX, speed.y * inputY);
        movement *= Time.deltaTime;
        transform.Translate(movement, Space.World);

        // Fire projectile
        shotWait += Time.deltaTime;

        if (Input.GetMouseButton(0) && shotWait >= fireRate)
        {
            Instantiate(projectile, new Vector3(transform.position.x, transform.position.y, 0), Quaternion.identity);
            shotWait = 0f;
        }
    }
}
