using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireButtonBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            //Debug.Log(ray);
            if(Physics.Raycast(ray, out hit))
            {
                //Debug.Log(hit.transform.name);
                if(hit.transform.name == "FireButton")
                {
                    Debug.Log("Hit");
                }
            }
        }
    }
}
