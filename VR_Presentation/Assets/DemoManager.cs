using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DemoManager : MonoBehaviour {

    public GameObject transducer = null;
    public GameObject ecg0 = null;
    public GameObject ecg1 = null;
    public GameObject ecg2 = null;
    public GameObject ecg3 = null;
    public GameObject ecg4 = null;
    public GameObject syringe = null;

    public GameObject ultraSoundCollision = null;
    public GameObject ecg0Collision = null;
    public GameObject ecg1Collision = null;
    public GameObject ecg2Collision = null;
    public GameObject ecg3Collision = null;
    public GameObject ecg4Collision = null;
    public GameObject syringeCollision = null;

    public RectTransform scanImage = null;
    public Text instructionText = null;
    
    public bool doneUltraSound = false;
    public bool returnedTransducer = false;
    public bool doneSensor0 = false;
    public bool doneSensor1 = false;
    public bool doneSensor2 = false;
    public bool doneSensor3 = false;
    public bool doneSensor4 = false;
    public bool doneInjection = false;

	// Use this for initialization
	void Start () {
        /*
        transducer.GetComponent<Leap.Unity.LeapRTS>().enabled = true;
        ecg0.GetComponent<Leap.Unity.LeapRTS>().enabled = false;
        ecg1.GetComponent<Leap.Unity.LeapRTS>().enabled = false;
        ecg2.GetComponent<Leap.Unity.LeapRTS>().enabled = false;
        ecg3.GetComponent<Leap.Unity.LeapRTS>().enabled = false;
        ecg4.GetComponent<Leap.Unity.LeapRTS>().enabled = false;
        syringe.GetComponent<Leap.Unity.LeapRTS>().enabled = false;
        */

        ecg0Collision.SetActive(false);
        ecg1Collision.SetActive(false);
        ecg2Collision.SetActive(false);
        ecg3Collision.SetActive(false);
        ecg4Collision.SetActive(false);
        syringeCollision.SetActive(false);

        instructionText.text = "Pick up Transducer and scan patient.";

    }

    // Update is called once per frame
    void Update ()
    {
        if (doneUltraSound && ultraSoundCollision.activeSelf)
        {
            instructionText.text = "Return Transducer to tray.";
        }
        /*
        if (returnedTransducer && ultraSoundCollision.activeSelf && !LPinchDetector.IsPinching && !RPinchDetector.IsPinching)
        {
            ultraSoundCollision.SetActive(false);
            instructionText.text = "Place ECG sensors on patient.";
            transducer.GetComponent<Leap.Unity.LeapRTS>().enabled = false;
            ecg0.GetComponent<Leap.Unity.LeapRTS>().enabled = true;
            ecg0Collision.SetActive(true);
        }
        
        if(doneSensor0 && ecg0.GetComponent<Leap.Unity.LeapRTS>().enabled && !LPinchDetector.IsPinching && !RPinchDetector.IsPinching)
        {
            instructionText.text = "Four sensors left.";
            ecg0.GetComponent<Leap.Unity.LeapRTS>().enabled = false;
            ecg0Collision.SetActive(false);
            ecg1.GetComponent<Leap.Unity.LeapRTS>().enabled = true;
            ecg1Collision.SetActive(true);
        }
        if (doneSensor1 && ecg1.GetComponent<Leap.Unity.LeapRTS>().enabled && !LPinchDetector.IsPinching && !RPinchDetector.IsPinching)
        {
            instructionText.text = "Three sensors left.";
            ecg1.GetComponent<Leap.Unity.LeapRTS>().enabled = false;
            ecg1Collision.SetActive(false);
            ecg2.GetComponent<Leap.Unity.LeapRTS>().enabled = true;
            ecg2Collision.SetActive(true);
        }
        if (doneSensor2 && ecg2.GetComponent<Leap.Unity.LeapRTS>().enabled && !LPinchDetector.IsPinching && !RPinchDetector.IsPinching)
        {
            instructionText.text = "Two sensors left.";
            ecg2.GetComponent<Leap.Unity.LeapRTS>().enabled = false;
            ecg2Collision.SetActive(false);
            ecg3.GetComponent<Leap.Unity.LeapRTS>().enabled = true;
            ecg3Collision.SetActive(true);
        }
        if (doneSensor3 && ecg3.GetComponent<Leap.Unity.LeapRTS>().enabled && !LPinchDetector.IsPinching && !RPinchDetector.IsPinching)
        {
            instructionText.text = "One sensor left.";
            ecg3.GetComponent<Leap.Unity.LeapRTS>().enabled = false;
            ecg3Collision.SetActive(false);
            ecg4.GetComponent<Leap.Unity.LeapRTS>().enabled = true;
            ecg4Collision.SetActive(true);
        }
        if (doneSensor4 && ecg4.GetComponent<Leap.Unity.LeapRTS>().enabled && !LPinchDetector.IsPinching && !RPinchDetector.IsPinching)
        {
            instructionText.text = "Give Patient injection.";
            ecg4.GetComponent<Leap.Unity.LeapRTS>().enabled = false;
            ecg4Collision.SetActive(false);
            syringe.GetComponent<Leap.Unity.LeapRTS>().enabled = true;
            syringeCollision.SetActive(true);
        }
        */
        if (doneInjection)
        {
            instructionText.text = "Procedure complete.";
        }
    }
}
