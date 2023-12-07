using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float verticalInput;
    public float horizontalInput;
    public float rotateSpeed;
    public float speed = 20f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            MovementWithSpeed();
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {

            transform.Translate(transform.forward * (speed * 2) * verticalInput * Time.deltaTime);

        }

        //MovePlayerWithRotate(transform);
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
    }

    private void MovementWithTranslate(Transform player, float speed = 10.0f)
    {
        player.Translate(player.forward * speed * verticalInput * Time.deltaTime);
        player.Translate(player.right * speed * horizontalInput * Time.deltaTime);
    }

    private void MovePlayerWithRotate(Transform player, float rotateSpeed = 25.0f, float speed = 10.0f)
    {
        player.Translate(Vector3.forward * speed * verticalInput * Time.deltaTime);
        player.Rotate(Vector3.up, rotateSpeed * horizontalInput * Time.deltaTime);
        if (verticalInput > 0.01f || verticalInput < -0.01f)
       
        {
            player.Rotate(Vector3.up, rotateSpeed * horizontalInput * Time.deltaTime);
        }
    }

    private void MovementWithSpeed()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

       
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);
    }

}
