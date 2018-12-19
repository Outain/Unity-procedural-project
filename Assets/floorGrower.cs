using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floorGrower : MonoBehaviour {
    public bool activated;
    float growNumber = 0;
    float finalHue;
    public Renderer rend;
    

    // Use this for initialization
    void Start () {
        rend = GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update () {
        if (activated)
        {
            if (growNumber <= finalHue) //this scales how large each floor tile will grow based on its color
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
            seedValues seedScript = collision.gameObject.GetComponent<seedValues>();
            finalHue = seedScript.hue;
            if (!activated)
            {
                // growTime();
                //Debug.Log("growTime");
                rend.material.color = Color.HSVToRGB(finalHue, 1, 1);
                activated = true;
            }
        }
    }

    void growTime()
    {
        
    }
}
