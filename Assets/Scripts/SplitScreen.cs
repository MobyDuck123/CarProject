using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplitScreenController : MonoBehaviour
{
    public Camera player1FirstPersonCamera;
    public Camera player2FirstPersonCamera;
    public Camera player1ThirdPersonCamera;
    public Camera player2ThirdPersonCamera;

    void Start()
    {
        player1FirstPersonCamera.enabled = false;
        player2FirstPersonCamera.enabled = false;
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.BackQuote))
        {

            ConfigureSplitScreen();
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            if (player1FirstPersonCamera.enabled)
            {
                SwitchToThirdPerson();
            }
            else if (player1ThirdPersonCamera.enabled)
            {
                SwitchToFirstPerson();
            }
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            if (player2FirstPersonCamera.enabled)
            {
                SwitchToThirdPerson();
            }
            else if (player2ThirdPersonCamera.enabled)
            {
                SwitchToFirstPerson();
            }
        }
    }

    void ConfigureSplitScreen()
    {
        player1FirstPersonCamera.rect = new Rect(0f, 0f, 0.5f, 1f);
        player1ThirdPersonCamera.rect = new Rect(0f, 0f, 0.5f, 1f);


        player2FirstPersonCamera.rect = new Rect(0.5f, 0f, 0.5f, 1f);
        player2ThirdPersonCamera.rect = new Rect(0.5f, 0f, 0.5f, 1f);
    }

    void SwitchToFirstPerson()
    {

        player1ThirdPersonCamera.enabled = false;
        player1FirstPersonCamera.enabled = true;
        player2ThirdPersonCamera.enabled = false;
        player2FirstPersonCamera.enabled = true;
    }

    void SwitchToThirdPerson()
    {

        player1FirstPersonCamera.enabled = false;
        player1ThirdPersonCamera.enabled = true;
        player2FirstPersonCamera.enabled = false;
        player2ThirdPersonCamera.enabled = true;
    }
}