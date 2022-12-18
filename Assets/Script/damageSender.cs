using UnityEngine;

public class damageSender : MonoBehaviour
{
    GameObject gameController;
    protected enemyController enemyController;

    private void Awake()
    {
        enemyController = GetComponent<enemyController>();
    }
    private void Start()
    {
        if (gameController == null)
        {
            gameController = GameObject.FindGameObjectWithTag("GameController");
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            damageReceiver damageReceiver = collision.GetComponent<damageReceiver>();
            damageReceiver.Receive(2);
            enemyController.despawner.Despawn();
        }
        if (collision.CompareTag("bom"))
        {
            gameController.GetComponent<GamePlayController>().getScore();
            enemyController.despawner.Despawn();
        }

    }


}
