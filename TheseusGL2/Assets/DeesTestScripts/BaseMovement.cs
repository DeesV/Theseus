using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//DIT SCRIPT STAAT OP DE PLAYER, CAMERA IS CHILD VAN EEN EMPTYGAMEOBJECT DIE EEN CHILD IS VAN DE PLAYER.
public class BaseMovement : MonoBehaviour {

    Rigidbody playerRB;

    float baseSpeed;
    float moveSpeed;
    float runSpeed;
    public float camSpeed;
    public float jumpCastDistance;
    public float jumpHeigth;
    public Collider playerCol;
    public Vector3 crouchHeigth;
    bool running;
    public Animator playerAnim;

    // De start roept de player zijn rigidbody op. Mainly bedoeld voor de jump in dit geval.
    void Start() {
        playerRB = transform.GetComponent<Rigidbody>();
        playerCol = transform.GetComponent<CapsuleCollider>();
        baseSpeed = 7.5f;
        moveSpeed = baseSpeed;
        runSpeed = 30;
        running = true;
        

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
        //playerAnim.SetBool("Walking", true);



        if(Physics.Raycast(transform.position, -transform.up, jumpCastDistance)) {
            if (Input.GetButtonDown("Jump")) {
                playerRB.velocity = new Vector3(0, jumpHeigth, 0);
            }
            if (Input.GetButtonDown("Crouch")) {
                //playerCol. =- crouchHeigth;
            }
            if (Input.GetButton("Run")) {
                print("RunButtonIsWorking");
                if (running == true) {
                    print("running=TrueWorks");
                    moveSpeed += runSpeed;
                    running = false;
                }
                else if(running == false) {
                    print("running=falseWorks");
                    moveSpeed = baseSpeed;
                }


            }
        }

    }
}
