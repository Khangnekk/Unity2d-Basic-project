using UnityEngine;
using UnityEngine.UI;

public class GamePlayController : MonoBehaviour
{
    public Text goldTxt;
    public Text YourGoldTxt;
    int gold = 0;
    public AudioSource explosion;
    public void getScore()
    {
        explosion.Play();
        gold++;
        goldTxt.text = ": " + gold.ToString();
        YourGoldTxt.text = "Gold received after the game \n:" + gold.ToString();
    }
}
