using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    static public enemySpawner instance;
    protected GameObject enemyPrefab;
    protected float timer = 0;
    protected float delay = 0.8f;
    List<GameObject> enemys;
    public float currentEnemy = 0;
    private void Awake()
    {
        instance = this;
        enemyPrefab = GameObject.Find("Enemy");
        enemyPrefab.SetActive(false);
        enemys = new List<GameObject>();
    }

    private void Update()
    {
        Spawn();
        checkEnemyDead();
    }

    protected virtual void Spawn()
    {
        if (playerController.instance.damageReceiver.isDead()) return; // Singleton pattern 

        timer += Time.deltaTime;
        if (timer < delay) return;
        timer = 0;

        if (enemys.Count >= 15) return;
        GameObject enemy = Instantiate(enemyPrefab);
        enemy.transform.position = transform.position;
        enemy.SetActive(true);
        enemys.Add(enemy);
    }

    void checkEnemyDead()
    {
        GameObject enemy;
        for (int i = 0; i < enemys.Count; i++)
        {
            enemy = enemys[i];
            if (!enemy.activeSelf)
            {
                timer += Time.deltaTime;
                if (timer < delay) return;
                timer = 0;
                enemy.SetActive(true);
            }
        }
    }
}
