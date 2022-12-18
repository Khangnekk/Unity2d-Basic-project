using UnityEngine;

public class playerStatus : MonoBehaviour
{
    protected playerController playerController;
    public GameObject yourScoreCanvas;

    public void Awake()
    {
        playerController = GetComponent<playerController>();
    }
    private void Update()
    {
        //checkDead();
    }
    protected virtual void checkDead()
    {
        if (playerController.damageReceiver.isDead()) Dead();
    }
    public virtual void Dead()
    {
        yourScoreCanvas.SetActive(true);
    }
}
