using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seedDispersal : MonoBehaviour {
    public int numberOfSeeds;
    public GameObject seed;
    GameObject[] seeds;
    public float separationDistance;
    public Renderer rend;
    public float colourChangeSpeed = 10f;
    public float theta;
    public float power = 10f;

    // Use this for initialization
    void Start()
    {
        rend = GetComponent<Renderer>();
        seeds = new GameObject[numberOfSeeds];

        ///this code needs to go into a method called on raycast from player
        
        for(int i =0; i< numberOfSeeds; i++)
        {
            Vector3 pos = new Vector3(transform.position.x + i*separationDistance, transform.position.y, transform.position.z);
            seeds[i]= Instantiate(seed, pos, Random.rotation);
            Rigidbody rb = seeds[i].GetComponent<Rigidbody>();
            rb.AddForce(seeds[i].transform.forward* power);

        }
        

        Destroy(gameObject);
    }
	
	// Update is called once per frame
	void Update () {
        theta += Time.deltaTime * colourChangeSpeed;
        if (theta >= 1)
        {
            theta--;
        }
        rend.material.color = Color.HSVToRGB(theta, 1, 1);
	}
}
