using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ExitScene : MonoBehaviour, IPointerDownHandler
{
    [SerializeField] private string S_NextScene;

    public void OnPointerDown(PointerEventData eventData)
    {
        SceneManager.LoadScene(S_NextScene);
    }
}
