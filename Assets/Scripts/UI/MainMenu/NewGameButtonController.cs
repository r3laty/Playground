using UnityEngine;
using UnityEngine.SceneManagement;

public class NewGameButtonController : MonoBehaviour
{
    [SerializeField] private int gameSceneId;

    public void OnNewGameClick()
    {
        SceneManager.LoadScene(gameSceneId);
    }
}
