using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneManagerScript : MonoBehaviour
{
    public GameObject pauseMenu;

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
