using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

    GameObject pauseMenuPanel;
    

    void Awake ()
    {
        //pausemenu off
    }
    void Update ()
    {
        if (Input.GetButtonDown("Escape"))
        {
            //turn pausemenu on
            Time.timeScale = 0;
        }
    }
    public void ResumeGame ()
    {
        //turn pausemenu off
        Time.timeScale = 1;
    }
    public void Settings ()
    {
        //turn pausemenu off
        
    }
    public void MainMenu ()
    {
        //turn pausemenu off
        SceneManager.LoadScene("ArneScene");
        Time.timeScale = 1;
    }
}
