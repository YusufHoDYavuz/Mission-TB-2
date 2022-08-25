using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadingPage : MonoBehaviour
{
    public GameObject loadingScreen;
    public Image barFill;

    public void LoadScene(int sceneId)
    {
        StartCoroutine(LoadSceneAsync(sceneId));
    }

    IEnumerator LoadSceneAsync(int sceneId)
    {
        yield return new WaitForSeconds(1);
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneId);

        loadingScreen.SetActive(true);

        while (!operation.isDone)
        {
            float progressValue = Mathf.Clamp01(operation.progress / 0.9f);

            barFill.fillAmount = progressValue;

            yield return null;
        }
    }
}
