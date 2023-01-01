using UnityEngine;

public class damageReceiver : MonoBehaviour
{
    public int hp = 10;

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
