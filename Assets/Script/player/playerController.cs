using UnityEngine;

public class playerController : MonoBehaviour
{
    static public playerController instance;  // Singleton pattern
    public damageReceiver damageReceiver;
    public playerStatus playerStatus;
    public float moveSpeed;
    [SerializeField] private Joystick joystick;
    private Rigidbody2D rb2d;
    public bool isPhysics;
    public void Awake()
    {
        rb2d = gameObject.GetComponent<Rigidbody2D>();
        instance = this; // Singleton pattern
        damageReceiver = GetComponent<damageReceiver>();
        playerStatus = GetComponent<playerStatus>();
    }

    private void FixedUpdate()
    {
        Vector2 direction = Vector2.up * joystick.Vertical + Vector2.right * joystick.Horizontal;
        if (isPhysics)
        {
            rb2d.AddForce(direction * moveSpeed * Time.fixedDeltaTime, ForceMode2D.Impulse);
        }
        else
        {
            gameObject.transform.Translate(direction * moveSpeed * Time.deltaTime);
        }
    }

}
