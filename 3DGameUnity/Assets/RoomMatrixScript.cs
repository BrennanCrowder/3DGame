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
    public GameObject pastRoom;
    public GameObject roomHolder;
    public GameObject endRoom;


    public void Awake()
    {
        RandomizeRoom.RoomsParent = gameObject;
    }

    private void Start()
    {
        //pastRoom = centerRoom;
        int roomIndex = Random.Range(0, RandomizeRoom.Rooms.Length);
        northRoom.GetComponentInChildren<RoomScript>().DisableDoor("S");
        southRoom.GetComponentInChildren<RoomScript>().DisableDoor("N");
        eastRoom.GetComponentInChildren<RoomScript>().DisableDoor("W");
        westRoom.GetComponentInChildren<RoomScript>().DisableDoor("E");
        #region RoomInit



        #endregion
    }

    public GameObject truePast;

    public void AddRoom(GameObject curRoom, string triggerDir) // dir == "N" || "E" || "S" || "W"
    {
        truePast = pastRoom;
        //Debug.Log("Current Room: " + curRoom.transform.parent.gameObject + " Past Room: " + pastRoom);
        if (curRoom.transform.parent.gameObject != pastRoom)
        {
            pastRoom = curRoom.transform.parent.gameObject;
            ResetMatrixLocation(curRoom.transform.parent.gameObject);
        }
        //curRoom.transform.SetParent(transform);

        else if (triggerDir == "N")
        {
            Randomize(northRoom);
            northRoom.GetComponentInChildren<RoomScript>().DisableDoor("S");
            
        } 
        else if (triggerDir == "E")
        {
            Randomize(eastRoom);
            
            eastRoom.GetComponentInChildren<RoomScript>().DisableDoor("W");
            
        }
        else if (triggerDir == "S")
        {
            Randomize(southRoom);
            southRoom.GetComponentInChildren<RoomScript>().DisableDoor("N");
        }
        else if (triggerDir == "W")
        {

            Randomize(westRoom);
            westRoom.GetComponentInChildren<RoomScript>().DisableDoor("E");
        } 
        else
        {
            Debug.Log("ERROR: Direction String | RoomMatrixScript(AddRoom)");
        }

        
    }

    void ResetMatrixLocation(GameObject newCenter)
    {
        Debug.Log("New Center: " + newCenter);
        northRoom.GetComponentInChildren<RoomScript>().dontDisable = "";
        southRoom.GetComponentInChildren<RoomScript>().dontDisable = "";
        eastRoom.GetComponentInChildren<RoomScript>().dontDisable = "";
        westRoom.GetComponentInChildren<RoomScript>().dontDisable = "";
        if (newCenter == northRoom)
        {
            
            Debug.Log("Moving rooms != " + newCenter);
            eastRoom.transform.localPosition = new Vector3(eastRoom.transform.localPosition.x, eastRoom.transform.localPosition.y, eastRoom.transform.localPosition.z + 9);
            southRoom.transform.localPosition = new Vector3(southRoom.transform.localPosition.x, southRoom.transform.localPosition.y, southRoom.transform.localPosition.z + 27);
            westRoom.transform.localPosition = new Vector3(westRoom.transform.localPosition.x, westRoom.transform.localPosition.y, westRoom.transform.localPosition.z + 9);

            //centerRoom.transform.localPosition = new Vector3(centerRoom.transform.localPosition.x, centerRoom.transform.localPosition.y, centerRoom.transform.localPosition.z + 18);

            Randomize(eastRoom);
            Randomize(southRoom);
            Randomize(westRoom);
            Randomize(centerRoom);

            northRoom = southRoom;
            southRoom = centerRoom;
            centerRoom = newCenter;

            northRoom.GetComponentInChildren<RoomScript>().DisableDoor("S");
            //southRoom.GetComponentInChildren<RoomScript>().DisableDoor("N");
            eastRoom.GetComponentInChildren<RoomScript>().DisableDoor("W");
            westRoom.GetComponentInChildren<RoomScript>().DisableDoor("E");
            southRoom.GetComponentInChildren<RoomScript>().dontDisable = "N";
        }
        else if (newCenter == eastRoom)
        {
            Debug.Log("Moving rooms != " +newCenter);
            northRoom.transform.localPosition = new Vector3(northRoom.transform.localPosition.x + 9, northRoom.transform.localPosition.y, northRoom.transform.localPosition.z);
            southRoom.transform.localPosition = new Vector3(southRoom.transform.localPosition.x + 9, southRoom.transform.localPosition.y, southRoom.transform.localPosition.z);
            westRoom.transform.localPosition = new Vector3(westRoom.transform.localPosition.x + 27, westRoom.transform.localPosition.y, westRoom.transform.localPosition.z);
            //centerRoom.transform.localPosition = new Vector3(centerRoom.transform.localPosition.x + 18, centerRoom.transform.localPosition.y, centerRoom.transform.localPosition.z);
            Randomize(northRoom);
            Randomize(southRoom);
            Randomize(westRoom);
            Randomize(centerRoom);

            eastRoom = westRoom;
            westRoom = centerRoom;
            centerRoom = newCenter;

            northRoom.GetComponentInChildren<RoomScript>().DisableDoor("S");
            southRoom.GetComponentInChildren<RoomScript>().DisableDoor("N");
            eastRoom.GetComponentInChildren<RoomScript>().DisableDoor("W");
            //westRoom.GetComponentInChildren<RoomScript>().DisableDoor("E");
            westRoom.GetComponentInChildren<RoomScript>().dontDisable = "E";
        }
        else if (newCenter == southRoom)
        {
            Debug.Log("Moving rooms != " + newCenter);
            eastRoom.transform.localPosition = new Vector3(eastRoom.transform.localPosition.x, eastRoom.transform.localPosition.y, eastRoom.transform.localPosition.z - 9);
            northRoom.transform.localPosition = new Vector3(northRoom.transform.localPosition.x, northRoom.transform.localPosition.y, northRoom.transform.localPosition.z - 27);
            westRoom.transform.localPosition = new Vector3(westRoom.transform.localPosition.x, westRoom.transform.localPosition.y, westRoom.transform.localPosition.z - 9);
            //centerRoom.transform.localPosition = new Vector3(centerRoom.transform.localPosition.x, centerRoom.transform.localPosition.y, centerRoom.transform.localPosition.z - 18);
            Randomize(eastRoom);
            Randomize(northRoom);
            Randomize(westRoom);
            Randomize(centerRoom);

            southRoom = northRoom;
            northRoom = centerRoom;
            centerRoom = newCenter;

           // northRoom.GetComponentInChildren<RoomScript>().DisableDoor("S");
            southRoom.GetComponentInChildren<RoomScript>().DisableDoor("N");
            eastRoom.GetComponentInChildren<RoomScript>().DisableDoor("W");
            westRoom.GetComponentInChildren<RoomScript>().DisableDoor("E");

            northRoom.GetComponentInChildren<RoomScript>().dontDisable = "S";
        }
        else if (newCenter == westRoom)
        {
            Debug.Log("Moving rooms != " + newCenter);
            eastRoom.transform.localPosition = new Vector3(eastRoom.transform.localPosition.x - 27 , eastRoom.transform.localPosition.y, eastRoom.transform.localPosition.z);
            southRoom.transform.localPosition = new Vector3(southRoom.transform.localPosition.x - 9 , southRoom.transform.localPosition.y, southRoom.transform.localPosition.z);
            northRoom.transform.localPosition = new Vector3(northRoom.transform.localPosition.x - 9 , northRoom.transform.localPosition.y, northRoom.transform.localPosition.z);
            //centerRoom.transform.localPosition = new Vector3(centerRoom.transform.localPosition.x - 18 , centerRoom.transform.localPosition.y, centerRoom.transform.localPosition.z);
            Randomize(eastRoom);
            Randomize(southRoom);
            Randomize(northRoom);
            Randomize(centerRoom);

            westRoom = eastRoom;
            eastRoom = centerRoom;
            centerRoom = newCenter;

            northRoom.GetComponentInChildren<RoomScript>().DisableDoor("S");
            southRoom.GetComponentInChildren<RoomScript>().DisableDoor("N");
            //eastRoom.GetComponentInChildren<RoomScript>().DisableDoor("W");
            westRoom.GetComponentInChildren<RoomScript>().DisableDoor("E");

            eastRoom.GetComponentInChildren<RoomScript>().dontDisable = "W";
        }
        else
        {
            Debug.Log("ERROR | RoomMatrixScript.ResetMatrixLocation(GameObject)");
        }

    }

    public void Randomize(GameObject room)
    {
        int randRoomIndex = Random.Range(0, roomHolder.transform.childCount);
        if (room != truePast)
        {
            room.transform.GetChild(0).GetComponent<RoomScript>().EnableDoors();
        }
        

        if (room.transform.childCount != 0 && room.transform.GetChild(0).GetComponent<RoomScript>().AnimisDone() && centerRoom.transform.GetChild(0).GetComponent<RoomScript>().AnimisDone())
        {
            //Debug.Log("Randomizing Room");
            
            centerRoom.transform.GetChild(0).GetComponent<RoomScript>().EnableDoors();
            RemoveRoom(room);

            Transform childObj = roomHolder.transform.GetChild(randRoomIndex); // gets new child
            childObj.parent = room.transform;
            childObj.localPosition = Vector3.zero;
            if (childObj.position == endRoom.transform.position)
            {
                //Debug.Log("Lowering Room");
                childObj.localPosition = new Vector3(0f, -9f, 0f);
            }

            childObj.gameObject.SetActive(true);
        } 
        else
        {
            //Debug.Log(room.name);
            //Debug.Log("Not Randomizing");
           // Debug.Log("Children #: " + room.transform.childCount);
            //Debug.Log("Child Room: " + room.transform.GetChild(0).name);
        }
        
    }

    public void RemoveRoom(GameObject oldRoom)
    {
        oldRoom = oldRoom.transform.GetChild(0).gameObject;// get current child
        oldRoom.transform.parent = roomHolder.transform; // set parent of current child to roomHolder
        
        oldRoom.transform.localPosition = Vector3.zero; // resets child local position
        
        oldRoom.GetComponent<RoomScript>().EnableDoors(); // Unactivates obj
        oldRoom.SetActive(false);
    }
    
}
