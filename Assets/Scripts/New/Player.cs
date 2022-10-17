using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public List<GameObject> BodySnake = new();

    public GameObject SnakeBody;

    public void AddTile()
    { 
        Vector3 Position = transform.position;
        if (BodySnake.Count > 0)
        { Position = BodySnake[BodySnake.Count - 1].transform.position; }
        Position.z += 1f;
        GameObject Body = Instantiate(SnakeBody, Position, Quaternion.identity);
        BodySnake.Add(Body); 
    }
    
   
}
