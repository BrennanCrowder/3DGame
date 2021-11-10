using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomMatrixScript : MonoBehaviour
{
    public GameObject northRoom;
    public GameObject eastRoom;
    public GameObject southRoom;
    public GameObject westRoom;
    public GameObject centerRoom;

    public void AddRoom(GameObject newRoom, string dir) // dir == "N" || "E" || "S" || "W"
    {
        newRoom.transform.SetParent(this.transform);
        if (dir == "N")
        {
            newRoom.transform.position = new Vector3(this.transform.position.x + 9, transform.position.y, transform.position.z + 9);
        } 
        else if (dir == "E"){
           
        }
        else if (dir == "S")
        {

        }
        else if (dir == "W")
        {

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
