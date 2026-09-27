using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody rb3d;

    [Header("Velocidad")]
    public float speed = 5f;

    private void Awake() { }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Jugador en escena");
        rb3d = GetComponent<Rigidbody>();
        rb3d.useGravity = true;
    }

    // Update is called once per frame
    void Update()
    {
        // Movimiento horizontal
        float moveH = Input.GetAxis("Horizontal");
        float moveV = Input.GetAxis("Vertical");
        rb3d.linearVelocity = new Vector3(moveH * speed, rb3d.linearVelocity.y, moveV * speed);
    }
}
