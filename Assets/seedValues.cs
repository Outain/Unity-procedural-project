using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seedValues : MonoBehaviour {
    public float hue;
    Renderer rend;
	// Use this for initialization
	void Start () {
        rend = GetComponent<Renderer>();
        hue = Random.Range(0f, 1f);
        rend.material.color = Color.HSVToRGB(hue, 1, 1);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
