﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waveCubeFirst : MonoBehaviour {
    float xPos, yPos, zPos;
    float theta;
    public float frequency;
    public float waveLength;
    public float velocity;

	// Use this for initialization
	void Start () {
        theta = 0;
	}
	
	// Update is called once per frame
	void Update () {
        theta += Time.deltaTime*frequency;
        float yOffset = Mathf.Cos(theta)*waveLength;
        float distance = velocity * Time.deltaTime; // Distance = velocity * Time
        transform.position = new Vector3(transform.position.x, yOffset, transform.position.z+distance);
		
	}
}
