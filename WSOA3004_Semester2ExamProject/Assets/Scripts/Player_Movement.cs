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



    void Start()
    {
        rBody = GetComponent<Rigidbody>();
        //Cursor.visible = false;
    }

   

    private void FixedUpdate()
    {
        if (Input.GetKey(Forward))
        {
            transform.Translate(Vector3.forward * speed * Time.fixedDeltaTime, Space.Self);
        }
        if (Input.GetKey(Backward))
        {
            transform.Translate(-Vector3.forward * speed * Time.fixedDeltaTime, Space.Self);
        }
        if (Input.GetKey(Move_right))
        {
            transform.Translate(Vector3.right * speed * Time.fixedDeltaTime, Space.Self);
        }
        if (Input.GetKey(Move_Left))
        {
            transform.Translate(Vector3.left * speed * Time.fixedDeltaTime, Space.Self);
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
