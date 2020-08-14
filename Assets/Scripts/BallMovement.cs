using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    private Rigidbody2D rb;

    public float startSpeed;
    public float currentSpeed;
    public float speedIncrease;
    public int whichWay = 1;
    

    // Start is called before the first frame update
    void Start()
    {
        currentSpeed = startSpeed;
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(whichWay, 0f) * currentSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            float y = hitFactor(transform.position, collision.transform.position, collision.collider.bounds.size.y);
            whichWay *= -1;
            currentSpeed += speedIncrease;
            Vector2 dir = new Vector2(whichWay, y).normalized;
            rb.velocity = dir * currentSpeed;
        }
        if (collision.gameObject.name == "LeftWall" || collision.gameObject.name == "RightWall")
        {
            whichWay *= -1;
            currentSpeed = startSpeed;

            // wait 3 seconds before another round
            transform.position = new Vector2(0f, 0f);

            Vector2 dir = new Vector2(whichWay, 0f).normalized;
            rb.velocity = dir * currentSpeed;
        }
       
    }

    float hitFactor(Vector2 ballPos, Vector2 racketPos, float racketHeight)
    {
        return (ballPos.y - racketPos.y) / racketHeight;
    }

    
}
