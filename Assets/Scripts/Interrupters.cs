using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interrupters : MonoBehaviour
{
    public GameObject door;
    public bool please;



    //Ne détecte pas la touche... Très ennuyant. Je vais faire par collision avec le collider.

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player") /*&& Input.GetKeyDown(KeyCode.Space)*/)
        {
            please = true;
            Destroy(door);
            /*if (Input.GetKeyDown("space"))
            {

                please = true;
                Destroy(door);
                *//*if (Input.GetKeyDown("KeyCode.E"))
                {
                    Destroy(door);
                }*//*
            }*/
        }
    }

    void OnTriggerExit(Collider colliderr)
    {
        if (colliderr.gameObject.CompareTag("Player"))
        {
            please = false;
        }
    }

    //Input.GetButtonDown("Fire1")
}
