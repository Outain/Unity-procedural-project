using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seedDispersal : MonoBehaviour {
    public int numberOfSeeds;
    public GameObject seed;
    GameObject[] seeds;
    GameObject disperser;
    public float separationDistance;
    public Renderer rend;
    public float colourChangeSpeed = 10f;
    public float theta;
    public float power = 10f;
    public float xLowerBound, xUpperBound, yLowerBound, yUpperBound, zLowerBound, zUpperBound;

    // Use this for initialization
    void Start()
    {
        disperser = this.gameObject;
        rend = GetComponent<Renderer>();
        seeds = new GameObject[numberOfSeeds];

        ///this code needs to go into a method called on raycast from player
        //GetComponent<Collider>().enabled = false; //gets the collider out of the way so seeds can fly freely
        //for(int i =0; i< numberOfSeeds; i++)
        //{
        //    Vector3 pos = new Vector3(transform.position.x + i*separationDistance, transform.position.y, transform.position.z);
        //    seeds[i]= Instantiate(seed, pos, Random.rotation);
        //    Rigidbody rb = seeds[i].GetComponent<Rigidbody>();
        //    rb.AddForce(seeds[i].transform.forward* power);

        //}
        

        //Destroy(gameObject);
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

    void clicked()
    {
        Vector3 newPos = new Vector3(Random.Range(xLowerBound, xUpperBound)
                , Random.Range(yLowerBound, yUpperBound)
                , Random.Range(zLowerBound, zUpperBound)
                );
        Instantiate(disperser, newPos, transform.rotation); //replaces box with another in a different part of the map
        
        GetComponent<Collider>().enabled = false; //gets the collider out of the way so seeds can fly freely
        for (int i = 0; i < numberOfSeeds; i++)
        {
            Vector3 pos = new Vector3(transform.position.x + i * separationDistance, transform.position.y, transform.position.z);
            seeds[i] = Instantiate(seed, pos, Random.rotation);
            Rigidbody rb = seeds[i].GetComponent<Rigidbody>();
            rb.AddForce(seeds[i].transform.forward * power);

        }


        Destroy(gameObject);
    }
}
