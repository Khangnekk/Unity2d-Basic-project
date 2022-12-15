using UnityEngine;

public class damageSender : MonoBehaviour
{
    protected enemyController enemyController;


    private void Awake()
    {
        enemyController = GetComponent<enemyController>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            damageReceiver damageReceiver = collision.GetComponent<damageReceiver>();
            damageReceiver.Receive(1);
            enemyController.despawner.Despawn();
        }
        if (collision.CompareTag("bom"))
        {
            enemyController.despawner.Despawn();
        }

    }
}
