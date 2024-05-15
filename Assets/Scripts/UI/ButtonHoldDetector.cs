using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonHoldDetector : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public static bool IsButtonHold;
    public void OnPointerDown(PointerEventData eventData)
    {
        IsButtonHold = true;
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        IsButtonHold = false;
    }

    private void Update()
    {
        if (IsButtonHold)
        {
            print("Hold");
        }
        else
        {
            print("Up");
        }
    }
}
