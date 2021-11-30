using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockTrigger : MonoBehaviour
{
    public string direction;
    public static bool hasKey;
    private void OnTriggerEnter(Collider other)
    {
        if (hasKey && other.CompareTag("Player"))
        {
            Debug.Log("PlayerEnteredTrigger");
            FollowState.unlockDoor = true;
            UnlockState.unlock = true;
            UnlockState.unlockDir = direction;
        }
    }

}
