using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyTriggerScript : MonoBehaviour
{
    public bool follow;


    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player Enter");
            follow = true;
        }

    }
}
