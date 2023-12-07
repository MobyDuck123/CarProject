using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewController : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;

    public float speed = 40.0f;
    public float rotateSpeed = 90.0f;
    public float defaultSpeed = 40.0f;
    public float sprintSpeed = 80.0f;

    public Rigidbody playerRb;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        GetInput();
        SetSpeed();
    }

    private void FixedUpdate()
    {
        MoveCarWithForceAndTorque();
        MoveCarWithPhysicsRotation();
    }

    private void MoveCarWithForceAndTorque()
    {
        if (verticalInput > 0.01f || verticalInput < -0.01f)
        {
            playerRb.AddTorque(transform.forward * verticalInput * speed);
        }

        if (horizontalInput > 0.01f || horizontalInput < -0.01f)
        {
            playerRb.AddTorque(transform.up * horizontalInput * rotateSpeed);
        }
    }

    private void MoveCarWithPhysicsRotation()
    {
        Vector3 moveDirection = transform.forward * verticalInput;
        playerRb.MovePosition(playerRb.position + moveDirection * speed * Time.fixedDeltaTime);

        float turnSpeed = horizontalInput * rotateSpeed * Time.fixedDeltaTime;
        Quaternion turnRotation = Quaternion.Euler(0f, turnSpeed, 0f);
        playerRb.MoveRotation(playerRb.rotation * turnRotation);
    }

    public void GetInput()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
    }

    public void SetSpeed()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = sprintSpeed;
        }
        else
        {
            speed = defaultSpeed;
        }
    }
}