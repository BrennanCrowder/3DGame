using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomizeRoom : MonoBehaviour
{
    public static GameObject RoomsParent;
    public static GameObject[] Rooms;
    public GameObject[] childrenObj;
    public GameObject thisRoom;
    public static int testCount = 0;
    public void Awake()
    {
        
        thisRoom = gameObject.transform.parent.gameObject;
        
        
    }
    public void Start()
    {
        Rooms = new GameObject[RoomsParent.transform.childCount];
        for (int i = 0; i < Rooms.Length; i++)
        {
            Rooms[i] = RoomsParent.transform.GetChild(i).gameObject;
        }
    }

    public void DirectionToRandomize (string dir)
    {
        /*testCount = 0;
        foreach (GameObject child in childrenObj)
        {
            if (child.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("Idle"))
            {
                Debug.Log("Anim is Done testCount++...");
                testCount++;
            }
        }
        */
        RoomsParent.GetComponent<RoomMatrixScript>().AddRoom(thisRoom, dir);
        
        
    }
}
