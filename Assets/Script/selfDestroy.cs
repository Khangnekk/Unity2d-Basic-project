using UnityEngine;

public class selfDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Destroy", 4f);
    }

    void Destroy()
    {
        Destroy(gameObject);
    }
}
