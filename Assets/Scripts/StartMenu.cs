using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMenu : MonoBehaviour
{
    public GameObject prop;

    void Update()
    {
        prop.transform.Rotate(0, 200 * Time.deltaTime, 0);
    }

    public void startGame()
    {
        Debug.Log("oyun başladı");
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
        Debug.Log("special mode girildi");
    }

    public void quitGame()
    {
        Application.Quit();
        Debug.Log("oyundan çıkış yapıldı");
    }

   
}
