using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwapScript : MonoBehaviour
{
    public Camera thirdPersonCamera;
    public Camera firstPersonCamera;

    void Start()
    {
        
        firstPersonCamera.enabled = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            if (firstPersonCamera.enabled)
            {
                SwitchToThirdPerson();
            }
            else if (thirdPersonCamera.enabled)
            {
                SwitchToFirstPerson();
            }
        }
    }

    void SwitchToFirstPerson()
    {
        
        thirdPersonCamera.enabled = false;
        firstPersonCamera.enabled = true;
    }

    void SwitchToThirdPerson()
    {
        
        firstPersonCamera.enabled = false;
        thirdPersonCamera.enabled = true;
    }
}
