using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class player : MonoBehaviour
{
    public float screenRight = 4f;
    public float screenLeft = -4f;
    public float movementSpeed = 10f;
    public float movement = 0f;

    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       // movement = Input.GetAxis("Horizontal") * movementSpeed;
    }

    void FixedUpdate()
    {
        Vector2 velocity = rb.velocity;
        velocity.x = movement;
        rb.velocity = velocity;

        //Si exxiste el Boundari en el juego.
        if (transform.position.x > screenRight)
        {
            transform.position = new Vector2 (screenLeft, transform.position.y);
        }
        if (transform.position.x < screenLeft)
        {
            transform.position = new Vector2(screenRight, transform.position.y);
        }
    }

    void OnCollisionEnter2D(Collision2D collisionInfo)

    {
        if (collisionInfo.collider.tag == "muerte")
        {
            Debug.Log("muerte");
            FindObjectOfType<GameManager>().EndGame();
         }
    }
}
