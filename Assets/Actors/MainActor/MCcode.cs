using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MCcode : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb2d;
    public Vector2 movement;

    // Update is called once per frame
    public void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if(movement.x != 0 || movement.y != 0){
            movement = new Vector2(
                movement.x,
                movement.y
            ).normalized;
        }
    }

    void FixedUpdate()
    {
        rb2d.MovePosition(rb2d.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
