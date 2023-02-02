using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{

    public bool checkingin;
    public Transform player;
    public Transform RespawnPoint;


    public void OnTriggerStay(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            checkingin = true;

            player.position = RespawnPoint.position;
        }
    }

    public void OnTriggerExit(Collider colliderr)
    {
        if (colliderr.gameObject.CompareTag("Player"))
        {
            checkingin = false;
        }
    }
}
