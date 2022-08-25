using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IsFinishedLevel : MonoBehaviour
{
    public void LoadLevel(int levelIndex)
    {
        int currentLevel = SceneManager.GetActiveScene().buildIndex;

        if (currentLevel >= PlayerPrefs.GetInt("levelIsUnlocked"))
            PlayerPrefs.SetInt("levelIsUnlocked", currentLevel);

        SceneManager.LoadScene(levelIndex);
    }
}
