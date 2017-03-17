using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    //static reference to itself

    //references (not static) to other scripts

        //how to call: GameManager.thisManager.otterScript

    // Start past de lockState van de muis aan.
    void Start () {
        Cursor.lockState = CursorLockMode.Locked;
	}
	
	// Update is called once per frame
	void Update () {
       
	}

}
