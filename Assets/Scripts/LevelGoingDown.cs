using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGoingDown : MonoBehaviour
{

    public float _speed;
    private void FixedUpdate()
    {
        transform.Translate(Vector3.forward * Time.fixedDeltaTime * -_speed);
    }
}


   
