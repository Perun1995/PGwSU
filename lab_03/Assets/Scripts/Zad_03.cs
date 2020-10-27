using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zad_03 : MonoBehaviour
{

    public float speed = 10.0f;
    Rigidbody rb;
    // krok rotacji, wyrazony w procentach, o jaki zostanie wykonana rotacja
    // w każdej klatce animacji
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if(rb.velocity.x == 0 &&  rb.position.x == 0)
        {
            rb.AddForce(speed,0,0, ForceMode.VelocityChange);
        }
        if(rb.velocity.x == speed && rb.position.x >= 10)
        {
            rb.AddForce((-speed),0,(-speed), ForceMode.VelocityChange);
        }
        if(rb.velocity.z == -speed && rb.position.z <= -10)
        {
            rb.AddForce(-speed,0,speed, ForceMode.VelocityChange);
        }
        if(rb.velocity.x == -speed && rb.position.x <= 0)
        {
            rb.AddForce(speed,0,speed, ForceMode.VelocityChange);
        }
         if(rb.velocity.z == speed && rb.position.z >= 0)
        {
            rb.AddForce(speed,0,-speed, ForceMode.VelocityChange);
        }
    }    
   
}

