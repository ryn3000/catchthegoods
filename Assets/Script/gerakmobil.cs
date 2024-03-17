using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class gerakmobil : MonoBehaviour
{
    private Rigidbody2D body;

    public float speed;
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal");

        if (h > 0)

            body.velocity = Vector2.right * speed;
        else if (h < 0)

            body.velocity = Vector2.left * speed;
        else
            body.velocity = Vector2.zero;

    }
}