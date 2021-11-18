using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomScript : MonoBehaviour
{
    public GameObject northDoor;
    public GameObject eastDoor;
    public GameObject southDoor;
    public GameObject westDoor;

    
    private void OnEnable()
    {
        northDoor.transform.GetChild(0).localRotation = Quaternion.Euler(0,0,0);
        eastDoor.transform.GetChild(0).localRotation = Quaternion.Euler(0, 0, 0);
        southDoor.transform.GetChild(0).localRotation = Quaternion.Euler(0, 0, 0);
        westDoor.transform.GetChild(0).localRotation = Quaternion.Euler(0, 0, 0);

    }
    
    public void OnDisable()
    {
        dontDisable = "";
    }

    IEnumerator waitforAnim(Animator anim)
    {
        yield return new WaitForSeconds(anim.GetCurrentAnimatorStateInfo(0).length);
    }

    public string dontDisable;
    public string dontEnable;
    public void DisableDoor(string dir)
    {
        if (dir == dontDisable)
        {
            Debug.Log("Not Disabling: " + dir);
            return;
        }

        if (dir == "N")
        {
            //northDoor.transform.GetChild(0).GetComponent<Animator>().SetTrigger("Disabled");
            //waitforAnim(northDoor.transform.GetChild(0).GetComponent<Animator>());
            northDoor.SetActive(false);
        } 
        else if (dir == "S")
        {
            //southDoor.transform.GetChild(0).GetComponent<Animator>().SetTrigger("Disabled");
            //waitforAnim(southDoor.transform.GetChild(0).GetComponent<Animator>());
            southDoor.SetActive(false);
        }
        else if (dir == "E")
        {
            //eastDoor.transform.GetChild(0).GetComponent<Animator>().SetTrigger("Disabled");
            //waitforAnim(eastDoor.transform.GetChild(0).GetComponent<Animator>());
            eastDoor.SetActive(false);
        }
        else if (dir == "W")
        {
            //westDoor.transform.GetChild(0).GetComponent<Animator>().SetTrigger("Disabled");
            //waitforAnim(westDoor.transform.GetChild(0).GetComponent<Animator>());
            westDoor.SetActive(false);
        }
    }

    public void EnableDoors()
    {
        if (dontEnable != "N")
        {
            northDoor.SetActive(true);
        }
        if (dontEnable != "S")
        {
            southDoor.SetActive(true);
        }
        if (dontEnable != "E")
        {
            eastDoor.SetActive(true);
        }
        if (dontEnable != "W")
        {
            westDoor.SetActive(true);
        }
        
    }

    public bool animBool; // static

    public bool AnimisDone()
    {
        //Debug.Log(animBool);
        return animBool;
    }

    public void EnableDoor(string dir)
    {
        if (dir == "N")
        {
            northDoor.SetActive(true);
        }
        else if (dir == "S")
        {
            southDoor.SetActive(true);
        }
        else if (dir == "E")
        {
            eastDoor.SetActive(true);
        }
        else if (dir == "W")
        {
            westDoor.SetActive(true);
        }
    }

}
