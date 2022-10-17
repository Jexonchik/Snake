using UnityEngine;

public class Blocks : MonoBehaviour
{
    public int BlockValue;
    public TextMesh Text;
    public bool isBroken;
    public Gradient Gradient;

    private void Start()
    {
        BlockValue = Random.Range(1, 11);

    }
    private void Update()
    {
        //if (BlockValue > 7) { gameObject.GetComponent<Renderer>().material.color = Color.red; }
        //else if (BlockValue <= 7 && BlockValue > 3)
        //{
        //    gameObject.GetComponent<Renderer>().material.color = Color.yellow;
        //}
        //else gameObject.GetComponent<Renderer>().material.color = Color.green;

        gameObject.GetComponent<Renderer>().material.color = Gradient.Evaluate((float)BlockValue/10);

        Text.text = BlockValue.ToString();
    }
}
