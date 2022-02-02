using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_Player : MonoBehaviour
{
    public Vector3 Movimiento;
    public float Velocidad;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movimiento = new Vector3(Input.GetAxisRaw("Horizontal") * Velocidad, Input.GetAxisRaw("Vertical") * Velocidad, 0);
        Movimiento = Movimiento.normalized;
        //transform.position += Movimiento * Velocidad * Time.deltaTime;
        rb.velocity = new Vector2(Movimiento.x, Movimiento.y);
    }
}
