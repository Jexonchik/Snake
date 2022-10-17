using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Food : MonoBehaviour
{
    public int FoodValue;
    public TextMesh Text;
    public bool isEaten;

    private void Start()
    {
        FoodValue = Random.Range(1, 10);
    }
    private void Update()
    {
        Text.text = FoodValue.ToString();
    }
}
