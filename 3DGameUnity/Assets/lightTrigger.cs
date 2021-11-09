using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightTrigger : MonoBehaviour
{
    public GameObject[] torches;
    
    private void OnTriggerEnter(Collider other)
    {
        foreach (GameObject torch in torches)
        {
            torch.SetActive(true);
        }

    }
}
