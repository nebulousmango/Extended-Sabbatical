using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class ButtonLeft : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    public bool buttonLeftPressed;

    public void OnPointerDown(PointerEventData eventData)
    {
        buttonLeftPressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        buttonLeftPressed = false;
    }
}