using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_Player : MonoBehaviour
{
    public Vector3 Movement;
    public float Velocity;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement = new Vector3(Input.GetAxisRaw("Horizontal") * Velocity, Input.GetAxisRaw("Vertical") * Velocity, 0);
        Movement = Movement.normalized;
        //transform.position += Movement * Velocity * Time.deltaTime;
        rb.velocity = new Vector2(Movement.x * Velocity, Movement.y * Velocity);
    }
}
