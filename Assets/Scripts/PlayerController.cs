using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        float horizontalInput = Input.GetAxis("Horizontal");

        
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);
    }




}
