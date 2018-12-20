using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floorGrower : MonoBehaviour {
    public bool activated;
    float growNumber = 0;
    float finalHue;
    public Renderer rend;
    public int bandNumber;
    public float scale = 10f;
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
            else
            {
                Vector3 ls = transform.localScale;
                ls.y = Mathf.Lerp(ls.y, growNumber*5 + (audioManager.bands[bandNumber] * scale), Time.deltaTime * 3.0f);
                transform.localScale = ls;
            }
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "seed")
        {
            
            if (!activated) { 

            seedValues seedScript = collision.gameObject.GetComponent<seedValues>();
            finalHue = seedScript.hue;
            Destroy(collision.gameObject);
            // growTime();
            //Debug.Log("growTime");
            rend.material.color = Color.HSVToRGB(finalHue, 1, 1);
            activated = true;
            bandNumber = (int)(finalHue * 9);
        }

             //the audio analyser had 9 bands in testing, this seemed like a simple way to divide the spread of different blocks into 9 different bands.
            //if(bandNumber == 9)
            //{
            //    bandNumber = 8; //this means there will be only 9 possible values, to align with the 9 bands.
            //}
            Debug.Log(bandNumber);
        }
    }

    void growTime()
    {
        
    }
}
