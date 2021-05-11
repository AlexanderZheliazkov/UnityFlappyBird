using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float jumpPower = 200f;

    Rigidbody2D rb; 

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.anyKeyDown)
        {
            rb.velocity = Vector3.zero;
            rb.AddRelativeForce(new Vector2(0, jumpPower));
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Die();
    }

    void Die()
    {
        Game.instance.ResetLeve();
    }
}
