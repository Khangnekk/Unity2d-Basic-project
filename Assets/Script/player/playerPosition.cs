using System.Collections.Generic;
using UnityEngine;

public class playerPosition : MonoBehaviour
{
    List<GameObject> boms;
    public GameObject bomPrefab;
    public float spawnTimer = 0f;
    public float spawnDelay = 0.8f;
    // Start is called before the first frame update
    void Start()
    {
        boms = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerController.instance.damageReceiver.isDead()) return;
        Spawn();
        checkBomDead();
    }

    void Spawn()
    {
        spawnTimer += Time.deltaTime;
        if (spawnTimer < spawnDelay) return;
        spawnTimer = 0f;

        if (boms.Count >= 5) return;
        GameObject bom = Instantiate(bomPrefab);
        bom.transform.position = transform.position;
        bom.gameObject.SetActive(true);
        boms.Add(bom);
    }

    void checkBomDead()
    {
        GameObject bom;
        for (int i = 0; i < boms.Count; i++)
        {
            bom = boms[i];
            if (!bom.activeSelf)
            {
                spawnTimer += Time.deltaTime;
                if (spawnTimer < spawnDelay) return;
                spawnTimer = 0;
                boms.RemoveAt(i);
            }
        }
    }
}
