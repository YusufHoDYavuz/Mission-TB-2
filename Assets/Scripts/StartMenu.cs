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

    AudioSource audioSource;

    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    void Update()
    {
        prop.transform.Rotate(0, 200 * Time.deltaTime, 0);
    }

    public void startGame()
    {
        StartCoroutine(playGame());
        audioSource.Play();
    }

    public void levelMenu()
    {
        levelMenuUI.SetActive(true);
        audioSource.Play();

    }

    public void homeMenuFromLevelMenu()
    {
        levelMenuUI.SetActive(false);
        audioSource.Play();
    }

    public void settingsMenu()
    {
        settingMenuUI.SetActive(true);
        audioSource.Play();
    }
    
    public void fromSettingsMenu()
    {
        settingMenuUI.SetActive(false);
        audioSource.Play();
    }

    public void specialMode()
    {
        StartCoroutine(playSpecialMode());
        audioSource.Play();
    }

    public void quitGame()
    {
        audioSource.Play();
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
