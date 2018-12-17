using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class segSpawner : MonoBehaviour
{
    public GameObject headPrefab, bodyPrefab;
    public GameObject[] segments;
    public int segmentNumber;

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
		
	}
}
