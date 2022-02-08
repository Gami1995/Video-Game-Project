using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed,running;
    public float jumpheight;
    private Rigidbody2D rb2D;
    public GameObject ground;
    private bool isRunning = false;

    // Use this for initialization

    void Start()
    {
        
        rb2D = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Ground isGround = ground.GetComponent<Ground>();

        Movement(isGround.isGrounded);
    }
    void Movement(bool isGrounded)
    {
        
        if (Input.GetKey(KeyCode.LeftShift))
        {
            isRunning = true;
        }
        else
        {
            isRunning = false;
        }
        if (Input.GetKey(KeyCode.D))
        {
            // If the shift key is down making isRunning true the character will use the running speed while it moves
            if (isRunning == false)
            transform.Translate(Vector2.right * Time.deltaTime * speed);
            if (isRunning == true)
            transform.Translate(Vector2.right * Time.deltaTime * (running));
        }
        if (Input.GetKey(KeyCode.A))
        {
            if (isRunning == false)
            transform.Translate(Vector2.right * Time.deltaTime * -speed);
            if (isRunning == true)
            transform.Translate(Vector2.right * Time.deltaTime * -(running));
        }
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb2D.AddForce(new Vector2(0, jumpheight));
        }
    }
}
