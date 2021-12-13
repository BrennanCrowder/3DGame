using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class SceneManagerScript : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject Timer;
    public float currentTime = 0f;
    public static bool timerOn = false;
    

    public void Start()
    {
        if(timerOn)
        {
            Timer.transform.parent.gameObject.SetActive(true);
        } 
        else
        {
            Timer.transform.parent.gameObject.SetActive(false);
        }
    }

    private void Update()
    {
        currentTime = currentTime + Time.deltaTime;
        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);

        Timer.GetComponent<TextMeshProUGUI>().text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }


    public void ButtonResume()
    {
        Cursor.lockState = CursorLockMode.Locked;
        
        //Time.timeScale = 1;
        pauseMenu.SetActive(false);
    }

    public void ButtonMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void ButtonQuit()
    {
        Debug.Log("Quitting Application...");
        Application.Quit();
    }

}
