using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    bool IsClicked;
    public void OnClicked()
    {
        IsClicked = true;
    }
    private void Update()
    {
        if (IsClicked)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            
        }
    }
}
