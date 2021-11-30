using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]

public class RoomTriggerScript : MonoBehaviour
{
    public string direction;
    private bool flag = true;

    private void OnEnable()
    {
        flag = true;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) { // && flag
            //Debug.Log("Entered " + direction + " Trigger");
            gameObject.transform.parent.GetComponent<RandomizeRoom>().DirectionToRandomize(direction);
            flag = false;
        }
    }
}
