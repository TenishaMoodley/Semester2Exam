using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particleManager : MonoBehaviour
{
    public ParticleSystem explosion;
    // Start is called before the first frame update
    void Start()
    {
        explosion = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
       

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "wallBreak")
        {
            explosion.Play();
        }


    }
   

    // explosion.Play();


}
