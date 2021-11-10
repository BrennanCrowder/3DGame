using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomizeRoom : MonoBehaviour
{
    public static GameObject RoomsParent;
    public static GameObject[] Rooms;
    public GameObject thisRoom;

    public void Awake()
    {
        thisRoom = gameObject.transform.parent.gameObject;

        Rooms = new GameObject[RoomsParent.transform.childCount];
        for (int i = 0; i <  Rooms.Length; i++)
        {
            Rooms[i] = RoomsParent.transform.GetChild(i).gameObject;
        }
    }

    public void DirectionToRandomize (Collider trigger)
    {

    }
}
