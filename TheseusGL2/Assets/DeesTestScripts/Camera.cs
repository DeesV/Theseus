using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//DIT SCRIPT STAAT OP DE CAMERA, DE CAMERA STAAT GECHILD AAN EEN EMPTYGAMEOBJECT DIE GECHILD IS AAN DE PLAYER.
public class Camera : MonoBehaviour {

    GameObject player;
    BaseMovement playerScript;

    // Use this for initialization
    void Start () {
        player = GameObject.FindWithTag("Player");
        playerScript = player.GetComponent<BaseMovement>();

    }

    // Update is called once per frame
    void Update () {
        CameraMovement();
    }

    public void CameraMovement() {
        transform.Rotate(-Input.GetAxis("Mouse Y") * Time.deltaTime * playerScript.camSpeed, 0, 0);
    }
}
