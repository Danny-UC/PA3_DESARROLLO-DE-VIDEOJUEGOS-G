
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScene : MonoBehaviour
{
    void Start()
    {
        // Solo regresar automáticamente al menú
        // cuando estamos en la escena de victoria.
        if (SceneManager.GetActiveScene().name == "WinScene")
        {
            Invoke("LoadMainMenu", 5f);
        }
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void ReiniciarJuego()
    {
        CancelInvoke("LoadMainMenu");
        SceneManager.LoadScene("BLA TERRENO");
    }
}
