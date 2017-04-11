using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//DIT SCRIPT STAAT OP DE PLAYER, CAMERA IS CHILD VAN EEN EMPTYGAMEOBJECT DIE EEN CHILD IS VAN DE PLAYER.
public class BaseMovement : MonoBehaviour {

    Rigidbody playerRB;

    public float moveSpeed;
    public float camSpeed;
    public float jumpCastDistance;
    public float jumpHeigth;
    public Collider playerCol;
    public Vector3 crouchHeigth;

    // De start roept de player zijn rigidbody op. Mainly bedoeld voor de jump in dit geval.
    void Start() {
        playerRB = transform.GetComponent<Rigidbody>();
        playerCol = transform.GetComponent<CapsuleCollider>();
        
    }

	// FixedUpdate die de Movement aanroept
	void FixedUpdate () {
        Movement();
    }
    // De movement voor de player zijn model. Hier wordt de Horizontale as bestuurt qua rotation en wordt de movement geregeld. De jump zit hier ook in.
    // De verticale camera rotatie wordt geregeld in "Camera".
    void Movement() {

        transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed, 0, Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed);
        transform.Rotate(0, Input.GetAxis("Mouse X") * Time.deltaTime * camSpeed, 0);


        if(Physics.Raycast(transform.position, -transform.up, jumpCastDistance)) {
            if (Input.GetButtonDown("Jump")) {
                playerRB.velocity = new Vector3(0, jumpHeigth, 0);
            }
            else if (Input.GetButtonDown("Crouch")) {
                //playerCol.heigth =- crouchHeigth;
            }
        }

    }
}
