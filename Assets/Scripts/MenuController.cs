using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(1);
        SpawnObject.exit = false;
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void MenuGame()
    {
        SceneManager.LoadScene(0);
    }

}
