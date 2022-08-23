using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelOne : MonoBehaviour
{
    public GameObject infoUI;

    void Start()
    {
        Destroy(infoUI,9);
    }

    public void goMenu()
    {
        SceneManager.LoadScene(0);
    }
    
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
