using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSpell : MonoBehaviour
{
    public float speed = 10f;

    void Start()
    {
        // Move the spell forward
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * speed;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        // Destroy the fire spell on collision with any object
        Destroy(gameObject);

        if (collision.gameObject.CompareTag("Enemy"))
        {
            // Destroy the slime object
            Destroy(collision.gameObject);
            
        }
    }
}
