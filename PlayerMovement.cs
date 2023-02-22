using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;

    [SerializeField] private float speed;

    private bool moveLeft, moveRight;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (moveLeft)
        {
            float horizontalUpdate = -speed;
            Movement(horizontalUpdate);
        }

        if (moveRight)
        {
            float horizontalUpdate = +speed;
            Movement(horizontalUpdate);
        }
    }

    public void Movement(float Horizontal)
    {
        float horizontal = Horizontal;
        Vector3 characterPos = new Vector3(horizontal, rb.velocity.y, 0);
        rb.velocity = characterPos;
    }

    public void GoRight()
    {
        moveRight = true;
    }

    public void StopGoingRight()
    {
        moveRight = false;
        Movement(0);
    }

    public void GoLeft()
    {
        moveLeft = true;
    }

    public void StopGoingLeft()
    {
        moveLeft = false;
        Movement(0);
    }
}
