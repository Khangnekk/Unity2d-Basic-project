using UnityEngine.UI;

public class playerDamageReceiver : damageReceiver
{
    protected playerController playerController;
    public Text hpTxt;
    private void Start()
    {
        playerController = GetComponent<playerController>();
    }
    public override void Receive(int damage)
    {
        base.Receive(damage);
        getHP();
        if (isDead()) playerController.playerStatus.Dead();
    }

    protected void getHP()
    {
        hpTxt.text = "HP: " + hp.ToString();
    }
}
