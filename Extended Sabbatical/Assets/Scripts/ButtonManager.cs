using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] private string S_LevelOne;
    [SerializeField] private string S_LevelTwo;
    [SerializeField] private string S_LevelThree;
    [SerializeField] private string S_LevelFour;
    private int PrevScene;

    public void LoadLevelOne()
    {
        SceneManager.LoadScene(S_LevelOne);
    }

    public void LoadLevelTwo()
    {
        SceneManager.LoadScene(S_LevelTwo);
    }

    public void LoadLevelThree()
    {
        SceneManager.LoadScene(S_LevelThree);
    }

    public void LoadLevelFour()
    {
        SceneManager.LoadScene(S_LevelFour);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}