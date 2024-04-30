using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ExtraEvents : MonoBehaviour, IPointerDownHandler
{
    [SerializeField] GameObject TurnThisOn1;
    [SerializeField] GameObject TurnThisOff1;

    public void OnPointerDown(PointerEventData eventData)
    {
        TurnThisOn1.SetActive(true);
        TurnThisOff1.SetActive(false);
    }
}