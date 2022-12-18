using UnityEngine;
using UnityEngine.SceneManagement;

public class ruleMenuController : MonoBehaviour
{
    public AudioSource bgSound;
    public void Start()
    {
        bgSound.Play();
    }
    public void MenuButton()
    {
        Time.timeScale = 1;
        AudioListener.volume = 1;
        SceneManager.LoadScene("MainMenu");
    }
}
