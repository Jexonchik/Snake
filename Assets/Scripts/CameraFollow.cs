using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject Player;
        
    public Vector3 Offset;
    void Update()
    {
        transform.position = new Vector3(0,0, Player.transform.position.z)+Offset;
    }
}