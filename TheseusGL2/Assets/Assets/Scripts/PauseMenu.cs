using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

    public GameObject pauseMenuPanel;
    public GameObject hudPanel;
    public GameObject settingsMenuPanel;
    public GameObject mainMenuPanel;//if you press main menu

    /*public enum MenuMode {Ingame, Paused, Settings, ToMain};
    public MenuMode currentMode;*/


    void Awake ()
    {
        
    }
    void Update ()
    {

    }
    //to ingame
    public void ActivateInGame ()
    {
        SceneManager.LoadScene("ArneScene2");
        hudPanel.SetActive(true);
        pauseMenuPanel.SetActive(false);
    }
    //out of the game
    public void DeActivateInGame ()
    {
        hudPanel.SetActive(false);
        pauseMenuPanel.SetActive(false);
        //SceneManager.LoadScene("ArneScene");  //CAUSES A ERROR WHEN ACTIVATED; MULTIPLE EVENTSYSTEMS IN SCENE, THIS IS NOT SUPPORTED.
    }
}
