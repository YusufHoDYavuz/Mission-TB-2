using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    Vector3 velocity = Vector3.zero;

    [Range(0.1f, 1f)]
    public float smoothSpeed = 0.3f;

    void Update()
    {
        Vector3 newPos = target.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position, newPos, ref velocity, smoothSpeed);
    }


}
