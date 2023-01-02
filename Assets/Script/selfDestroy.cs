using UnityEngine;

public class selfDestroy : MonoBehaviour
{
    public float timeDestroy;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Destroy", timeDestroy);
    }

    void Destroy()
    {
        gameObject.SetActive(false);
        gamePlayMenuController.instance.currentBomb++;
    }
}
