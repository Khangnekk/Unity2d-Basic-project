using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gamePlayMenuController : MonoBehaviour
{
    public GameObject settingCanvas;
    public GameObject scoreCanvas;
    public AudioSource bgSound;
    List<GameObject> boms;
    public GameObject bomPrefab;
    void Start()
    {
        Time.timeScale = 1;
        settingCanvas.SetActive(false);
        boms = new List<GameObject>();
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
        settingCanvas.SetActive(false);
        Time.timeScale = 0;
        bgSound.Pause();

    }
    public void ResumeGame()
    {
        settingCanvas.SetActive(false);
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
        SceneManager.LoadScene("MainMenu");
    }
    public void resumeButton()
    {
        SceneManager.LoadScene("GamePlay");
    }

    public void muteButton()
    {
        AudioListener.volume = 1 - AudioListener.volume;
    }

    public void spawnBombBtn()
    {
        Spawn();
    }

    void Spawn()
    {
        if (boms.Count >= 5) return;
        GameObject bom = Instantiate(bomPrefab);
        bom.transform.position = playerController.instance.transform.position;
        bom.gameObject.SetActive(true);
        boms.Add(bom);
    }

    void checkBomDead()
    {
        GameObject bom;
        for (int i = 0; i < boms.Count; i++)
        {
            bom = boms[i];
            if (!bom.activeSelf)
            {
                boms.RemoveAt(i);
            }
        }
    }
}
