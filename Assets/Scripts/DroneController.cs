using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneController : MonoBehaviour
{
    public float flySpeed = 5f;

    public float turnSpeed = 1f;

    public float YawSpeed = 120;
    float Yaw;

    public GameObject prop;

    public GameObject leftSmallRocket;
    public GameObject leftBigRocket;
    public GameObject rightBigRocket;
    public GameObject rightSmallRocket;
    public GameObject rocketCam;
    public GameObject playerCam;
    public GameObject rocketCamUI;

    bool camTrans;

    void Update()
    {
        // move forward
        transform.position += transform.forward * Time.deltaTime * flySpeed;

        // inputs
        float horizontalInput = Input.GetAxis("Horizontal") * turnSpeed;
        float verticalInput = Input.GetAxis("Vertical") * turnSpeed;

        // YAW (turn left-right) , pitch (up-down), roll (rotate left-right)
        Yaw += horizontalInput * YawSpeed * Time.deltaTime;
        float pitch = Mathf.Lerp(0, 40, Mathf.Abs(verticalInput)) * Mathf.Sign(verticalInput);
        float roll = Mathf.Lerp(0, 70, Mathf.Abs(horizontalInput)) * -Mathf.Sign(horizontalInput);

        //apply rotation
        transform.localRotation = Quaternion.Euler(Vector3.up * Yaw + Vector3.right * pitch + Vector3.forward * roll);

        // rotating prop
        prop.transform.Rotate(0, 800 * Time.deltaTime, 0);

        //Rocket Controller
        if (Input.GetKeyDown(KeyCode.F))
        {
            leftSmallRocket.GetComponent<Rigidbody>().useGravity = true;
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            leftBigRocket.GetComponent<Rigidbody>().useGravity = true;
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            rightBigRocket.GetComponent<Rigidbody>().useGravity = true;
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            rightSmallRocket.GetComponent<Rigidbody>().useGravity = true;
        }

        //Transition Cam
        if (Input.GetKeyDown(KeyCode.B))
        {
            camTrans = !camTrans;
            rocketCam.SetActive(camTrans);
            rocketCamUI.SetActive(camTrans);
        }

    }

}