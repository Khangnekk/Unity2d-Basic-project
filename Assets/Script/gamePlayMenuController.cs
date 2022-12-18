using UnityEngine;
using UnityEngine.SceneManagement;

public class gamePlayMenuController : MonoBehaviour
{
    public GameObject settingCanvas;
    public GameObject scoreCanvas;
    public AudioSource bgSound;

    void Start()
    {
        Time.timeScale = 1;
        settingCanvas.SetActive(false);
        bgSound.Play();
    }
    private void Update()
    {
        if (playerController.instance.damageReceiver.isDead())
        {
            bgSound.Pause();
            Time.timeScale = 0;
        }
    }
    public void PauseGame()
    {
        Time.timeScale = 0;
        bgSound.Pause();
    }
    public void ResumeGame()
    {
        Time.timeScale = 1;
        bgSound.Play();
    }

    public void Setting()
    {
        settingCanvas.SetActive(true);
        scoreCanvas.SetActive(false);
    }

    public void exitSetting()
    {
        settingCanvas.SetActive(false);
    }

    public void MenuButton()
    {
        bgSound.Pause();
        AudioListener.volume = 1;
        SceneManager.LoadScene("MainMenu");
    }

    public void muteButton()
    {
        AudioListener.volume = 1 - AudioListener.volume;
    }
}
