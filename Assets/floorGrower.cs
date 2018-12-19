using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floorGrower : MonoBehaviour {
    public bool activated;
    float growNumber = 0;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (activated)
        {
            if (growNumber <= 1)
            {
                transform.localScale += new Vector3(0, Time.deltaTime, 0);
                growNumber += Time.deltaTime / 5;
            }
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "seed")
        {
            if (!activated)
            {
               // growTime();
                //Debug.Log("growTime");
                activated = true;
            }
        }
    }

    void growTime()
    {
        
    }
}
