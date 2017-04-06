using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//DIT SCRIPT STAAT OP DE PLAYER, CAMERA IS CHILD VAN EEN EMPTYGAMEOBJECT DIE EEN CHILD IS VAN DE PLAYER.
public class BaseMovementTest : MonoBehaviour {

    Vector3 moveVector;

    private Vector3 moveDirect = Vector3.zero;
    public float jumpSpeed = 4.5f;

    public enum MoveDirection {
        Forward,
        Backward,
        Left,
        Right,
        Idle
    }

    public float moveSpeed;
    public float camSpeed;
    public float jumpCastDistance;
    public float jumpHeigth;

    public MoveDirection moveDirection;

    void Start() {
    }

   

	// Update is called once per frame
	void FixedUpdate () {
        Movement();
        //transform.position = transform.position += moveVector * Time.deltaTime;

    }
        
    void Movement() {

        transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed, 0, Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed);
        transform.Rotate(0, Input.GetAxis("Mouse X") * Time.deltaTime * camSpeed, 0);


        if(Physics.Raycast(transform.position, -transform.up, jumpCastDistance)) {
            if (Input.GetButtonDown("Jump")) {
                  //+= jumpSpeed;
            }
        }

        /*var x = Input.GetAxis("Horizontal") * Time.deltaTime * 20;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * 20;

        transform.Translate(x, 0, 0);
        transform.Translate(0, 0, z);

        switch (moveDirection) {
            case MoveDirection.Forward:
                moveVector.z = 20;
                moveVector.x = 0;
                break;
            case MoveDirection.Backward:
                moveVector.z = -20;
                moveVector.x = 0;
                break;
            case MoveDirection.Left:
                moveVector.x =- 20;
                moveVector.z = 0;
                break;
            case MoveDirection.Right:
                moveVector.x = 20;
                moveVector.z = 0;
                break;
            case MoveDirection.Idle:
                moveVector.x = 0;
                moveVector.z = 0;
                break;

        }*/
    }
}
