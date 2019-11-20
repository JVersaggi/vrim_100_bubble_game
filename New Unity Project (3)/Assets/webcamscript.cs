using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class webcamscript : MonoBehaviour
{

    public GameObject webCameraPlane;
    // Start is called before the first frame update
    void Start()
    {

        Input.gyro.enabled = true;
        WebCamTexture webCameraTexture = new WebCamTexture();
        webCameraPlane.GetComponent<MeshRenderer>().material.mainTexture = webCameraTexture;
        webCameraTexture.Play();
    }

    // Update is called once per frame
    void Update()
    {
       Quaternion cameraRotation = new Quaternion(Input.gyro.attitude.x, Input.gyro.attitude.y, -Input.gyro.attitude.z, -Input.gyro.attitude.w);
       this.transform.localRotation = cameraRotation; 
    }
}
