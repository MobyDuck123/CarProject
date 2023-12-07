using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckDeath : MonoBehaviour
{
   private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entered" + other.name);
        if (other.CompareTag("Car"))
        {
            Debug.Log("Found Player" + other.name);
            other.GetComponent<Rigidbody>().isKinematic = false;
        }
    }
}
