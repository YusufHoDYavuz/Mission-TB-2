using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMenu : MonoBehaviour
{

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

    public void quitGame()
    {
        Application.Quit();
        Debug.Log("oyundan çıkış yapıldı");
    }

   
}
