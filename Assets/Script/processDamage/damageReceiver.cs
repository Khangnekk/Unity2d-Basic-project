using UnityEngine;

public class damageReceiver : MonoBehaviour
{
    static public damageReceiver instance;
    public int hp = 10;

    private void Awake()
    {
        instance = this;
    }

    public virtual void Receive(int damage)
    {
        if (isDead()) return;
        hp -= damage;
    }

    public virtual bool isDead()
    {
        return hp <= 0;
    }



}
