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
    public void Disable()
    {
        //EnableDoors();
        //waitforAnim(northDoor.transform.GetChild(0).GetComponent<Animator>());
       // waitforAnim(southDoor.transform.GetChild(0).GetComponent<Animator>());
        //waitforAnim(eastDoor.transform.GetChild(0).GetComponent<Animator>());
        //waitforAnim(westDoor.transform.GetChild(0).GetComponent<Animator>());
        //northDoor.transform.GetChild(0).GetComponent<Animator>().SetTrigger("Disabled");
        //southDoor.transform.GetChild(0).GetComponent<Animator>().SetTrigger("Disabled");
        //eastDoor.transform.GetChild(0).GetComponent<Animator>().SetTrigger("Disabled");
       // westDoor.transform.GetChild(0).GetComponent<Animator>().SetTrigger("Disabled");
        //gameObject.SetActive(false);
    }

    IEnumerator waitforAnim(Animator anim)
    {
        yield return new WaitForSeconds(anim.GetCurrentAnimatorStateInfo(0).length);
    }


    public void DisableDoor(string dir)
    {
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
        northDoor.SetActive(true);
        southDoor.SetActive(true);
        eastDoor.SetActive(true);
        westDoor.SetActive(true);
        
    }

    public bool AnimisDone()
    {

        if(eastDoor.transform.GetChild(0).GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("Door"))
        {
            return true;

        } else
        {
            return false;
        }
        
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
