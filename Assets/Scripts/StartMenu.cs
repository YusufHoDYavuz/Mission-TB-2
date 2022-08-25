using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public GameObject prop;
    public GameObject levelMenuUI;
    public GameObject settingMenuUI;

    public GameObject playBtnOn;

    void Update()
    {
        prop.transform.Rotate(0, 200 * Time.deltaTime, 0);
    }

    public void startGame()
    {
        StartCoroutine(playGame());
    }

    public void levelMenu()
    {
        levelMenuUI.SetActive(true);
        
    }

    public void homeMenuFromLevelMenu()
    {
        levelMenuUI.SetActive(false);
    }

    public void settingsMenu()
    {
        settingMenuUI.SetActive(true);
    }
    
    public void fromSettingsMenu()
    {
        settingMenuUI.SetActive(false);
    }

    public void specialMode()
    {
        StartCoroutine(playSpecialMode());
    }

    public void quitGame()
    {
        Application.Quit();
    }

    IEnumerator playGame()
    {
        playBtnOn.SetActive(true);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(1);
    }
    
    IEnumerator playSpecialMode()
    {
        playBtnOn.SetActive(true);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(6);
    }


}
