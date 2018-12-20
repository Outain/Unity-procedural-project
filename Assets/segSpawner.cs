using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class segSpawner : MonoBehaviour
{
    public GameObject headPrefab, bodyPrefab;
    public GameObject[] segments;
    public int segmentNumber;
    float theta, offSet;
    public float colourChangeSpeed;

    // Use this for initialization
    void Start()
    {
        segments = new GameObject[segmentNumber];
        for (int i = 0; i < segmentNumber; i++)
        {
            if (i == 0)
            {
                segments[i] = Instantiate(headPrefab, transform.position, transform.rotation);
                
            }
            else
            {
                Vector3 offset = new Vector3(0, 0, i * -1.1f);
                segments[i] = Instantiate(bodyPrefab, transform.position + offset, transform.rotation);
            }
            segments[i].transform.parent = transform;
            
        }

    }

    // Update is called once per frame
    void Update () {
        theta -= Time.deltaTime*colourChangeSpeed;
        if(theta <= 0)
        {
            theta++;
        }
       
        for (int i = 0; i< segmentNumber; i++)
        {
            
            float hueValue = (i / (float)segmentNumber)+theta;
            if (hueValue >= 1)
            {
                hueValue--; //hue values can range from 0 to 1, and much like angles 0 is the same as 360 so this keeps the colour changing in a smooth pattern
            }
            segments[i].GetComponent<Renderer>().material.color = Color.HSVToRGB(hueValue, 1, 1);
        }

		
	}

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawCube(transform.position, new Vector3(1, 1, 1));
    }
}
