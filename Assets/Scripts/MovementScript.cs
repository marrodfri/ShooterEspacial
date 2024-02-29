using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    public float speed = 5f;

    private void FixedUpdate()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector2 direction = new Vector2(horizontal, vertical);

        GetComponent<Rigidbody2D>().velocity = direction.normalized * speed;
        
        GetComponent<Animator>().SetBool("flying", vertical > 0);
    }
}
