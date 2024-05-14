using UnityEngine;
using UnityEngine.EventSystems;

public class FixedTouchField : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [HideInInspector]
    public Vector2 TouchDistance;

    private Vector2 PointerOld;

    private int _pointerId;
    private bool _pressed;

    private void Update()
    {
        if (_pressed)
        {
            if (_pointerId >= 0 && _pointerId < Input.touches.Length)
            {
                TouchDistance = Input.touches[_pointerId].position - PointerOld;
                PointerOld = Input.touches[_pointerId].position;
            }
            else
            {
                TouchDistance = new Vector2(Input.mousePosition.x, Input.mousePosition.y) - PointerOld;
                PointerOld = Input.mousePosition;
            }
        }
        else
        {
            TouchDistance = new Vector2();
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        _pressed = true;
        _pointerId = eventData.pointerId;
        PointerOld = eventData.position;
    }


    public void OnPointerUp(PointerEventData eventData)
    {
        _pressed = false;
    }
}
