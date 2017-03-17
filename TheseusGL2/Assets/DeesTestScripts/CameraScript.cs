using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//DIT SCRIPT STAAT OP DE CAMERA, DE CAMERA STAAT GECHILD AAN EEN EMPTYGAMEOBJECT DIE GECHILD IS AAN DE PLAYER.
public class CameraScript : MonoBehaviour {
    //IK HOU VAN JE ARNE <3 JAN
    GameObject player;
    BaseMovement playerScript;
    public static CameraScript thisCamera;

    void Awake() {
        thisCamera = this;
    }

    // De start hier zoekt het object met de tag speler om in "Player" zijn BaseMovement script te komen.
    void Start () {
        player = GameObject.FindWithTag("Player");
        playerScript = player.GetComponent<BaseMovement>();

    }

    // Update roept de camera movement aan.
    void Update () {
        CameraMovement();
    }
    // De CameraMovement hier zorgt voor een verticale camera rotatie. Horizontale rotatie wordt geregeld in "BaseMovement".
    public void CameraMovement() {      
        transform.Rotate(-Input.GetAxis("Mouse Y") * Time.deltaTime * playerScript.camSpeed, 0, 0);
    }
}
