using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Transform hedef;

    // Update is called once per frame
    void Update()
    {
        if (hedef.position.y > transform.position.y)
        {
            transform.position = new Vector3(transform.position.x,hedef.position.y,transform.position.z);
        }
    }
}
