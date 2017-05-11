using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour {

    public float interactDistance;
    RaycastHit interactHit;
    bool interactRC;

    //Arne edited this
    //public NPC _NPC;

	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        InteractDetect();
	}

    public void InteractDetect() {
        Debug.DrawRay(transform.position, transform.forward, Color.green);
        if (Physics.Raycast(transform.position, transform.forward, out interactHit, interactDistance)){
            if(interactHit.transform.tag == "InteractableSword") {
                InteractWeapon();
            }
            else if(interactHit.transform.tag == "InteractableNPC") {
                InteractNPC();
            }
        }
    }

    void InteractWeapon() {
        if (Input.GetButtonDown("Interact")) {
            print("PickedUp!");
        }
        print("Weapon!");
    }

    void InteractNPC() {
        //_NPC.PlayerInteracts();
    }
}
