using UnityEngine;
using UnityEngine.UI;

public class playerDamageReceiver : damageReceiver
{
    protected playerController playerController;
    public Text hpTxt;
    public AudioSource oughSound;
    private void Start()
    {
        playerController = GetComponent<playerController>();
    }
    public override void Receive(int damage)
    {
        base.Receive(damage);
        getHP();
        oughSound.Play();
        if (isDead()) playerController.playerStatus.Dead();
    }

    protected void getHP()
    {
        hpTxt.text = "HP: " + hp.ToString();
    }
}
