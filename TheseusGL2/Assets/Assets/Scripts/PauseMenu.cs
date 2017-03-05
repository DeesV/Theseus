using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

    public GameObject pauseMenuPanel;
    public GameObject hudPanel;

    

    void Awake ()
    {
        pauseMenuPanel.SetActive(false);
    }
    void Update ()
    {
        if (Input.GetButtonDown("Escape"))
        {
            if (pauseMenuPanel.activeSelf)
            {
                pauseMenuPanel.SetActive(false);
                Time.timeScale = 1;
            }
            else
            {
                pauseMenuPanel.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }
    public void ResumeGame ()
    {
        pauseMenuPanel.SetActive(false);
        Time.timeScale = 1;
    }
    public void Settings ()
    {
        pauseMenuPanel.SetActive(false);
    }
    public void MainMenu ()
    {
        pauseMenuPanel.SetActive(false);
        SceneManager.LoadScene("ArneScene");
        Time.timeScale = 1;
    }
}
