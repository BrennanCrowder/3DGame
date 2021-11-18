using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public bool flag = true;
    
    private void OnEnable()
    {
        transform.localRotation = Quaternion.Euler(0, 0, 0);
    }
    private void OnDisable()
    {
        transform.localRotation = Quaternion.Euler(0, 0, 0);
    }
    
    private void Update()
    {
        if (flag == true && GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("Idle"))
        {
            Debug.Log("Idle");
            //RoomScript.animBool = true;
            transform.parent.parent.GetComponent<RoomScript>().animBool = true;
            flag = false;
        }

        if (GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("DoorOpenCR"))
        {
            Debug.Log("NOT Idle");
            //RoomScript.animBool = false;
            transform.parent.parent.GetComponent<RoomScript>().animBool = false;
            flag = true;
        } 
        
        
    }

}
