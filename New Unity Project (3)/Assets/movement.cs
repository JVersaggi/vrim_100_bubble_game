using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    private Vector3 direction = Vector3.up;
    // Start is called before the first frame update
    void Start()
    {
        if(Application.isMobilePlatform)
        {
            GameObject cameraParent = new GameObject("camParent");
            cameraParent.transform.position = this.transform.position;
            this.transform.parent = cameraParent.transform;
            cameraParent.transform.Rotate(Vector3.right, 90);
        }
        StartCoroutine("Move");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * Time.deltaTime);

    }

    void flip()
    {
        if(direction == Vector3.up)
        {
            direction = Vector3.down;
        }
        else if(direction == Vector3.down)
        {
            direction = Vector3.up;
        }
        else if(direction == Vector3.right)
        {
            direction = Vector3.left;
        }
        else if(direction == Vector3.left)
        {
            direction = Vector3.right;
        }
    }

    IEnumerator Move() {
        while(true) {
            yield return new WaitForSeconds(3.5f);
            //transform.eulerAngles += new Vector3(0,0,180f);
            direction = direction * -1f;
        }
    }
}
