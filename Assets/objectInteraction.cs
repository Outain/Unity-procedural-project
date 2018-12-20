using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectInteraction : MonoBehaviour
{
    public Camera cam;


    // Use this for initialization
    void Start()
    {

        cam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            Ray ray = cam.ViewportPointToRay(cam.ScreenToViewportPoint(Input.mousePosition));
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 1000))
                if (hit.transform.tag == "interactable")
                { 
                    hit.transform.gameObject.SendMessage("clicked");
                   
                    //Destroy(hit.transform.gameObject);
                }
                
        }
    }

}

