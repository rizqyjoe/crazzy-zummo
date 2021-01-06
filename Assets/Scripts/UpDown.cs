using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDown : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D Rb;
    public float jf;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Rb = GetComponent<Rigidbody2D>();
        Rb.AddForce(new Vector2(0, jf));
    }
}
