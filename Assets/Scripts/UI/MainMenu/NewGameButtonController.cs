using UnityEngine;
using UnityEngine.SceneManagement;

public class NewGameButtonController : MonoBehaviour
{
    public void OnNewGameClick(int index)
    {
        SceneManager.LoadScene(index);
    }
}
