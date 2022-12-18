using UnityEngine;
using UnityEngine.UI;

public class GamePlayController : MonoBehaviour
{
    public Text scoretxt;
    public Text yourScoretxt;
    int score = 0;
    public AudioSource explosion;
    public void getScore()
    {
        explosion.Play();
        score++;
        scoretxt.text = "Score: " + score.ToString();
        yourScoretxt.text = "Your Score:\n" + score.ToString();
    }
}
