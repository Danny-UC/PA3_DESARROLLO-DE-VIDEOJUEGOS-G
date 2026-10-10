
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public AudioSource audioSource;
    public AudioClip appleCollectSound;
    public AudioClip winSound;

    public TMP_Text appleCountText;
    public TMP_Text totalAppleCountText;

    private int appleNumber = 0;
    private int totalAppleCount = 0;
    private bool nivelTerminado = false;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
    }

    void Start()
    {
        totalAppleCount = GameObject.FindGameObjectsWithTag("Apple").Length;

        totalAppleCountText.text = totalAppleCount.ToString();

        Debug.Log("Total de manzanas en escena: " + totalAppleCount);
    }

    public void NextScene()
    {
        string escenaActual = SceneManager.GetActiveScene().name;

        if (escenaActual == "BLA TERRENO")
        {
            PlayerPrefs.SetInt("Nivel1Completado", 1);
            PlayerPrefs.Save();

            SceneManager.LoadScene("NIVEL 2");
        }
        else if (escenaActual == "NIVEL 2")
        {
            PlayerPrefs.SetInt("Nivel2Completado", 1);
            PlayerPrefs.Save();

            SceneManager.LoadScene("WinSecene");
        }
    }

    public void IncrementAppleCount()
    {
        if (nivelTerminado)
        {
            return;
        }

        appleNumber++;
        appleCountText.text = appleNumber.ToString();

        if (audioSource != null && appleCollectSound != null)
        {
            audioSource.PlayOneShot(appleCollectSound);
        }

        Debug.Log("Colision con manzana " + appleNumber);

        if (appleNumber >= totalAppleCount && totalAppleCount > 0)
        {
            nivelTerminado = true;

            Debug.Log("¡Has recogido todas las manzanas!");
            Debug.Log("Te ganaste un premio!");

            if (audioSource != null && winSound != null)
            {
                audioSource.PlayOneShot(winSound);
            }

            Invoke(nameof(NextScene), 2f);
        }
    }
}
