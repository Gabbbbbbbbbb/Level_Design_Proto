using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{

    public bool checkingin;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerStay(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player") == true)
        {
            checkingin = true;
        }
    }

    public void OnTriggerExit(Collider colliderr)
    {
        if (colliderr.gameObject.CompareTag("Player") == false)
        {
            checkingin = false;
        }
    }
}
