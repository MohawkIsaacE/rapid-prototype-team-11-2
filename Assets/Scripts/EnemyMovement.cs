using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public GameObject rb;
    public GameObject player;

    public Rigidbody2D projectile;
    public float projectileSpeed = 4;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Look at the player
        rb.transform.up = player.transform.position - rb.transform.position;

        // Fire a set of projectiles
        // Code help from https://docs.unity3d.com/6000.0/Documentation/Manual/instantiating-prefabs-projectiles.html
        if (Input.GetKeyDown(KeyCode.L))
        {
            // Left
            Rigidbody2D p = Instantiate(projectile, rb.transform.position, rb.transform.rotation);
            p.transform.Rotate(0, 0, -45);
            p.velocity = p.transform.up * projectileSpeed;

            // Straight
            Rigidbody2D p2 = Instantiate(projectile, rb.transform.position, rb.transform.rotation);
            p2.velocity = p2.transform.up * projectileSpeed;

            // Right
            Rigidbody2D p3 = Instantiate(projectile, rb.transform.position, rb.transform.rotation);
            p3.transform.Rotate(0, 0, 45);
            p3.velocity = p3.transform.up * projectileSpeed;
        }
    }
}
