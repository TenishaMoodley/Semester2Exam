using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyBarrel : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag== "Barrel")
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
    }
}
