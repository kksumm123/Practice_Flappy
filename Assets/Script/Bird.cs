using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    new Rigidbody2D rigidbody2D;
    Animator animator;
    public float forceY = 300f;

    private void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        Flap();
    }

    void Update()
    {
        if (Time.time < 0.5f)
            return;

        if (Input.GetMouseButtonDown(0))
        {
            Flap();
        }
    }

    private void Flap()
    {
        Vector2 force = new Vector2(0, forceY);
        rigidbody2D.velocity = Vector2.zero;
        rigidbody2D.AddForce(force);

        animator.Play("Flap");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        animator.Play("Die");
        GameManager.instance.SetGamveOver(true);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameManager.instance.AddScore(100);
    }
}
