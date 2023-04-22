using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float zipla;
    private Vector2 hiz;
    private Rigidbody2D rb;

    private void OnCollisionEnter2D(Collision2D temas)
    {
        if (temas.relativeVelocity.y <= 0)
        {

        }
        rb=temas.collider.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            hiz = rb.velocity;
            hiz.y = zipla;
            rb.velocity= hiz;
        }
    }
}
