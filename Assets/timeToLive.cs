using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timeToLive : MonoBehaviour {
    public float timeUntilDestroyed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timeUntilDestroyed -= Time.deltaTime;
        if(timeUntilDestroyed <= 0)
        {
            Destroy(gameObject);
        }
	}
}
