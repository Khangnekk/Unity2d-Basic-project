using UnityEngine;
using UnityEngine.UI;

public class healthBarController : MonoBehaviour
{
    public Image healthBar;
    public float currentHealth;
    public float maxHealth = 10;

    private void Update()
    {
        currentHealth = damageReceiver.instance.hp;
        healthBar.fillAmount = currentHealth / maxHealth;
    }
}
