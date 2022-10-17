using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonNewLvl : MonoBehaviour
{
    
    bool IsClicked;
    public GameObject CanvasWin;
    public void OnClicked()
    {
        IsClicked = true;
    }
    private void Update()
    {
        if (IsClicked)
        {

            if (SceneManager.GetActiveScene().name == "1")
                SceneManager.LoadScene("2");
            else if (SceneManager.GetActiveScene().name == "2")
                SceneManager.LoadScene("3");
            else if (SceneManager.GetActiveScene().name == "3")
                SceneManager.LoadScene("1");
        }
    }
}
