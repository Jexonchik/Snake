using System.Collections.Generic;
using UnityEngine;


public class Tail : MonoBehaviour
{
    public GameObject PrefabTail;
    public List<GameObject> BodySnake;
    public GameObject First;
    public float offset;
    public LevelGoingDown LevelGoingDown;
    public Head Head;
    public TextMesh Text;
    public int BodyScore;
    public GameObject Canvas;



    private void Update()
    {
        BodyScore = BodySnake.Count + 1;
        Text.text = BodyScore.ToString();
        //transform.position = vecH - new Vector3(0, 0, offset);
        if (BodySnake.Count <= 0) return;

        var vecLerp = Vector3.Lerp(BodySnake[0].transform.position, First.transform.position, 0.5f);
        BodySnake[0].transform.position = vecLerp - new Vector3(0, 0, offset);

        for (int i = 0; i <= BodySnake.Count; i++)
        {
            if (BodySnake.Count <= 0) return;
            // BodySnake[i+1].transform.position = BodySnake[i].transform.position - new Vector3(0, 0, offset);
            Vector3 vecLerp2 = Vector3.Lerp(BodySnake[i].transform.position, BodySnake[i + 1].transform.position, 0.5f);
            BodySnake[i + 1].transform.position = vecLerp2 - new Vector3(0, 0, offset);
        }

    }

    public void AddTail()
    {
        var body = Instantiate(PrefabTail, transform.position, Quaternion.identity);
        BodySnake.Add(body);
    }
    public void KillTail()
    {
        Destroy(BodySnake[0]);
        BodySnake.RemoveAt(0);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent(out Food food))
        {
            if (!food.isEaten)
            {
                Destroy(other.gameObject);
                food.isEaten = true;
                var value = food.FoodValue;
                for (int i = 0; i < value; i++) { AddTail(); }
            }
        }

        if (other.gameObject.TryGetComponent(out Blocks blocks))
        {
            if (BodySnake.Count == 0) { GameOver(); return; }
            var value1 = blocks.BlockValue;
            for (int i = 0; i < value1; i++)
            {
                KillTail(); blocks.BlockValue--;

                if (blocks.BlockValue == 0 && BodySnake.Count > 0) { Destroy(other.gameObject); }
                else if (blocks.BlockValue > 0 && BodySnake.Count == 0) 
                { 
                    GameOver();  
                }
            }

        }
    }

    public void GameOver()
    {

        LevelGoingDown.enabled = false;
        Head.enabled = false;
        Canvas.SetActive(true);

    }

}
