using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    protected GameObject enemyPrefab;
    protected float timer = 0;
    protected float delay = 1f;

    private void Awake()
    {
        enemyPrefab = GameObject.Find("Enemy");
        enemyPrefab.SetActive(false);
    }

    private void Update()
    {
        Spawn();
    }

    protected virtual void Spawn()
    {
        if (playerController.instance.damageReceiver.isDead()) return; // Singleton pattern 

        timer += Time.deltaTime;
        if (timer < delay) return;
        timer = 0;

        GameObject enemy = Instantiate(enemyPrefab);
        enemy.transform.position = transform.position;
        enemy.SetActive(true);
    }
}
