using UnityEngine;

public class qwerty : MonoBehaviour
{
    public Transform from;
    public Transform to;

    // krok rotacji, wyrazony w procentach, o jaki zostanie wykonana rotacja
    // w każdej klatce animacji
    public float percentage = 0.01f;

    void Update()
    {
        transform.rotation = Quaternion.Slerp(from.rotation, to.rotation, percentage);
    }
}