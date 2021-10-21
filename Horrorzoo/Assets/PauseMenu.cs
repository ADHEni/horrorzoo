using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool GameIsPaused = false;
    public GameObject pauseMenu;

    void Start()
    {
        pauseMenu.SetActive(false);
       
    }
    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.E))
        {
            if (GameIsPaused)
            {
                Resume();
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;

            }
            else
            {
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                Pause();
            }
        }
    }

    public void Resume ()
    {
        Cursor.visible = false;
        Time.timeScale = 1f;
        GameIsPaused = false;
        pauseMenu.SetActive(false);
        

    }

    void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;

    }

    public void QuitGame()
    {
        Cursor.visible = false;
        Debug.Log("Raus mit de Viecher");
        Application.Quit();
    }

}
