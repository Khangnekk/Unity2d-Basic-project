using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenuController : MonoBehaviour
{
    public AudioSource bgSound;
    public GameObject settingCanvas;
    public void StartButton()
    {
        Time.timeScale = 1;
        AudioListener.volume = 1;
        SceneManager.LoadScene("GamePlay");
    }

    public void RuleButton()
    {
        Time.timeScale = 1;
        AudioListener.volume = 1;
        SceneManager.LoadScene("Rules");
    }
    public void ExitButton()
    {
        Application.Quit();
    }
    void Start()
    {
        settingCanvas.SetActive(false);
        bgSound.Play();
    }

    public void Setting()
    {
        settingCanvas.SetActive(true);
    }

    public void exitSetting()
    {
        settingCanvas.SetActive(false);
    }

    public void muteButton()
    {
        AudioListener.volume = 1 - AudioListener.volume;
    }
}
