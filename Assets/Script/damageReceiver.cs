using UnityEngine;

public class damageReceiver : MonoBehaviour
{
    protected int hp = 10;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public virtual void Receive(int damage)
    {
        hp -= damage;
        Debug.Log(hp);
    }
}
