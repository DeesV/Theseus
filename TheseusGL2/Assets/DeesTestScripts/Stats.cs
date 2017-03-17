using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour {

    bool statUp;
    GameObject statScreen;
    CameraScript mainCam;
    GameObject player;

	// Use this for initialization
	void Start () {
        statScreen = GameObject.FindWithTag("StatScreen");
        mainCam = CameraScript.thisCamera;
        player = GameObject.FindWithTag("Player");
        statScreen.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        StatPopUp();
	}

    public void StatPopUp() {
        if (Input.GetButton("Tab")) {
            statScreen.SetActive(true);
            mainCam.GetComponent<CameraScript>().enabled = false;
            player.GetComponent<BaseMovement>().enabled = false;
        }

#if !UNITY_EDITOR

            Cursor.lockState = CursorLockMode.Confined;
            return;
#endif
        else {
            statScreen.SetActive(false);
            mainCam.GetComponent<CameraScript>().enabled = true;
            player.GetComponent<BaseMovement>().enabled = true;
        }
    }
}
