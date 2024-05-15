using TMPro;
using UnityEngine;

public class SettingsButtonController : MonoBehaviour
{
    [SerializeField] private GameObject settingsMenu;
    [SerializeField] private GameObject mainMenu;
    [Space]
    [SerializeField] private TextMeshProUGUI sensivityCount;
    [SerializeField] private TextMeshProUGUI musicCount;
    [SerializeField] private TextMeshProUGUI soundsCount;

    private int sensivity;
    private int music;
    private int sounds;
    private void Start()
    {
        sensivity = 25;
        music = 25;
        sounds = 25;
    }
    public void OnSettinsButtonClick()
    {
        mainMenu.SetActive(false);
        settingsMenu.SetActive(true);
    }
    public void OnExitSettingsButtonClick()
    {
        mainMenu.SetActive(true);
        settingsMenu.SetActive(false);
    }
    public void OnMoreButtonClick(int settingType)
    {
        switch (settingType)
        {
            case 1:
                sensivity++;
                sensivityCount.text = sensivity.ToString() + "%";
                break;

            case 2:
                music++;
                musicCount.text = music.ToString() + "%";
                break;

            case 3:
                sounds++;
                soundsCount.text = sounds.ToString() + "%";
                break;
        }
    }
    public void OnLessButtonClick(int settingType)
    {
        switch (settingType)
        {
            case 1:
                sensivity--;
                sensivityCount.text = sensivity.ToString() + "%";
                break;

            case 2:
                music--;
                musicCount.text = music.ToString() + "%";
                break;

            case 3:
                sounds--;
                soundsCount.text = sounds.ToString() + "%";
                break;
        }
    }
}