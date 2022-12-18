using UnityEngine;

public class despawner : MonoBehaviour
{

    public virtual void Despawn()
    {
        Destroy(gameObject);
    }
}
