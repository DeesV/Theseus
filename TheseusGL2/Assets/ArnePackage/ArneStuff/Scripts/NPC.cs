//Made by Arne
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public RaycastHit hit;
    public int checkDistance;
    public Transform target;

    public Transform thisNpcHead;
    public Transform thisNpcBody;

    public bool playerInSight;
    public string idNumber;


    void Start()
    {
       
    }
    void Update()
    {
        IsPlayerInSight();
    }
    public void IsPlayerInSight ()
    {
        Debug.DrawRay(transform.position, (target.position - transform.position).normalized * 100, Color.green);
        if (Physics.Raycast(transform.position, (target.position - transform.position).normalized * 100, out hit, checkDistance))
        {
            playerInSight = true;
            print("hit");
        }
        else
        {
            playerInSight = false;
        }
    }
    public void PlayerInteracts ()
    {
        if(playerInSight == false)
        {

        }
        if (playerInSight == true)
        {

        }
    }
}
