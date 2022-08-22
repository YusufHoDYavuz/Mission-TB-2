using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelOne : MonoBehaviour
{
    public GameObject infoUI;

    void Start()
    {
        Destroy(infoUI,9);
    }
}
