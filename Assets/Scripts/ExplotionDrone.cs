using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplotionDrone : MonoBehaviour
{
    public GameObject explosion;
    public GameObject mainCam;
    public GameObject myCanvas;

    void OnCollisionEnter()
    {
        mainCam.transform.SetParent(null);
        GameObject expl = Instantiate(explosion, transform.position, Quaternion.identity);
        Destroy(gameObject);
        Destroy(expl, 7);
        Debug.Log("drone kamikaze oldu!");
        Destroy(myCanvas);
    }
}
