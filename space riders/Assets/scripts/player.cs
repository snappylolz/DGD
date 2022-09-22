using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    private Rigidbody2D RB;
    private float speed = 5.0f;
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector2 pos = transform.position;

        pos.x += h * Time.deltaTime * speed;
        pos.y += v * Time.deltaTime * speed;

        transform.position = pos;
    }
}
        
        
    

