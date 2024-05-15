using UnityEngine;

public class ExitButtonController : MonoBehaviour
{
    public void OnQuitButtonClick()
    {
        Application.Quit();
        print("Quit");
    }
}
