using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwapScript : MonoBehaviour
{
    public Camera firstCamera;
    public Camera secondCamera;

    void Start()
    {
        
        secondCamera.enabled = false;
    }

    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ToggleCameras();
        }
    }

    void ToggleCameras()
    {
        firstCamera.enabled = !firstCamera.enabled;
        secondCamera.enabled = !secondCamera.enabled;
    }
}
