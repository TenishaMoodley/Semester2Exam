using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyObject : MonoBehaviour
{
    public float seconds;
    //public Animator collectableAnim;

    void Start()
    {
        StartCoroutine(Destroyself());
    }

    IEnumerator Destroyself()
    {
        yield return new WaitForSeconds(seconds);
        GameObject manager = GameObject.Find("Manager");
        manager.GetComponent<Manager>().DestroyedAdd();
        Destroy(gameObject);

        
        
    }
   
}
