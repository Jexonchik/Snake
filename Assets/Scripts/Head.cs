using System;
using UnityEngine;

public class Head : MonoBehaviour
{
    //public CameraFollow Camera;
 
    //public float _speed;
    private Vector3 _targetMousePosition;
    public Tail Tail;
    
    void FixedUpdate()
    {
        
        if (Input.GetMouseButton(0))
        {
            Vector3 delta = Input.mousePosition - _targetMousePosition;
            transform.position += new Vector3(delta.x * Time.fixedDeltaTime, 0, 0);
            if (transform.position.x <= 1)
            {
                transform.position = new Vector3(0.2f, 1.3f, transform.position.z);
            }

            if (transform.position.x >= 28.5f)
            {
                transform.position = new Vector3(28.3f, 1.3f, transform.position.z);
            }
        }
        _targetMousePosition = Input.mousePosition;

    }

    
}
