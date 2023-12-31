using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomAsteroidMovement : MonoBehaviour
{
    public float accelerationTime = 1f;
    public float maxSpeed = 0.5f;
    private Vector2 movement;
    private float timeLeft;

    public Rigidbody2D rb;
    public float speed = 0.1f;

    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft <= 0)
        {
            movement = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
            timeLeft += accelerationTime;
        }
    }

    void FixedUpdate()
    {
        rb.AddForce(movement * maxSpeed);
    }
}
