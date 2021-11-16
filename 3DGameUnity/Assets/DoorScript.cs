using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    private void OnEnable()
    {
        transform.localRotation = Quaternion.Euler(0, 0, 0);
    }
    private void OnDisable()
    {
        transform.localRotation = Quaternion.Euler(0, 0, 0);
    }
    
}
