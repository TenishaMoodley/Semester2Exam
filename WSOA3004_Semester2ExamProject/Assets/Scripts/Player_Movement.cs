using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public KeyCode Forward;
    public KeyCode Backward;
    public KeyCode Move_Left;
    public KeyCode Move_right;

    public float speed;

    /// Additions///
    public KeyCode Jump;
    public float jumpForce;
    public Rigidbody rBody;

    public bool isGrounded = true;

    

    public Vector3 Position_Change;

    private float MaxX = 23;
    private float MaxZ = 17;
    private float MinX = -20;
    private float MinZ = -8;

    ///Animations///
    public Animator anim;

    ///Mesh Rotation///
    public Transform faceForward;
    public Transform faceBackwards;
    public Transform faceLeft;
    public Transform faceRight;


    void Start()
    {
        rBody = GetComponent<Rigidbody>();
        //Cursor.visible = false;
        anim = GetComponent<Animator>(); 
    }

    void Update()
    {
       // Vector3 forward = faceForward.position - transform.position;
       
       // Vector3 left = faceLeft.position - transform.position;
        //Vector3 rigth = faceRight.position - transform.position;

       
        
    }



    private void FixedUpdate()
    {
        if (Input.GetKey(Forward))
        {
            transform.Translate(Vector3.forward * speed * Time.fixedDeltaTime, Space.Self);
            anim.SetBool("isRunningF", true);
        }
        if (!Input.GetKey(Forward)) 
        {
            anim.SetBool("isRunningF", false); 
        }


        if (Input.GetKey(Backward))
        {
            transform.Translate(-Vector3.forward * speed * Time.fixedDeltaTime, Space.Self);
            anim.SetBool("isRunningB", true);
        }
        if (!Input.GetKey(Backward))
        {
            anim.SetBool("isRunningB", false);
        }


        if (Input.GetKey(Move_right))
        {
            transform.Translate(Vector3.right * speed * Time.fixedDeltaTime, Space.Self);
            anim.SetBool("isRunningR", true);
        }
        if (!Input.GetKey(Move_right))
        {
            anim.SetBool("isRunningR", false);
        }


        if (Input.GetKey(Move_Left))
        {
            transform.Translate(Vector3.left * speed * Time.fixedDeltaTime, Space.Self);
            anim.SetBool("isRunningL", true);
        }
        if (!Input.GetKey(Move_Left))
        {
            anim.SetBool("isRunningL", false);
        }


        if (Input.GetKey(Jump) && isGrounded)
        {
            rBody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }

        Position_Change = transform.position;
        if (Position_Change.x >= MaxX)
        {
            Position_Change.x = MaxX;
            transform.position = Position_Change;
        }
        if (Position_Change.x <= MinX)
        {
            Position_Change.x = MinX;
            transform.position = Position_Change;

        }
        if (Position_Change.z >= MaxZ)
        {
            Position_Change.z = MaxZ;
            transform.position = Position_Change;
        }
        if (Position_Change.z <= MinZ)
        {
            Position_Change.z = MinZ;
            transform.position = Position_Change;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        //isGrounded = true;

        if (collision.gameObject.CompareTag("ground"))
        {
            isGrounded = true;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            isGrounded = false;
        }
    }
}
