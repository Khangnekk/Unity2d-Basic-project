using UnityEngine;

public class playerDamageReceiver : damageReceiver
{
    protected playerController playerController;
    public AudioSource oughSound;
    private void Start()
    {
        playerController = GetComponent<playerController>();
    }
    public override void Receive(int damage)
    {
        base.Receive(damage);
        oughSound.Play();
        if (isDead()) playerController.playerStatus.Dead();
    }
}
