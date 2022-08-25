using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneSmokes : MonoBehaviour
{
    public GameObject smokes;

    bool smokesOpenClose;

    public void changeSmoke()
    {
        smokesOpenClose = !smokesOpenClose;
        smokes.SetActive(smokesOpenClose);
    }
}
