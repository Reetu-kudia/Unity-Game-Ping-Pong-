using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    public bool isplayer1;
    float move;

    // Update is called once per frame
    void Update()
    {
       
        if (isplayer1)
        {
            move = Input.GetAxis("Player1");
        }
        else
        {
            move = Input.GetAxis("Player2");
        }
        rb.velocity = new Vector2(rb.velocity.x, move * speed);

    }
}
