using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireScript : MonoBehaviour
{
    public GameObject reticule;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Fire()
    {
        reticule = GameObject.Find("/Canvas/Reticule");
        //Debug.Log(reticule);
        Ray ray = Camera.main.ScreenPointToRay(reticule.transform.position);
        RaycastHit hit;
        Debug.Log(ray);
        if(Physics.Raycast(ray, out hit))
        {
            Debug.Log(hit.transform.name);
            if(hit.transform.tag == "unburst_bubble")
            {
                Debug.Log("Hit");
                GameObject hit_object = hit.transform.gameObject;
                hit_object.GetComponent<movement>().enabled = false;
                hit_object.GetComponent<SpriteRenderer>().enabled = false;
                GameObject animal = hit_object.transform.GetChild(0).gameObject;
                var animal_name = animal.GetComponent<SpriteRenderer>().sprite.name.Split('_')[1];
                Debug.Log("animal_" + animal_name + "_Happy");
                var sprite = Resources.Load<Sprite>("animal_" + animal_name + "_Happy");
                Debug.Log(sprite);
                animal.GetComponent<SpriteRenderer>().sprite = sprite;
            }
        }
    }
}
