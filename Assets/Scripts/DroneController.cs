using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DroneController : MonoBehaviour
{
    public GameObject prop;

    public GameObject leftSmallRocket;
    public GameObject leftBigRocket;
    public GameObject rightBigRocket;
    public GameObject rightSmallRocket;
    public GameObject rocketCam;
    public GameObject playerCam;
    public GameObject rocketCamUI;
    public GameObject rocketTrigger;
    public GameObject mainCam;
    public GameObject homeUI;
    public GameObject pauseCanvas;
    public GameObject pauseNext;
    public Text pauseText;
    public GameObject nonePause;

    public Button leftSmallRocketUI;
    public Button leftBigRocketUI;
    public Button RightBigRocketUI;
    public Button RightSmallRocketUI;

    public Button upMove;
    public Button downMove;
    public Button leftMove;
    public Button rightMove;

    public GameObject camUI;
    public GameObject changeCam;

    public float droneSpeed = 10f;

    float goingUpDown, rotateRightLeft;

    void Awake()
    {
        Time.timeScale = 1;

    }

    void Start()
    {
        Invoke("camAnimNon", 12);
        Invoke("animsRemove", 13.2f);
        goingUpDown = 0f;
        rotateRightLeft = 0f;
    }

    void Update()
    {
        // move
        transform.position += transform.forward * droneSpeed * Time.deltaTime;

        if (Input.GetKey(KeyCode.W) || goingUpDown < 0f){
            transform.Rotate(0.5f, 0, 0);
        }
        if (Input.GetKey(KeyCode.S) || goingUpDown > 0f){
            transform.Rotate(-0.5f, 0, 0);
        }
        if (Input.GetKey(KeyCode.D) || rotateRightLeft < 0f)
        {
            transform.Rotate(0, 0.5f, -1.3f);
        }
        if (Input.GetKey(KeyCode.A) || rotateRightLeft > 0f)
        {
            transform.Rotate(0, -0.5f, 1.3f);
        }

        // rotating prop
        prop.transform.Rotate(0, 800 * Time.deltaTime, 0);

    }

    public void GoUpDown(float v)
    {
        goingUpDown = v;
    }

    public void RotateRightLeft(float v)
    {
        rotateRightLeft = v;
    }

    IEnumerator rocketUITrigger()
    {
        rocketTrigger.SetActive(true);
        yield return new WaitForSeconds(2);
        rocketTrigger.SetActive(false);
    }

    public void LeftMamC()
    {
        StartCoroutine("rocketUITrigger");
        leftSmallRocket.transform.SetParent(null);
        leftSmallRocket.GetComponent<Rigidbody>().useGravity = true;
        leftSmallRocketUI.interactable = false;
        Destroy(leftSmallRocket, 10);
    }
    
    public void LeftMamL()
    {
        StartCoroutine("rocketUITrigger");
        leftBigRocket.transform.SetParent(null);
        leftBigRocket.GetComponent<Rigidbody>().useGravity = true;
        leftBigRocketUI.interactable = false;
        Destroy(leftBigRocket, 10);
    }

    public void RightMamL()
    {
        StartCoroutine("rocketUITrigger");
        rightBigRocket.transform.SetParent(null);
        rightBigRocket.GetComponent<Rigidbody>().useGravity = true;
        RightBigRocketUI.interactable = false;
        Destroy(rightBigRocket, 10);
    }
    
    public void RightMamC()
    {
        StartCoroutine("rocketUITrigger");
        rightSmallRocket.transform.SetParent(null);
        rightSmallRocket.GetComponent<Rigidbody>().useGravity = true;
        RightSmallRocketUI.interactable = false;
        Destroy(rightSmallRocket, 10);
    }

    public void goToRocketCam()
    {
        mainCam.active = !mainCam.active;
        rocketCamUI.active = !rocketCamUI.active;
        rocketCam.active = !rocketCam.active;
        homeUI.SetActive(false);
        rocketCamUI.SetActive(true);
    }
    
    public void goToHomeCam()
    {
        mainCam.active = !mainCam.active;
        rocketCamUI.active = !rocketCamUI.active;
        rocketCam.active = !rocketCam.active;
        rocketCamUI.SetActive(false);
        homeUI.SetActive(true);
    }

    void camAnimNon()
    {
        mainCam.GetComponent<Animator>().enabled = false;
        homeUI.SetActive(true);
    }

    void animsRemove()
    {
        camUI.GetComponent<Animator>().enabled = false;
        upMove.GetComponent<Animator>().enabled = false;
        downMove.GetComponent<Animator>().enabled = false;
        leftMove.GetComponent<Animator>().enabled = false;
        rightMove.GetComponent<Animator>().enabled = false;
        changeCam.GetComponent<Animator>().enabled = false;
    }

    public void pauseGame()
    {
        Time.timeScale = 0f;
        pauseCanvas.SetActive(true);
        pauseNext.SetActive(false);
        nonePause.SetActive(true);
        pauseText.text = "Oyun Duraklatıldı";
    }
    
    public void NonePauseGame()
    {
        Time.timeScale = 1f;
        pauseCanvas.SetActive(false);
        nonePause.SetActive(false);
        pauseNext.SetActive(true);
    }

}
