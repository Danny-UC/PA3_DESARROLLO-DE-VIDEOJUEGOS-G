using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScene : MonoBehaviour
{
    void Start()
    {
        Invoke("LoadMainMenu", 5f);
    }

    public void LoadMainMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
    }
}
