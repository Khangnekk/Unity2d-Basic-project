using UnityEngine;

public class enemyController : MonoBehaviour
{
    public despawner despawner;
    private void Awake()
    {
        despawner = GetComponent<despawner>();
    }
}
