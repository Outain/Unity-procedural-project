using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planeSpawner : MonoBehaviour {
    public GameObject planeBoy;
    public GameObject[] hangar;
    public Renderer planeRend;
    public int planeCount;
    float planeCountX;
    public float planeWidth;
    int hangarNumber = 0;

    private void Awake()
    {

        planeCountX = Mathf.Sqrt(planeCount);
        hangar = new GameObject[planeCount];
        
    }

    // Use this for initialization
    void Start () {

        for (int i = 0; i < planeCountX; i++)
        {
            for (int j = 0; j < planeCountX; j++)
            {
                hangarNumber++;
                Vector3 planePos = new Vector3(i * planeWidth, 0, j * planeWidth);
                hangar[hangarNumber]= Instantiate(planeBoy, (Vector3.zero + planePos), transform.rotation);
                planeRend = hangar[hangarNumber].GetComponent<Renderer>();
                planeRend.material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
            }
        }
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
