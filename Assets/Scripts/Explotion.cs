using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explotion : MonoBehaviour
{
    public GameObject explosion;

    void OnCollisionEnter()
    {
        GameObject expl = Instantiate(explosion, transform.position, Quaternion.identity);
        Destroy(gameObject);
        Destroy(expl, 7);
        Debug.Log("hedef başarıyla vuruldu");
    }
}
