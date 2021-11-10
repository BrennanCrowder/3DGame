using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class RoomMatrixScript : MonoBehaviour
{
    public static GameObject northRoom;
    public static GameObject eastRoom;
    public static GameObject southRoom;
    public static GameObject westRoom;
    public static GameObject centerRoom;

    public void Awake()
    {
        RandomizeRoom.RoomsParent = gameObject;
    }

    private void Start()
    {
        
        int roomIndex = Random.Range(0, RandomizeRoom.Rooms.Length);
        #region RoomInit
        


        #endregion
    }

    public void AddRoom(GameObject curRoom, string dir) // dir == "N" || "E" || "S" || "W"
    {
        centerRoom = curRoom;

        curRoom.transform.SetParent(transform);

        if (dir == "N")
        {
            curRoom.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 9);
        } 
        else if (dir == "E")
        {
            curRoom.transform.position = new Vector3(transform.position.x + 9, transform.position.y, transform.position.z);
        }
        else if (dir == "S")
        {
            curRoom.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 9);
        }
        else if (dir == "W")
        {
            curRoom.transform.position = new Vector3(transform.position.x - 9, transform.position.y, transform.position.z);
        } 
        else
        {
            Debug.Log("ERROR: Direction String | RoomMatrixScript(AddRoom)");
        }
        
    }

    public void RemoveRoom(GameObject oldRoom)
    {

    }
}
