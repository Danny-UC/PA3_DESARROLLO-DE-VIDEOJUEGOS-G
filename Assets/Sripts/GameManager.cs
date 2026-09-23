using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public TMP_Text appleCountText;
    public TMP_Text totalAppleCountText;
    private int appleNumber = 0;
    private int totalAppleCount = 0;

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
        Debug.Log("Total de manzanas en escena: " + totalAppleCountText.text);
    }

    public void IncrementAppleCount()
    {
        appleNumber++;
        appleCountText.text = appleNumber.ToString();
        Debug.Log("Colision con manzana " + appleCountText.text);

        if (appleNumber == totalAppleCount)
        {
            Debug.Log("¡Has recogido todas las manzanas!");
            Debug.Log("Te ganaste un premio!");
        }
    }

    void Update() { }
}
