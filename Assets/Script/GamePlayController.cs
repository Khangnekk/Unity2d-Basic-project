using UnityEngine;
using UnityEngine.UI;

public class GamePlayController : MonoBehaviour
{
    static public GamePlayController instance;
    public Text goldTxt;
    public Text currentBombTxt;
    public Text YourGoldTxt;
    int gold = 0;
    int currentBomb;
    public AudioSource explosion;

    private void Awake()
    {
        instance = this;
    }
    public void getScore()
    {
        explosion.Play();
        gold++;
        goldTxt.text = ": " + gold.ToString();
        YourGoldTxt.text = "Gold received after the game \n" + gold.ToString();
    }

    public void getCurrentBomb()
    {
        currentBomb = gamePlayMenuController.instance.currentBomb;
        currentBombTxt.text = currentBomb.ToString() + "/5";
    }
}
