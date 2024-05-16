using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseController : MonoBehaviour
{
    [HideInInspector] public int Sensivity;
    [HideInInspector] public int Music;
    [HideInInspector] public int Sounds;

    [SerializeField] private GameObject pauseMenu;
    [SerializeField] private GameObject inGameMenu;
    [Space]
    [SerializeField] private TextMeshProUGUI sensivityCount;
    [SerializeField] private TextMeshProUGUI musicCount;
    [SerializeField] private TextMeshProUGUI soundsCount;


    private char _persent = '%';
    private void Start()
    {
        Sensivity = DontDestroyOnLoadVars.Instance.Sensivity;
        Music = DontDestroyOnLoadVars.Instance.Music;
        Sounds = DontDestroyOnLoadVars.Instance.Sounds;

        sensivityCount.text = Sensivity.ToString() + _persent;
        musicCount.text = Music.ToString() + _persent;
        soundsCount.text = Sounds.ToString() + _persent;
    }
    public void OnPauseClick()
    {
        inGameMenu.SetActive(false);
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
    }
    public void OnExitPauseClick()
    {
        inGameMenu.SetActive(true);
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
    }
    public void OnRestartClick(int sceneIndex)
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(sceneIndex);
    }
    public void LeaveToMenuOnClick(int sceneIndex)
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(sceneIndex);
    }

    public void OnMoreButtonClick(int settingtype)
    {
        switch (settingtype)
        {
            case 1:
                Sensivity++;
                sensivityCount.text = Sensivity.ToString() + _persent;
                break;

            case 2:
                Music++;
                musicCount.text = Music.ToString() + _persent;
                break;

            case 3:
                Sounds++;
                soundsCount.text = Sounds.ToString() + _persent;
                break;
        }
    }
    public void OnLessButtonClick(int settingtype)
    {
        switch (settingtype)
        {
            case 1:
                Sensivity--;
                sensivityCount.text = Sensivity.ToString() + _persent;
                break;

            case 2:
                Music--;
                musicCount.text = Music.ToString() + _persent;
                break;

            case 3:
                Sounds--;
                soundsCount.text = Sounds.ToString() + _persent;
                break;
        }
    }

}
