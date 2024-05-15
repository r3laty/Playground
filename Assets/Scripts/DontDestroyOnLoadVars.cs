using UnityEngine;

public class DontDestroyOnLoadVars : MonoBehaviour
{
    public static DontDestroyOnLoadVars Instance;

    public int Sensivity = 25;
    public int Music = 25;
    public int Sounds = 25;

    private void Start()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }

        SettingsButtonController.SensValueChanged += SensivitySettings;
        SettingsButtonController.MusValueChanged += MusicSettings;
        SettingsButtonController.SoundsValueChanged += SoundsSettings;
    }
    private void SensivitySettings(int sensivity)
    {
        Sensivity = sensivity;
    }
    private void MusicSettings(int music)
    {
        Music = music;
    }
    private void SoundsSettings(int sounds)
    {
        Sounds = sounds;
    }
    private void OnDisable()
    {
        SettingsButtonController.SensValueChanged -= SensivitySettings;
        SettingsButtonController.MusValueChanged += MusicSettings;
        SettingsButtonController.SoundsValueChanged += SoundsSettings;
    }
}

