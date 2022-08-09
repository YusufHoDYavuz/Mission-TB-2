using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //public Transform target;
    //public Vector3 offset;
    //Vector3 velocity = Vector3.zero;

    [Range(0.1f, 1f)]
    public float smoothSpeed = 0.3f;

    [Range(0,1)]
    public float t;

    void Update()
    {
        //Vector3 newPos = target.position + offset;
        //transform.position = Vector3.SmoothDamp(transform.position, newPos, ref velocity, smoothSpeed);

        //transform.rotation = Quaternion.Euler(3f, target.rotation.eulerAngles.y, target.transform.rotation.eulerAngles.z);

        transform.rotation = Quaternion.Slerp(Quaternion.Euler(.1f,-.1f,0), Quaternion.Euler(.1f,.1f,0),t);

        t = Mathf.PingPong(Time.time * .5f, 0.8f);
    }


}
