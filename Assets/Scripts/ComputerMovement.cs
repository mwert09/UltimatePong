using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerMovement : MonoBehaviour
{
    public GameObject Ball;
    public float speed;

    Vector3 move = Vector3.zero;

    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float d = Ball.transform.position.y - transform.position.y;
        if(d > 0)
        {
            move.y = speed * Mathf.Min(d, 1.0f);
        }
        if(d < 0)
        {
            move.y = -(speed * Mathf.Min(-d, 1.0f));
        }
        transform.position += move * Time.deltaTime;
    }
}
