using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndDoorScript : MonoBehaviour
{
    //public bool openTheDoor = false;
    public static string unlockDir;
    public string thisDirection;


    private void Update()
    {
        if (unlockDir == null) { return; }
        if (unlockDir == thisDirection)
        {
            OpenDoor();
        }
        

    }
    public void OpenDoor()
    {
        Debug.Log("Opening Door");
        Destroy(gameObject);
    }
}
