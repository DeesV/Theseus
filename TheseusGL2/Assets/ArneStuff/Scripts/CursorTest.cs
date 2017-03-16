using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorTest : MonoBehaviour {

    public CursorLockMode cursorMode;
   
    void Awake ()
    {
        //Cursor.lockState = CursorLockMode.Locked;
        //cursorMode = false;
        Cursor.lockState = cursorMode;
        //cursorMode = CursorLockMode.Locked;

    }
    void Start () {
        //Cursor.lockState = CursorLockMode.Locked;

    }
	void Update () {

        Ingame();
    
	}
    public void Ingame()
    {
        if (Input.GetButtonDown("Escape"))
        {
            if (cursorMode == CursorLockMode.Confined)
            {
                Cursor.lockState = CursorLockMode.Locked;
            }
            if (cursorMode == CursorLockMode.Locked)
            {
                Cursor.lockState = CursorLockMode.Confined;
            }
        }
    }
}
