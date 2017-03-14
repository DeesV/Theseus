using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

    public GameObject pauseMenuPanel;
    public GameObject hudPanel;
    public GameObject settingsMenuPanel;
    public GameObject mainMenuPanel;//if you press main menu
    bool menuCheck;


    void Awake ()
    {
        //Cursor.visible = (CursorLockMode.Locked != cursorMode);
        Cursor.lockState = CursorLockMode.Locked;
        mainMenuPanel.SetActive(false);
        pauseMenuPanel.SetActive(false);
        settingsMenuPanel.SetActive(false);
        hudPanel.SetActive(true);
        
    }
    void Update ()
    {
        if (Input.GetButtonDown("Escape"))
        {
            if (!pauseMenuPanel.activeSelf)
            {
                Cursor.lockState = CursorLockMode.Confined;
                pauseMenuPanel.SetActive(true);
                Time.timeScale = 0;
                print("hello " + Cursor.lockState);
            }
            else if (pauseMenuPanel.activeSelf)
            {
                ResumeGame();
            }
            if (settingsMenuPanel.activeSelf)
            {
                mainMenuPanel.SetActive(false);
                pauseMenuPanel.SetActive(true);
                settingsMenuPanel.SetActive(false);
            }
            if (mainMenuPanel.activeSelf)
            {
                mainMenuPanel.SetActive(false);
                pauseMenuPanel.SetActive(true);
            }
        }
    }
    public void ResumeGame ()
    {
        Cursor.lockState = CursorLockMode.Locked;
        pauseMenuPanel.SetActive(false);
        hudPanel.SetActive(true);
        Time.timeScale = 1;
    }
    public void Settings ()
    {
        pauseMenuPanel.SetActive(false);
        settingsMenuPanel.SetActive(true);
        Time.timeScale = 0;
    }
    public void MainMenu ()
    {
        mainMenuPanel.SetActive(true);
        pauseMenuPanel.SetActive(false);
    }   
    public void MainMenuYes ()
    {
        SceneManager.LoadScene("ArneScene");
        Time.timeScale = 1;
    }
    public void MainMenuNo ()
    {
        mainMenuPanel.SetActive(false);
        pauseMenuPanel.SetActive(true);
    }
}
