using UnityEngine;
using System.Collections;

public class Syringe : MonoBehaviour {

    public DemoManager managerScript = null;

    void OnTriggerEnter(Collider collider)
    {
        if (collider.name == "InjectionPlacement")
        {
            managerScript.doneInjection = true;
        }
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
