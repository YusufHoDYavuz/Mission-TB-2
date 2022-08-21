using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasData : MonoBehaviour
{
    public GameObject myDrone;

    public Text fuel;
    public Text rpm;
    public Text ft;
    public Text leftFt;
    public Text velocity;
    public Text mass;

    float startMass;
    float startFuel;

     void Start()
    {
        startMass = 57f;
        startFuel = 48f;
        StartCoroutine(fuelDown());
    }

    void Update()
    {
        float dronePos = myDrone.transform.position.y;
        dronePos = Mathf.Round(dronePos * 10);
        ft.text = "FT: " + dronePos.ToString();
        leftFt.text = "ft: " + dronePos.ToString();

        velocity.text = "KNOT: 95";

        float droneRot = myDrone.transform.rotation.y;
        droneRot = Mathf.Round(droneRot * 100f);
        rpm.text = "RPM: " + droneRot.ToString() + "00";

        if (Input.GetKeyDown(KeyCode.G) || Input.GetKeyDown(KeyCode.H))
        {
            startMass -= 22f;
        }
        if (Input.GetKeyDown(KeyCode.F) || Input.GetKeyDown(KeyCode.J))
        {
            startMass -= 6.5f;
        }

        if (startMass <= 0)
        {
            startMass = 0;
        }
        mass.text = "YÜK: " + startMass.ToString() + "KG";

        fuel.text = "YKT: " + startFuel.ToString() + "LT";
    }

    IEnumerator fuelDown()
    {
        if (startFuel >= 0)
        {
            while (startFuel > 0)
            {
                yield return new WaitForSeconds(30.0f);
                startFuel--;
            }
        }
    }





}
