using UnityEngine;
using System.Collections;

public class UltraSoundScan : MonoBehaviour {

    public RectTransform scanImage = null;
    public DemoManager managerScript = null;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    void OnTriggerEnter(Collider collider)
    {
        if (collider.name == "AbdomenCollision")
        {
            managerScript.doneUltraSound = true;
        }

        if(collider.name == "Steel_Table_A_Bag" && managerScript.doneUltraSound)
        {
            managerScript.returnedTransducer = true;
        }
    }

    void OnTriggerStay(Collider collider)
    {

        
        if (collider.name == "AbdomenCollision")
        {
            if (!scanImage.gameObject.activeSelf)
                scanImage.gameObject.SetActive(true);

            //Debug.Log("hit : " + new Vector2(collider.ClosestPointOnBounds(transform.position).x, collider.ClosestPointOnBounds(transform.position).z));
            scanImage.anchoredPosition = new Vector2((collider.ClosestPointOnBounds(transform.position).x + 3) * 2000/.4f, (collider.ClosestPointOnBounds(transform.position).z - .6f) * 1540/.5f - 1800);
        }
    }
}
