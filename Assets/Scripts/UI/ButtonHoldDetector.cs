using System;
using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonHoldDetector : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public static bool IsButtonHold;
    public static event Action Holded;
    public void OnPointerDown(PointerEventData eventData)
    {
        IsButtonHold = true;
        StartCoroutine(StartEvent());
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

    private IEnumerator StartEvent()
    {
        yield return new WaitForEndOfFrame();
        Holded?.Invoke();
    }
}
