using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class BeamSummon : MonoBehaviour
{
    private float timer = 0f;
    private float timerMax = 10f;
    private bool isCooldownActive = false;

    public Rigidbody2D beam;
    private float beamSpeed = 5;

    // Start is called before the first frame update
    void Start()
    {
        timer = timerMax;
    }
    private void Update()
    {
        // Summon a beam every 10 seconds
        if (isCooldownActive)
        {
            timer -= Time.deltaTime;

            if (timer <= 0f)
            {
                timer = timerMax;
                isCooldownActive = false;
            }
        }
        else
        {
            SummonBeam();
        }
    }

    private void SummonBeam()
    {
        // Summon a beam in one of 4 directions, then move it forward
        int direction = Random.Range(0, 4);

        Rigidbody2D b = Instantiate(beam, transform.position, transform.rotation);
        
        // 0 is move up, 1 is move left, 2 is move down, 3 is move right
        if (direction == 0) b.transform.position = new Vector2(0, -25);
        if (direction == 1) { b.transform.position = new Vector2(25, 0); b.transform.Rotate(0, 0, 90); }
        if (direction == 2) { b.transform.position = new Vector2(0, 25); b.transform.Rotate(0, 0, 180); }
        if (direction == 3) { b.transform.position = new Vector2(-25, 0); b.transform.Rotate(0, 0, 270); }

        b.velocity = b.transform.up * beamSpeed;

        // Start cooldown timer
        isCooldownActive = true;
    }
}
