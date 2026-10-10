
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SeleccionNiveles : MonoBehaviour
{
    public Button botonNivel2;

    void Start()
    {
        bool nivel1Completado =
            PlayerPrefs.GetInt("Nivel1Completado", 0) == 1;

        botonNivel2.interactable = nivel1Completado;
    }

    public void AbrirNivel1()
    {
        SceneManager.LoadScene("BLA TERRENO");
    }

    public void AbrirNivel2()
    {
        if (PlayerPrefs.GetInt("Nivel1Completado", 0) == 1)
        {
            SceneManager.LoadScene("NIVEL 2");
        }
    }

    public void VolverMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}

