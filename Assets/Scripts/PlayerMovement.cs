using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEngine.GraphicsBuffer;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    private float moveSpeed = 3;
    public Camera cam;
    private bool isAlive;

    // Start is called before the first frame update
    void Start()
    {
        isAlive = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (isAlive)
        {
            // Movement
            float moveInputX = Input.GetAxis("Horizontal");
            float moveInputY = Input.GetAxis("Vertical");

            rb.velocity = new Vector2(moveInputX * moveSpeed, moveInputY * moveSpeed);

            // Player teleport/dash in the direction they are looking
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.transform.position += transform.up * 5f;
            }

            // Camera follow player
            cam.transform.position = new Vector3(rb.transform.position.x, rb.transform.position.y, cam.transform.position.z);

            // Look at mouse (copied from an answer at https://discussions.unity.com/t/2d-look-at-mouse-position-z-rotation-c/117860/2)
            // convert mouse position into world coordinates
            Vector2 mouseScreenPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            // get direction you want to point at
            Vector2 direction = (mouseScreenPosition - (Vector2)transform.position).normalized;

            // set vector of transform directly
            transform.up = direction;
        }
        else
        {
            // Reset game
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(0);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Projectile" || collision.gameObject.tag == "Beam")
        {
            gameObject.GetComponent<Renderer>().enabled = false;
            isAlive = false;
        }
    }
}
