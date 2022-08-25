using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IsFinished : MonoBehaviour
{
    public void PassLevel(int levelIndex)
    {
        int currentLevel = SceneManager.GetActiveScene().buildIndex;

        if (currentLevel >= PlayerPrefs.GetInt("levelsUnlocked"))
        {
            PlayerPrefs.SetInt("levelsUnlocked", currentLevel + 1);
        }

        SceneManager.LoadScene(levelIndex);
    }
}