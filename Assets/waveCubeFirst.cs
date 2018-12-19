using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waveCubeFirst : MonoBehaviour {
    float xPos, yPos, zPos;
    float theta;
    public float frequency;
    public float waveLength;
    public float velocity;
    public GameObject[] wayPoints;
    public GameObject blankTransform;
    public int numberOfWaypoints;
    public int wayPointNumber;
    public float xLowerBound, xUpperBound, yLowerBound, yUpperBound, zLowerBound, zUpperBound;
    Vector3 targetDirection;
    public float turningSpeed;

	// Use this for initialization
	void Start () {
        wayPointNumber = 0;
        theta = 0;
        wayPoints = new GameObject[numberOfWaypoints];
        for(int i=0; i<numberOfWaypoints; i++)
        {
            wayPoints[i] = Instantiate(blankTransform);
            wayPoints[i].transform.position = new Vector3(Random.Range(xLowerBound, xUpperBound)
                , Random.Range(yLowerBound, yUpperBound)
                , Random.Range(zLowerBound, zUpperBound)
                );
            Debug.Log(wayPoints[i].transform.position);
        }
     
	}
	
	// Update is called once per frame
	void Update () {
        theta += Time.deltaTime*frequency;
        float yOffset = Mathf.Cos(theta)*waveLength*Time.deltaTime;
        float distance = velocity * Time.deltaTime; // Distance = velocity * Time
        
        transform.Translate(0,yOffset,distance);

        targetDirection = (wayPoints[wayPointNumber].transform.position-transform.position);
        float step = turningSpeed * Time.deltaTime;
        Vector3 newDir = Vector3.RotateTowards(transform.forward, targetDirection, step, 0.0f);
        Debug.DrawRay(transform.position, newDir, Color.red);

        
        transform.rotation = Quaternion.LookRotation(newDir);
        float dist = Vector3.Distance(transform.position, wayPoints[wayPointNumber].transform.position);
        if(dist <= 3)
        {
            wayPointNumber++;
        }
        if (wayPointNumber > numberOfWaypoints) {
            wayPointNumber = 0;
        }
    }
}
