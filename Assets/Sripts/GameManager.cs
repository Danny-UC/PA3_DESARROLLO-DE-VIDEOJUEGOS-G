using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    
    public TMP_Text appleCountText;
    private int appleNumber = 0;

    private void Awake()
{
    if (Instance != null && Instance != this)
    {
        Destroy(gameObject);
        return;
    }
    Instance = this;
}


public void IncrementAppleCount()
{
    appleNumber++;
    appleCountText.text = appleNumber.ToString();
}
}
