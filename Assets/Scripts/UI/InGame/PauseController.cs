using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseController : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenu;
    [SerializeField] private GameObject inGameMenu;

    private int _sensivity;
    private int _music;
    private int _sounds;
    private void Start()
    {
        _sensivity = DontDestroyOnLoadVars.Instance.Sensivity;
        _music = DontDestroyOnLoadVars.Instance.Music;
        _sounds = DontDestroyOnLoadVars.Instance.Sounds;
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

    //public void OnMoreButtonClick(int settingType)
    //{
    //    switch (settingType)
    //    {
    //        case 1:
    //            sensivity++;
    //            sensivityCount.text = sensivity.ToString() + "%";
    //            break;

    //        case 2:
    //            music++;
    //            musicCount.text = music.ToString() + "%";
    //            break;

    //        case 3:
    //            sounds++;
    //            soundsCount.text = sounds.ToString() + "%";
    //            break;
    //    }
    //}
    //public void OnLessButtonClick(int settingType)
    //{
    //    switch (settingType)
    //    {
    //        case 1:
    //            sensivity--;
    //            sensivityCount.text = sensivity.ToString() + "%";
    //            break;

    //        case 2:
    //            music--;
    //            musicCount.text = music.ToString() + "%";
    //            break;

    //        case 3:
    //            sounds--;
    //            soundsCount.text = sounds.ToString() + "%";
    //            break;
    //    }
    //}

}
