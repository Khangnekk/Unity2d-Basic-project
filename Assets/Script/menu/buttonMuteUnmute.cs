using UnityEngine;
using UnityEngine.UI;

public class buttonMuteUnmute : MonoBehaviour
{
    public Sprite soundOnImg;
    public Sprite soundOffImg;
    public Button button;
    private bool isOn = true;

    public void buttonClick()
    {
        if (isOn)
        {
            button.image.sprite = soundOffImg;
            isOn = false;
        }
        else
        {
            button.image.sprite = soundOnImg;
            isOn = true;
        }
    }
}
