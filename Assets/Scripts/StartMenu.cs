using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public GameObject prop;

    void Update()
    {
        prop.transform.Rotate(0, 200 * Time.deltaTime, 0);
    }

    public void startGame()
    {
        SceneManager.LoadScene(1);
    }

    public void levelMenu()
    {
        Debug.Log("level menüye girildi");
    }

    public void settingsMenu()
    {
        Debug.Log("ayaralara girildi");
    }

    public void specialMode()
    {
        SceneManager.LoadScene(6);
    }

    public void quitGame()
    {
        Application.Quit();
    }

   
}
