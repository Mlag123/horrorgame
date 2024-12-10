using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class PlayerMotor : MonoBehaviour
{

    private Rigidbody rb;
    private Vector3 jump = Vector3.zero;
    [SerializeField]
    private float jumpForce = 2f;
    private bool isGrounded;
    private Vector3 velocity = Vector3.zero;
    private Vector3 rotation = Vector3.zero;
    private Vector3 rotateCamera = Vector3.zero;
    private Vector3 run_velocity = Vector3.zero;
    [SerializeField]
    private Camera cam;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    public void move(Vector3 velocity)
    {
        this.velocity = velocity;

    }

    private void FixedUpdate()
    {
        performMove();
        performRotation();
        jumping();
        run();

    }
    void jumping()
    {
        if (Input.GetKey(KeyCode.Space))
        {
           // print("PRESS");
            rb.velocity = new Vector3 (0, 5, 0);
            isGrounded = false;
        }
    }
    public void setRun(Vector3 run)
    {
        run_velocity = run;
    }

    void run()
    {
        if (Input.GetKey(KeyCode.LeftShift)) {


            if (run_velocity != Vector3.zero)
            {
                rb.MovePosition(rb.position + run_velocity * Time.fixedDeltaTime);
            }
        }
    }
    private void OnCollisionStay(Collision collision)
    {
        isGrounded = true;
    }
    public void rotateCam(Vector3 rotateCamera)
    {
        this.rotateCamera = rotateCamera;
    }

    public void rotate(Vector3 rotation)
    {
        this.rotation = rotation;
    }

    void performRotation()
    {
        rb.MoveRotation(rb.rotation*Quaternion.Euler(rotation));

        if (cam != null)
        {

            cam.transform.Rotate(-rotateCamera);
        }

    }
    public void performMove()
    {
        if(velocity!= Vector3.zero)
        {
            rb.MovePosition(rb.position+velocity*Time.fixedDeltaTime);
        }
    }


    void Update()
    {
        
    }
}
