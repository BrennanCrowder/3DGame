using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManagerScript : MonoBehaviour
{
    public GameObject menuCanvas;
    private static bool toggleMinimap;
    public GameObject settingCanvas;
    public GameObject slider;
    public GameObject musicObject;
    public GameObject RoomsParent;
    public GameObject[] Rooms;
    public GameObject onlyRoom;
    private bool inMenu = true;

    // Start is called before the first frame update
    void Start()
    {
        musicObject = GameObject.FindGameObjectWithTag("Music");
        // get the toggleminimap bool
        StartCoroutine("ChangeRoom");

    }

    public void ButtonStart()
    {
        inMenu = false;
        SceneManager.LoadScene(1);
    }

    public void ButtonSettings()
    {
        settingCanvas.SetActive(true);
        menuCanvas.SetActive(false);
    }

    public void ButtonQuit()
    {
        Debug.Log("Quitting Application...");
        Application.Quit();
    }

    public void SetMusicVolume(float volume)
    {
        musicObject.GetComponent<AudioSource>().volume = volume;
    }

    public void ButtonBack()
    {
        menuCanvas.SetActive(true);
        settingCanvas.SetActive(false);
    }

    public void ButtonToggleTimer(bool toggleTimer)
    {
        SceneManagerScript.timerOn = toggleTimer;
    }

    public void ButtonToggleDevMiniMap()
    {
        if(toggleMinimap)
        {
            toggleMinimap = false;
        } 
        else
        {
            toggleMinimap = true;
        }
        Debug.Log("Mini map: " + toggleMinimap);
    }

    IEnumerator ChangeRoom()
    {
        while (inMenu) {
            yield return new WaitForSeconds(2);
            int randInt = Random.Range(0, Rooms.Length);
            SwapRooms(Rooms[randInt]);
        }
        yield return 1;
    }

    void SwapRooms(GameObject newRoom)
    {
        onlyRoom.transform.GetChild(0).gameObject.SetActive(false);
        onlyRoom.transform.GetChild(0).transform.SetParent(RoomsParent.transform);
        newRoom.transform.SetParent(onlyRoom.transform);
        newRoom.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
