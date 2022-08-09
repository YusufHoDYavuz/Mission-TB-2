using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;

    [Range(0.1f,1f)]
    public float smoothSpeed = 0.5f;

    public void SetCameraTarget(Transform playerTransform)
    {
        target = playerTransform;
    }

    void LateUpdate()
    {
        Vector3 newPos = target.position + offset;
        transform.position = Vector3.Slerp(transform.position, newPos, smoothSpeed);
    }
}
