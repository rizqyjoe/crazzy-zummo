﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D Rb;
    public float ms;
    public float jf;

    public GameManager gameManager;

    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horiz = Input.GetAxisRaw("Horizontal");
        Rb.velocity = new Vector2(ms * horiz, Rb.velocity.y);
        if (Input.GetButtonDown("Jump"))
        {
            Rb.AddForce(new Vector2(0, jf));
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("spike"))
        {
            Destroy(gameObject);
            gameManager.GameOver();

        } else
        {
            Destroy(collision.gameObject);
        }
    }
}
