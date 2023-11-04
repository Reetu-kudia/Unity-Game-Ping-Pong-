using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    public Rigidbody2D rb;

    public float speed;
    public float p1Score;
    public float p2Score;
    public Text p1Text;
    public Text p2Text;
    public Vector2 startPos;


    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        initializeBall();
        
    }
    private void Update()
    {
        p1Text.text = p1Score.ToString();
        p2Text.text = p2Score.ToString();
    }

    void initializeBall()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        rb.velocity = new Vector2(x * speed, y * speed);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "p1goal")
        {
            p1Score++;
            rb.velocity = Vector2.zero;
            transform.position = startPos;
            initializeBall();
        }
        if (collision.gameObject.tag == "p2goal")
        {
            p2Score++;
            rb.velocity = Vector2.zero;
            transform.position = startPos;
            initializeBall();
        }
        
    }
   
}
