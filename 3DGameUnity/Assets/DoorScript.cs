using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public bool flag = true;
    
    private void OnEnable()
    {
        transform.localRotation = Quaternion.Euler(0, 0, 0);
        flag = true;
    }
    private void OnDisable()
    {
        transform.localRotation = Quaternion.Euler(0, 0, 0);
    }

    public bool tempflag;

    private void Update()
    {
       

        if (GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("DoorOpenCR"))
        {
            if (!tempflag)
            {
                //Debug.Log("NOT Idle");
                tempflag = true;
            }
            
            //RoomScript.animBool = false;
            transform.parent.parent.GetComponent<RoomScript>().animBool = false;
            flag = true;
        } 
        
        if (flag == true && GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("Idle")) //
        {
            //Debug.Log("Idle: " + name);
            //RoomScript.animBool = true;
            transform.parent.parent.GetComponent<RoomScript>().animBool = true;
            flag = false;
            tempflag = false;
        }


    }

}
