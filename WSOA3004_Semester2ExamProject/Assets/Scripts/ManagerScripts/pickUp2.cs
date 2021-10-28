using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUp2 : MonoBehaviour
{
    public Transform destination;

    void Update()
    {
        if (Input.GetKey(KeyCode.E)) 
        {
            GetComponent<Rigidbody>().useGravity =false;
            this.transform.position = destination.position;
            this.transform.parent = GameObject.Find("pickedUp").transform; 
        }

        /*if (Input.GetKeyUp(KeyCode.E)) 
        {
            this.transform.parent = null;
            GetComponent<Rigidbody>().useGravity = true;

        }*/

         
    }

    private void OnCollisionEnter(Collision collision)
    {
        
    }



}
