using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    public bool isGrounded = false; 
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D col)
    {
        isGrounded = true;
    }
    void OnTriggerExit2D(Collider2D col)
    {
        isGrounded = false;
    }
}
