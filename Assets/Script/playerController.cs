using UnityEngine;

public class playerController : MonoBehaviour
{
    static public playerController instance;  // Singleton pattern
    Vector3 target;
    public damageReceiver damageReceiver;
    public playerStatus playerStatus;
    public float moveSpeed = 0.5f;
    public void Awake()
    {

        instance = this; // Singleton pattern
        damageReceiver = GetComponent<damageReceiver>();
        playerStatus = GetComponent<playerStatus>();
    }

    private void Update()
    {
        target = Input.mousePosition;
        target.z = -Camera.main.transform.position.z;
        target = Camera.main.ScreenToWorldPoint(target);
        transform.position = Vector3.MoveTowards(transform.position, target, moveSpeed);
    }

}
