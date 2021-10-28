using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUp : MonoBehaviour
{
    public Transform holdLocation;
    public LayerMask pickUpMask;

    public Vector3 direction { get; set; }
    private GameObject heldItem;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (heldItem)
            {

            }
            else 
            {
              

            
            }
        }
    }
}
