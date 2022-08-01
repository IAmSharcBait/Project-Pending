using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rigidbody2d;
    public float speed = 3.0f;
    float horizontal;
    float vertical;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
    }

    // FixedUpdate is called every x miliseconds
    void FixedUpdate()
    {
        Vector2 position = rigidbody2d.position;

        position.x = position.x + ( speed * horizontal * Time.deltaTime );
        position.y = position.y + ( speed * vertical * Time.deltaTime );

        rigidbody2d.MovePosition(position);
    }
}
