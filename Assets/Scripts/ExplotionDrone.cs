using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExplotionDrone : MonoBehaviour
{
    public GameObject explosion;
    public GameObject mainCam;
    public GameObject myCanvas;
    public GameObject failedUI;
    public Text failedText;
    public GameObject homeUI;
    public Button nextLevelUI;

    void OnCollisionEnter()
    {
        mainCam.transform.SetParent(null);
        mainCam.SetActive(true);
        GameObject expl = Instantiate(explosion, transform.position, Quaternion.identity);
        Destroy(gameObject);
        Destroy(expl, 7);
        Debug.Log("drone kamikaze oldu!");
        Destroy(myCanvas);
        failedUI.SetActive(true);
        failedText.text = "Siha ile irtibat kesildi";
        homeUI.SetActive(false);
        nextLevelUI.interactable = false;
    }
}
