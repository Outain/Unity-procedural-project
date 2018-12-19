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
    bool checkerBoard;

    private void Awake()
    {

        planeCountX = Mathf.Sqrt(planeCount);
        hangar = new GameObject[planeCount];
        
    }

    // Use this for initialization
    void Start () {

        for (int i = 0; i < planeCountX; i++)
        {
            checkerBoard = !checkerBoard; //this enables the checkerBoard pattern, as each new line
            for (int j = 0; j < planeCountX; j++)
            {
                
                Vector3 planePos = new Vector3(i * planeWidth, 0, j * planeWidth);
                hangar[hangarNumber]= Instantiate(planeBoy, (Vector3.zero + planePos), transform.rotation);
                planeRend = hangar[hangarNumber].GetComponent<Renderer>();
                hangar[hangarNumber].transform.localScale = new Vector3(1, 0.3f, 1);
                //planeRend.material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
                if (checkerBoard)
                {
                    planeRend.material.color = Color.white;
                }
                else
                {
                    planeRend.material.color = Color.black;
                }
                checkerBoard = !checkerBoard;
                hangarNumber++;
            }
        }
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
