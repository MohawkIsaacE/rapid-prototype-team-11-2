using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public GameObject player;
    private float moveSpeed = 3f;
    private int direction;

    public Rigidbody2D projectile;
    public float projectileSpeed = 4;
    private bool isShootOnCooldown = false;
    private float timerCooldown = 4f;
    private float timer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        timer = timerCooldown;
    }

    void LateUpdate()
    {
        // Look at the player
        rb.transform.up = player.transform.position - rb.transform.position;

        // Shooting timer
        // Code help from https://unityscripting.com/cooldown-timers/
        if (isShootOnCooldown)
        {
            timer -= Time.deltaTime;

            if (timer <= 0)
            {
                timer = timerCooldown;
                isShootOnCooldown = false;
                moveSpeed = 3f;
            }

            if (timer <= 3)
            {
                moveSpeed = 0;
            }
        }
        else
        {
            ShootProjectile();
            // Choose a direction to move; 0 is right, 1 is left
            direction = Random.Range(0, 2);
        }

        MoveEnemy();
    }

    private void MoveEnemy()
    {
        // Move enemy based on direction; 0 is right, 1 is left
        if (direction == 0)
        {
            rb.velocity = transform.right * moveSpeed;
        }
        else if (direction == 1)
        {
            rb.velocity = -transform.right * moveSpeed;
        }
    }

    // Fire a set of projectiles
    // Code help from https://docs.unity3d.com/6000.0/Documentation/Manual/instantiating-prefabs-projectiles.html
    private void ShootProjectile()
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

        // Put shooting on a cooldown
        isShootOnCooldown = true;
    }
}
