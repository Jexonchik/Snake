using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{

    public LevelGoingDown LevelGoingDown;
    public Head Head;
    public GameObject CanvasWin;
    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent(out Tail tail))
        {
            LevelGoingDown.enabled = false;
            Head.enabled = false;
            CanvasWin.SetActive(true);
        }
    }
}
