//Attach this script and a Rigidbody to your GameObject. To do this click the GameObject, click the Add Component button in its Inspector, and go to Physics>Rigidbody.

using UnityEngine;
using System.Collections;

public class test1 : MonoBehaviour
{
    //Make sure you attach a Rigidbody in the Inspector of this GameObject
    Rigidbody m_Rigidbody;
    Vector3 m_EulerAngleVelocity;

    void Start()
    {
        //Set the axis the Rigidbody rotates in (100 in the y axis)
        m_EulerAngleVelocity = new Vector3(0, 100, 0);

        //Fetch the Rigidbody from the GameObject with this script attached
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Quaternion deltaRotation = Quaternion.Euler(m_EulerAngleVelocity);
        m_Rigidbody.MoveRotation(m_Rigidbody.rotation * deltaRotation);
    }
}