using UnityEngine;
using System.Collections;

public class ECGSensor : MonoBehaviour {

    public int sensorNum = 0;
    public DemoManager managerScript;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider collider)
    {
        if (collider.name == "ECGPlacement" && sensorNum == 0)
            managerScript.doneSensor0 = true;
        if (collider.name == "ECGPlacement (1)" && sensorNum == 1)
            managerScript.doneSensor1 = true;
        if (collider.name == "ECGPlacement (2)" && sensorNum == 2)
            managerScript.doneSensor2 = true;
        if (collider.name == "ECGPlacement (3)" && sensorNum == 3)
            managerScript.doneSensor3 = true;
        if (collider.name == "ECGPlacement (4)" && sensorNum == 4)
            managerScript.doneSensor4 = true;

    }
}
