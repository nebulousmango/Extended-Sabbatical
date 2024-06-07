using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class ButtonRight : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    public bool buttonRightPressed;

    public void OnPointerDown(PointerEventData eventData)
    {
        buttonRightPressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        buttonRightPressed = false;
    }
}