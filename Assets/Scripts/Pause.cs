using UnityEngine;

public class Pause : MonoBehaviour
{
    int IsClicked;
    public void OnClicked()
    {
        IsClicked++;
    }

    private void Update()
    {
        if (IsClicked % 2 != 0)
        {
            Time.timeScale = 0;

        }
        else
        {
            Time.timeScale = 1;
        }

    }
}
