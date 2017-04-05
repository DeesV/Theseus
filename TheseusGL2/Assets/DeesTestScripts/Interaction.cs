using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour {

    public float interactDistance;
    RaycastHit interactHit;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void InteractDetect() {
        if(Physics.Raycast(transform.position, transform.forward, out interactHit, interactDistance)) {
            if(interactHit.transform.tag == "InteractableSword") {
                InteractWeapon();
            }
            else if(interactHit.transform.tag == "InteractableNPC") {
                InteractNPC();
            }
        }
    }

    void InteractWeapon() {

    }

    void InteractNPC() {

    }
}
