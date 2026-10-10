
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScene : MonoBehaviour
{
    void Start()
    {
        // Liberar el cursor para utilizar los botones.
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        // Restaurar el tiempo del juego.
        Time.timeScale = 1f;

        // Regresar automáticamente al menú después de 10 segundos
        // únicamente en la pantalla de victoria.
        if (SceneManager.GetActiveScene().name == "WinScene")
        {
            Invoke(nameof(LoadMainMenu), 10f);
        }
    }

    public void LoadMainMenu()
    {
        CancelInvoke(nameof(LoadMainMenu));

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        Time.timeScale = 1f;

        SceneManager.LoadScene("MainMenu");
    }

    public void ReiniciarJuego()
    {
        CancelInvoke(nameof(LoadMainMenu));

        Time.timeScale = 1f;

        SceneManager.LoadScene("BLA TERRENO");
    }
}

