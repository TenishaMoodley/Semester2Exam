using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throwing : MonoBehaviour
{
    //public bool IsTouchingGround = false;

    public GameObject Jammo;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        /*if (collision.gameObject.tag == "Ground")
        {
            Debug.Log(IsTouchingGround);
            IsTouchingGround = true;
        }*/

        if (collision.gameObject == Jammo)                  //if barrel is being carried , then it becomes a child of Jammo
        {
            Jammo.transform.parent = transform;
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject == Jammo)                  //if barrel is being carried , then it is no longer a child of Jammo
        {
            Jammo.transform.parent = null;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "wallBreak")
        {
            Destroy(collision.gameObject);
        }

       
    }
}
