using System;
using TMPro;
using UnityEngine;

public class SettingsButtonController : MonoBehaviour
{
    public static Action<int> SensValueChanged;
    public static Action<int> MusValueChanged;
    public static Action<int> SoundsValueChanged;

    [SerializeField] private GameObject settingsMenu;
    [SerializeField] private GameObject mainMenu;
    [Space]
    [SerializeField] private TextMeshProUGUI sensivityCount;
    [SerializeField] private TextMeshProUGUI musicCount;
    [SerializeField] private TextMeshProUGUI soundsCount;

    public int Sensivity { get; private set; }
    public int Music { get; private set; }
    public int Sounds { get; private set; }
    private void Start()
    {
        Sensivity = 25;
        Music = 25;
        Sounds = 25;
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
                Sensivity++;
                sensivityCount.text = Sensivity.ToString() + "%";

                SensValueChanged?.Invoke(Sensivity);
                break;

            case 2:
                Music++;
                musicCount.text = Music.ToString() + "%";

                MusValueChanged?.Invoke(Music);
                break;

            case 3:
                Sounds++;
                soundsCount.text = Sounds.ToString() + "%";
                
                SoundsValueChanged?.Invoke(Sounds);
                break;
        }
    }
    public void OnLessButtonClick(int settingType)
    {
        switch (settingType)
        {
            case 1:
                Sensivity--;
                sensivityCount.text = Sensivity.ToString() + "%";

                SensValueChanged?.Invoke(Sensivity);
                break;

            case 2:
                Music--;
                musicCount.text = Music.ToString() + "%";

                MusValueChanged?.Invoke(Music);
                break;

            case 3:
                Sounds--;
                soundsCount.text = Sounds.ToString() + "%";

                SoundsValueChanged?.Invoke(Sounds);
                break;
        }
    }
}