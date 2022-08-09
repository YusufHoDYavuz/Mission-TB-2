using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneController : MonoBehaviour
{
    public float flySpeed = 5f;

    public float YawSpeed = 120;
    float Yaw;

    public GameObject prop;

    public GameObject leftRocket;
    public GameObject rightRocket;
    public GameObject rocketCam;
    public GameObject playerCam;
    public GameObject rocketCamUI;

    bool camTrans;

    void FixedUpdate()
    {
        // move forward
        transform.position += transform.forward * Time.deltaTime * flySpeed;

        // inputs
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // YAW (turn left-right) , pitch (up-down), roll (rotate left-right)
        Yaw += horizontalInput * YawSpeed * Time.deltaTime;
        float pitch = Mathf.Lerp(0, 30, Mathf.Abs(verticalInput)) * Mathf.Sign(verticalInput);
        float roll = Mathf.Lerp(0, 50, Mathf.Abs(horizontalInput)) * -Mathf.Sign(horizontalInput);

        //apply rotation
        transform.localRotation = Quaternion.Euler(Vector3.up * Yaw + Vector3.right * pitch + Vector3.forward * roll);

        // rotating prop
        prop.transform.Rotate(0, 800 * Time.deltaTime, 0);

        //Rocket Controller
        if (Input.GetKeyDown(KeyCode.G))
        {
            leftRocket.GetComponent<Rigidbody>().useGravity = true;
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            rightRocket.GetComponent<Rigidbody>().useGravity = true;
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
