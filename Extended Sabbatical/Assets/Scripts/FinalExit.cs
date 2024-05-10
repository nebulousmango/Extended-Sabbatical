using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalExit : MonoBehaviour
{
    [SerializeField] private string S_LevelOne;

    private void OnMouseDown()
    {
        SceneManager.LoadScene(S_LevelOne);
    }

}
