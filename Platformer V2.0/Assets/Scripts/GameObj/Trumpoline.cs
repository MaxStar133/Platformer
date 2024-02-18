using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trumpoline : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] private float jumpForce = 26f;
   

  
    public void Jump()
    {
        
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);

    }
}
