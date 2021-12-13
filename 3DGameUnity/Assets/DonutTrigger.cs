using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DonutTrigger : MonoBehaviour
{
    public GameObject winObject;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Win();
        }
    }

    private void Win()
    {
        Cursor.lockState = CursorLockMode.None;
        Debug.Log("Winner!");
        winObject.SetActive(true);
        Destroy(gameObject);
    }
}
