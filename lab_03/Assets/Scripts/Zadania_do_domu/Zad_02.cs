using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zad_02 : MonoBehaviour
{

    public float speed = 10.0f;
    Rigidbody rb;

    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(Vector3.right * speed, ForceMode.Impulse);
    }

    void FixedUpdate()
    {
        if(rb.position.x >= 10)         {
            rb.AddForce(Vector3.left, ForceMode.Impulse);
        }
        if(rb.position.x <= 0)
        {
            rb.AddForce(Vector3.right, ForceMode.Impulse);
        }     

    }    
}
//przez 8h próbowałem rozwikłać dlaczego skrypt nie działa okazało się, że unity nie jest w stanie zatrzymać się w dokładnym punkcie, czyli == nie działa

