using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    public Transform linkedPortal;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Player_Movement fountain = collision.gameObject.GetComponent<Player_Movement>();
            if (fountain.Teleporting == false)
            {
                fountain.Teleporting = true;
                fountain.transform.position = linkedPortal.position;
                fountain.enteredPortal = gameObject;

            }

        }
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Player_Movement fountain = collision.gameObject.GetComponent<Player_Movement>();
            if (fountain.Teleporting == true && fountain.enteredPortal != gameObject)
            {
                fountain.Teleporting = false;

                fountain.enteredPortal = null;

            }

        }
    }

}
