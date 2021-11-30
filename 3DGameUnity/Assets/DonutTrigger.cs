using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DonutTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Win();
        }
    }

    private void Win()
    {
        Debug.Log("Winner!");
        Destroy(gameObject);
    }
}
