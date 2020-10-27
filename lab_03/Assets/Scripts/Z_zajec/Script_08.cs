using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_08 : MonoBehaviour
{
    public float distancePerFrame;
    
    void Update() {
        transform.Translate(0, 0, distancePerFrame);
    }
}
 //oraz
/*
public class ExampleScript : MonoBehaviour {
    public float distancePerSecond;
    
    void Update() {
        transform.Translate(0, 0, distancePerSecond * Time.deltaTime);
    }
}
*/